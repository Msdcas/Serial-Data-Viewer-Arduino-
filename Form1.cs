using Arduino_Serial_Data_Viewer.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using WebPicker.Classes;
using ZedGraph;

namespace Arduino_Serial_Data_Viewer
{
    public partial class Form1 : Form
    {
        private SerialPorts MySerialPort = new SerialPorts();

        private delegate CResult MsgSend (string msg);
        private event MsgSend _MsgSender;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CLog.SetLogsRichTb(rtbLog);

            MacrosHandler.AddButton(ref button12);
            MacrosHandler.AddButton(ref button13);
            MacrosHandler.AddButton(ref button14);
            MacrosHandler.AddButton(ref button15);
            MacrosHandler.AddButton(ref button16);
            MacrosHandler.AddButton(ref button17);
            MacrosHandler.AddButton(ref button21);
            MacrosHandler.AddButton(ref button22);
            MacrosHandler.AddButton(ref button23);

            MacrosHandler.AddComboBox(ref comboBox2);
            MacrosHandler.AddComboBox(ref comboBox3);
            MacrosHandler.AddComboBox(ref comboBox4);

            CLabelParams.AddLabel(label7);
            CLabelParams.AddLabel(label8);
            CLabelParams.AddLabel(label9);
            CLabelParams.AddLabel(label10);
            CLabelParams.AddLabel(label11);
            CLabelParams.AddLabel(label12);

            if (File.Exists(MacrosHandler.PathToMacrosFile))
            {
                CLog.Msg($"File {MacrosHandler.PathToMacrosFile} IS USED");
                MacrosHandler.Refresh();
            }
            else CLog.Msg($"File {MacrosHandler.PathToMacrosFile} NOT FOUND");

            bScanSerialPorts.PerformClick();

            cbBaudRate.Text = "9600";
            cbParity.Text = cbParity.Items[0].ToString();      // None
            cbStopBits.Text = cbStopBits.Items[1].ToString();  // One
            cbDataBits.Text = "8";

            ///settings
            CSerialDataHandler.SetStart_Separator('*');
            //CSerialDataHandler.SetEnd_Separator('*');

            // подписываемся методом AssembleSerialData на получение байтов из последовательного порта
            MySerialPort.OnSerialDataReceiveHandler += CSerialDataHandler.AssembleSerialData;
            // обработчиком MessageHandler подписываемся на событие прихода сообщения 
            CSerialDataHandler.OnMsgIncoming += CPaintManager.ProcessMessage;

            // назначаем делегату методы отправки сообщений последоват и юсб портов
            _MsgSender += MySerialPort.Send;
            //_MsgSend += cUsbPort.Send;

            // задаем все доступные области отрисовки в статич класс CPainterManager
            foreach (Control control in this.Controls)
            {
                if (control is ZedGraphControl)
                {
                    CPaintManager.AddZedGraphControl((ZedGraphControl)control);
                }
            }
            ///settings

            //cbParity.Items.AddRange(Enum.GetValues(typeof(Parity)).Cast<string>().ToArray());
            //cbStopBits.Items.AddRange(Enum.GetValues(typeof(StopBits)).Cast<string>().ToArray());
        }

        private void bScanSerialPorts_Click(object sender, EventArgs e)
        {
            cbPort.Items.Clear();
            cbPort.Items.AddRange(SerialPorts.GetSerialPortsInfo().ToArray());
            CLog.Msg($"Search: {cbPort.Items.Count} ports found");
        }

        private void bOpenAvalPort_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPort.Text))
            {
                CLog.Msg("Abort: serial port doesn't selected");
                return;
            }

            var result = MySerialPort.Open(CSerialPortInfo.Parse(cbPort.Text).Name,
                              int.Parse(cbBaudRate.Text),
                              (Parity)Enum.Parse(typeof(Parity), cbParity.Text),
                              int.Parse(cbDataBits.Text),
                              (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text)
                              );
            CLog.Msg(result.Msg);
            if (result.IsOk) BlockElemIsPortOpened(true);
        }

        private void bClosePort_Click(object sender, EventArgs e)
        {
            CResult res = null;
            if (MySerialPort != null)
                res = MySerialPort.Close();
            if (res.IsOk) { BlockElemIsPortOpened(false); }
            CLog.Msg(res.Msg);
        }

        private void BlockElemIsPortOpened(bool flag) {
            bOpenAvalPort.Enabled = !flag;
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            string msg = tbMsg.Text;
            if (chbAddCR.Checked) msg += "\r\n";

            foreach (var res in InvokeMsgDelegate(msg))
                CLog.Msg(res.Msg);
        }

        private List<CResult> InvokeMsgDelegate(string msg)
        {
            List<CResult> results = new List<CResult>();

            // используется механизм обратного вызова делегата
            // для вызова каждого подписанного на него метода, получения и добавления результата
            // вызова этого метода в массив
            if (_MsgSender != null && msg != null)
            {
                foreach (Delegate del in _MsgSender.GetInvocationList())
                    results.Add( ((MsgSend)del) (msg) );
            }
            return results;
        }

        #region Macros buttons
        private void button12_Click(object sender, EventArgs e)
        {
            var res = MacrosHandler.GetMacros(button12);
            if (res.IsOk)
                MySerialPort.Send(res.Msg);
            else CLog.Msg(res.Msg);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var res = MacrosHandler.GetMacros(button13);
            if (res.IsOk)
                MySerialPort.Send(res.Msg);
            else CLog.Msg(res.Msg);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var res = MacrosHandler.GetMacros(button14);
            if (res.IsOk)
                MySerialPort.Send(res.Msg);
            else CLog.Msg(res.Msg);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var res = MacrosHandler.GetMacros(button17);
            if (res.IsOk)
                MySerialPort.Send(res.Msg);
            else CLog.Msg(res.Msg);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var res = MacrosHandler.GetMacros(button16);
            if (res.IsOk)
                MySerialPort.Send(res.Msg);
            else CLog.Msg(res.Msg);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var res = MacrosHandler.GetMacros(button15);
            if (res.IsOk)
                MySerialPort.Send(res.Msg);
            else CLog.Msg(res.Msg);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            var res = MacrosHandler.GetMacros(button23, comboBox4.Text);
            if (res.IsOk)
                MySerialPort.Send(res.Msg);
            else CLog.Msg(res.Msg);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var res = MacrosHandler.GetMacros(button22, comboBox3.Text);
            if (res.IsOk)
                MySerialPort.Send(res.Msg);
            else CLog.Msg(res.Msg);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var res = MacrosHandler.GetMacros(button21, comboBox2.Text);
            if (res.IsOk)
                MySerialPort.Send(res.Msg);
            else CLog.Msg(res.Msg);
        }

        private void buttonRefreshMacros_Click(object sender, EventArgs e)
        {
            CLog.Msg(MacrosHandler.Refresh().Msg);
        }

        #endregion

        private void button11_Click(object sender, EventArgs e) // settings button click
        { 
            var FormSettings = new FormSettings();
            FormSettings.ShowDialog();
        }

        private void bViewStatictic_Click(object sender, EventArgs e)
        {
            FStatictic fStatictic = new FStatictic();
            fStatictic.Show();
        }
    }
}
