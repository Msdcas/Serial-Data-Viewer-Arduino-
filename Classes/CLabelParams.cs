using System.Collections.Generic;
using System.Windows.Forms;

namespace Arduino_Serial_Data_Viewer.Classes
{
    internal static class CLabelParams
    {
        private static List<Label> labels = new List<Label>();

        // label.Text = labelPriambles[i] + ' = ' + labelValues[i]
        private static List<string> labelPriambles = new List<string>();
        private static List<string> labelValues = new List<string>();
        public static void AddLabel(Label label)
        {
            labels.Add(label);
            labelPriambles.Add(null);
            labelValues.Add(null);
        }

        public static void SetLabelPreamble(int labelIndex, string preamble) 
        {
            if (labelIndex < labels.Count && labelIndex >= 0)
            {
                labelPriambles[labelIndex] = preamble;
                SetText(labelIndex);
            }
        }

        public static void SetLabelValue(int labelIndex, string value)
        {
            if (labelIndex < labels.Count && labelIndex >= 0)
            {
                labelValues[labelIndex] = value;
                SetText(labelIndex);
            }
        }

        private static void SetText(int index)
        {
            if (labels[index].InvokeRequired)
            {
                labels[index].Invoke(new MethodInvoker(delegate { SetText(index); }));
            }
            else
            {
                labels[index].Text = labelPriambles[index] + labelValues[index];
            }
        }

    }
}
