using Arduino_Serial_Data_Viewer.Classes;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Arduino_Serial_Data_Viewer
{
    public partial class FStatictic : Form
    {
        private delegate void MyDelegate(string msg, Color color);
        private int countParseErr = 0;
        private int countSerialMsg = 0;

        public FStatictic()
        {
            InitializeComponent();
        }

        private void FStatictic_Load(object sender, EventArgs e)
        {
            
            
        }

        private void AddMsg(string msg, Color color)
        {
            if (richTextBox1.InvokeRequired)
            {
                MyDelegate d = new MyDelegate(AddMsg);
                richTextBox1.Invoke(d, new object[] { msg, color });
            }
            else
            {
                if (!string.IsNullOrEmpty(msg))
                {
                    //string time = DateTime.Now.ToString("dd.MM HH:mm:ss");
                    //StringBuilder sb = new StringBuilder(time + "  " + msg);
                    //sb.AppendLine();
                    //sb.AppendLine(richTextBox1.Text);
                    //richTextBox1.Text = sb.ToString();

                    //string line = $"{time}  {msg}";
                    if (chbAddCR.Checked) msg += "\r\n";
                    richTextBox1.AppendText(msg);

                    richTextBox1.Select(
                        richTextBox1.GetFirstCharIndexFromLine(richTextBox1.Lines.Count()-1), msg.Length);
                    richTextBox1.SelectionColor = color;
                    richTextBox1.ScrollToCaret();
                }
            }
        }

        private void ErrorReceiver(string msg)
        {
            AddMsg(msg, Color.Red);

            countParseErr++;
            SetLabelText(labelCountParseErr, countParseErr.ToString());
        }

        private void SerialDataReceiver(string msg)
        {
            AddMsg(msg, Color.Black);

            countSerialMsg++;
            SetLabelText(labelCountSerialDataMsh, countSerialMsg.ToString());
        }

        private void chbParseError_CheckedChanged(object sender, EventArgs e)
        {
            if (chbParseError.Checked) CSerialDataHandler.ErrorOccurred += ErrorReceiver;
            else CSerialDataHandler.ErrorOccurred -= ErrorReceiver;
        }

        private void chbSerialData_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSerialData.Checked) CSerialDataHandler.SerialDataIncoming += SerialDataReceiver;
            else CSerialDataHandler.SerialDataIncoming -= SerialDataReceiver;
        }


        private delegate void SetLabeltext(Label label, string text);
        private void SetLabelText(Label label, string text)
        {
            if (label.InvokeRequired) {
                SetLabeltext d = new SetLabeltext(SetLabelText);
                richTextBox1.Invoke(d, new object[] { label, text });
            }
            else
            {
                label.Text = text;
            }
        }
    }
}
