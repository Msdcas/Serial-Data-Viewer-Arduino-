using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WebPicker.Classes;

namespace Arduino_Serial_Data_Viewer.Classes
{
    internal static class MacrosHandler
    {
        [Serializable]
        private class ButParam
        {
            public string name;
            public Color color;
            public string serial_macros;
            public List<string> parameters;

            public ButParam(string name, Color color, string macros, List<string> param)
            {
                this.name = name;
                this.color = color;
                this.serial_macros = macros;
                this.parameters = param;
            }
        }

        private static List<Button> buttons = new List<Button>();
        private static List<ComboBox> comboBoxButtons = new List<ComboBox>();
        private static List<ButParam> butParams = new List<ButParam>();

        public static string PathToMacrosFile { get; private set; } = Path.Combine(Path.
            GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
            "ButtonMacros.json");

        public static void AddButton(ref Button button)
        {
            buttons.Add(button);
        }
        public static void AddComboBox(ref ComboBox comboBox)
        {
            comboBoxButtons.Add(comboBox);
        }

        public static CResult GetMacros(Button button, string macrosParameter = null)
        {
            if (butParams == null) return new CResult(false, "Макросы для кнопок не заданы");

            var index = buttons.FindIndex(p => p.TabIndex == button.TabIndex);
            if (butParams.Count >= index)
            {
                var st = butParams[index].serial_macros.Replace("*?*", macrosParameter);
                return new CResult(false, st);
            }
            else
            {
                return new CResult(false, "Для данной кнопки макрос не задан");
            }
        }

        public static CResult Refresh()
        {
            if (!File.Exists(PathToMacrosFile))
            {
                return new CResult(false, $"File {PathToMacrosFile} NOT FOUND");
            }

            butParams = Deserialize(PathToMacrosFile);
            if (butParams == null) return new CResult(false, "The file was empty");

            int j = 0, i = 0;
            foreach (ButParam param in butParams)
            {
                buttons[i].Text = param.name;
                buttons[i].BackColor = param.color;

                if (param.parameters.Count != 0 && j < comboBoxButtons.Count)
                {
                    comboBoxButtons[j].Items.Clear();
                    comboBoxButtons[j].Items.AddRange(param.parameters.ToArray());

                    if (comboBoxButtons[j].Items.Count != 0)
                        comboBoxButtons[j].Text = comboBoxButtons[j].Items[0].ToString();
                    j++;
                }
                i++;
            }
            return new CResult(true, $"The parameters of the FIRST {butParams.Count} buttons have been updated" );
        }

        private static List<ButParam> Deserialize(string pathToFile)
        {
            List<ButParam> res = new List<ButParam>();
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                using (FileStream s = File.Open(pathToFile, FileMode.Open))
                using (StreamReader sr = new StreamReader(s))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    while (reader.Read())
                    {
                        // deserialize only when there's "{" character in the stream
                        if (reader.TokenType == JsonToken.StartObject)
                        {
                            res.Add(serializer.Deserialize<ButParam>(reader));
                        }
                    }
                }
            }
            catch (Exception e) { CLog.Msg(e.ToString()); }

            return res;
        }

    }
}
