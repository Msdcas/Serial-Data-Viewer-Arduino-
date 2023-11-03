namespace Arduino_Serial_Data_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.bClosePort = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.bScanSerialPorts = new System.Windows.Forms.Button();
            this.bOpenAvalPort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbAddCR = new System.Windows.Forms.CheckBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.bGraph0ScaleXMore = new System.Windows.Forms.Button();
            this.bGraph0ScaleYMore = new System.Windows.Forms.Button();
            this.bGraph0ScaleXLess = new System.Windows.Forms.Button();
            this.bGraph0ScaleYLess = new System.Windows.Forms.Button();
            this.bGraph1ScaleYLess = new System.Windows.Forms.Button();
            this.bGraph1ScaleXLess = new System.Windows.Forms.Button();
            this.bGraph1ScaleYMore = new System.Windows.Forms.Button();
            this.bGraph1ScaleXMore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonRefreshMacros = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bGraph1ScaleAuto = new System.Windows.Forms.Button();
            this.bGraph0ScaleAuto = new System.Windows.Forms.Button();
            this.bViewStatictic = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(8, 74);
            this.cbPort.Margin = new System.Windows.Forms.Padding(2);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(405, 21);
            this.cbPort.TabIndex = 1;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "75",
            "110",
            "13",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "11400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.cbBaudRate.Location = new System.Drawing.Point(8, 28);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(92, 21);
            this.cbBaudRate.TabIndex = 2;
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(104, 28);
            this.cbParity.Margin = new System.Windows.Forms.Padding(2);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(92, 21);
            this.cbParity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select available serial port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop Bits";
            // 
            // cbStopBits
            // 
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.Enabled = false;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.cbStopBits.Location = new System.Drawing.Point(200, 28);
            this.cbStopBits.Margin = new System.Windows.Forms.Padding(2);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(92, 21);
            this.cbStopBits.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Bits";
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(296, 28);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(92, 21);
            this.cbDataBits.TabIndex = 10;
            // 
            // bClosePort
            // 
            this.bClosePort.Location = new System.Drawing.Point(217, 99);
            this.bClosePort.Margin = new System.Windows.Forms.Padding(2);
            this.bClosePort.Name = "bClosePort";
            this.bClosePort.Size = new System.Drawing.Size(91, 24);
            this.bClosePort.TabIndex = 11;
            this.bClosePort.Text = "Disconnect";
            this.bClosePort.UseVisualStyleBackColor = true;
            this.bClosePort.Click += new System.EventHandler(this.bClosePort_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(675, 593);
            this.tbMsg.Margin = new System.Windows.Forms.Padding(2);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(255, 20);
            this.tbMsg.TabIndex = 14;
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(996, 592);
            this.bSend.Margin = new System.Windows.Forms.Padding(2);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(80, 20);
            this.bSend.TabIndex = 15;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(668, 619);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(2);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(408, 99);
            this.rtbLog.TabIndex = 16;
            this.rtbLog.Text = "";
            // 
            // bScanSerialPorts
            // 
            this.bScanSerialPorts.Location = new System.Drawing.Point(105, 99);
            this.bScanSerialPorts.Margin = new System.Windows.Forms.Padding(2);
            this.bScanSerialPorts.Name = "bScanSerialPorts";
            this.bScanSerialPorts.Size = new System.Drawing.Size(96, 24);
            this.bScanSerialPorts.TabIndex = 13;
            this.bScanSerialPorts.Text = "Scan serial";
            this.bScanSerialPorts.UseVisualStyleBackColor = true;
            this.bScanSerialPorts.Click += new System.EventHandler(this.bScanSerialPorts_Click);
            // 
            // bOpenAvalPort
            // 
            this.bOpenAvalPort.Location = new System.Drawing.Point(322, 99);
            this.bOpenAvalPort.Margin = new System.Windows.Forms.Padding(2);
            this.bOpenAvalPort.Name = "bOpenAvalPort";
            this.bOpenAvalPort.Size = new System.Drawing.Size(91, 24);
            this.bOpenAvalPort.TabIndex = 12;
            this.bOpenAvalPort.Text = "Connect";
            this.bOpenAvalPort.UseVisualStyleBackColor = true;
            this.bOpenAvalPort.Click += new System.EventHandler(this.bOpenAvalPort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bScanSerialPorts);
            this.groupBox2.Controls.Add(this.cbBaudRate);
            this.groupBox2.Controls.Add(this.bOpenAvalPort);
            this.groupBox2.Controls.Add(this.cbParity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbPort);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbDataBits);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bClosePort);
            this.groupBox2.Controls.Add(this.cbStopBits);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(667, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(420, 132);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial port manager";
            // 
            // chbAddCR
            // 
            this.chbAddCR.AutoSize = true;
            this.chbAddCR.Location = new System.Drawing.Point(935, 596);
            this.chbAddCR.Name = "chbAddCR";
            this.chbAddCR.Size = new System.Drawing.Size(47, 17);
            this.chbAddCR.TabIndex = 20;
            this.chbAddCR.Text = "+CR";
            this.chbAddCR.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 351);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(600, 341);
            this.zedGraphControl1.TabIndex = 21;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(12, 6);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(600, 339);
            this.zedGraphControl2.TabIndex = 22;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // bGraph0ScaleXMore
            // 
            this.bGraph0ScaleXMore.Enabled = false;
            this.bGraph0ScaleXMore.Location = new System.Drawing.Point(615, 263);
            this.bGraph0ScaleXMore.Name = "bGraph0ScaleXMore";
            this.bGraph0ScaleXMore.Size = new System.Drawing.Size(45, 38);
            this.bGraph0ScaleXMore.TabIndex = 27;
            this.bGraph0ScaleXMore.Text = "<-X->";
            this.bGraph0ScaleXMore.UseVisualStyleBackColor = true;
            // 
            // bGraph0ScaleYMore
            // 
            this.bGraph0ScaleYMore.Enabled = false;
            this.bGraph0ScaleYMore.Location = new System.Drawing.Point(614, 219);
            this.bGraph0ScaleYMore.Name = "bGraph0ScaleYMore";
            this.bGraph0ScaleYMore.Size = new System.Drawing.Size(45, 38);
            this.bGraph0ScaleYMore.TabIndex = 28;
            this.bGraph0ScaleYMore.Text = "<-Y->";
            this.bGraph0ScaleYMore.UseVisualStyleBackColor = true;
            // 
            // bGraph0ScaleXLess
            // 
            this.bGraph0ScaleXLess.Enabled = false;
            this.bGraph0ScaleXLess.Location = new System.Drawing.Point(615, 307);
            this.bGraph0ScaleXLess.Name = "bGraph0ScaleXLess";
            this.bGraph0ScaleXLess.Size = new System.Drawing.Size(45, 38);
            this.bGraph0ScaleXLess.TabIndex = 29;
            this.bGraph0ScaleXLess.Text = "->X<-";
            this.bGraph0ScaleXLess.UseVisualStyleBackColor = true;
            // 
            // bGraph0ScaleYLess
            // 
            this.bGraph0ScaleYLess.Enabled = false;
            this.bGraph0ScaleYLess.Location = new System.Drawing.Point(614, 175);
            this.bGraph0ScaleYLess.Name = "bGraph0ScaleYLess";
            this.bGraph0ScaleYLess.Size = new System.Drawing.Size(45, 38);
            this.bGraph0ScaleYLess.TabIndex = 30;
            this.bGraph0ScaleYLess.Text = "->Y<-";
            this.bGraph0ScaleYLess.UseVisualStyleBackColor = true;
            // 
            // bGraph1ScaleYLess
            // 
            this.bGraph1ScaleYLess.Enabled = false;
            this.bGraph1ScaleYLess.Location = new System.Drawing.Point(615, 520);
            this.bGraph1ScaleYLess.Name = "bGraph1ScaleYLess";
            this.bGraph1ScaleYLess.Size = new System.Drawing.Size(45, 38);
            this.bGraph1ScaleYLess.TabIndex = 34;
            this.bGraph1ScaleYLess.Text = "->Y<-";
            this.bGraph1ScaleYLess.UseVisualStyleBackColor = true;
            // 
            // bGraph1ScaleXLess
            // 
            this.bGraph1ScaleXLess.Enabled = false;
            this.bGraph1ScaleXLess.Location = new System.Drawing.Point(616, 652);
            this.bGraph1ScaleXLess.Name = "bGraph1ScaleXLess";
            this.bGraph1ScaleXLess.Size = new System.Drawing.Size(45, 38);
            this.bGraph1ScaleXLess.TabIndex = 33;
            this.bGraph1ScaleXLess.Text = "->X<-";
            this.bGraph1ScaleXLess.UseVisualStyleBackColor = true;
            // 
            // bGraph1ScaleYMore
            // 
            this.bGraph1ScaleYMore.Enabled = false;
            this.bGraph1ScaleYMore.Location = new System.Drawing.Point(615, 564);
            this.bGraph1ScaleYMore.Name = "bGraph1ScaleYMore";
            this.bGraph1ScaleYMore.Size = new System.Drawing.Size(45, 38);
            this.bGraph1ScaleYMore.TabIndex = 32;
            this.bGraph1ScaleYMore.Text = "<-Y->";
            this.bGraph1ScaleYMore.UseVisualStyleBackColor = true;
            // 
            // bGraph1ScaleXMore
            // 
            this.bGraph1ScaleXMore.Enabled = false;
            this.bGraph1ScaleXMore.Location = new System.Drawing.Point(616, 608);
            this.bGraph1ScaleXMore.Name = "bGraph1ScaleXMore";
            this.bGraph1ScaleXMore.Size = new System.Drawing.Size(45, 38);
            this.bGraph1ScaleXMore.TabIndex = 31;
            this.bGraph1ScaleXMore.Text = "<-X->";
            this.bGraph1ScaleXMore.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.buttonRefreshMacros);
            this.groupBox3.Controls.Add(this.button21);
            this.groupBox3.Controls.Add(this.button22);
            this.groupBox3.Controls.Add(this.button23);
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Controls.Add(this.button16);
            this.groupBox3.Controls.Add(this.button17);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Location = new System.Drawing.Point(667, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 220);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customizable macros";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(287, 162);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(126, 21);
            this.comboBox4.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(141, 162);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 21);
            this.comboBox3.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(8, 162);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // buttonRefreshMacros
            // 
            this.buttonRefreshMacros.Location = new System.Drawing.Point(337, 189);
            this.buttonRefreshMacros.Name = "buttonRefreshMacros";
            this.buttonRefreshMacros.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshMacros.TabIndex = 13;
            this.buttonRefreshMacros.Text = "refresh";
            this.buttonRefreshMacros.UseVisualStyleBackColor = true;
            this.buttonRefreshMacros.Click += new System.EventHandler(this.buttonRefreshMacros_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(6, 110);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(125, 45);
            this.button21.TabIndex = 8;
            this.button21.Text = "Macros 7";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(137, 110);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(144, 45);
            this.button22.TabIndex = 7;
            this.button22.Text = "Macros 8";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(287, 109);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(125, 45);
            this.button23.TabIndex = 6;
            this.button23.Text = "Macros 9";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(6, 59);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(125, 45);
            this.button15.TabIndex = 5;
            this.button15.Text = "Macros 4";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(137, 58);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(144, 45);
            this.button16.TabIndex = 4;
            this.button16.Text = "Macros 5";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(287, 58);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(125, 45);
            this.button17.TabIndex = 3;
            this.button17.Text = "Macros 6";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(287, 19);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(125, 34);
            this.button14.TabIndex = 2;
            this.button14.Text = "Macros 3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(137, 19);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(144, 34);
            this.button13.TabIndex = 1;
            this.button13.Text = "Macros 2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(7, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(125, 34);
            this.button12.TabIndex = 0;
            this.button12.Text = "Macros 1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(521, 697);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(91, 23);
            this.button11.TabIndex = 36;
            this.button11.Text = "Settings...";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(669, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 104);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10. Not set";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "label11. Not set";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "label12. Not set";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "label9. Not set";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8. Not set";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7. Not set";
            // 
            // bGraph1ScaleAuto
            // 
            this.bGraph1ScaleAuto.Enabled = false;
            this.bGraph1ScaleAuto.Location = new System.Drawing.Point(616, 476);
            this.bGraph1ScaleAuto.Name = "bGraph1ScaleAuto";
            this.bGraph1ScaleAuto.Size = new System.Drawing.Size(45, 38);
            this.bGraph1ScaleAuto.TabIndex = 38;
            this.bGraph1ScaleAuto.Text = "auto";
            this.bGraph1ScaleAuto.UseVisualStyleBackColor = true;
            // 
            // bGraph0ScaleAuto
            // 
            this.bGraph0ScaleAuto.Enabled = false;
            this.bGraph0ScaleAuto.Location = new System.Drawing.Point(614, 132);
            this.bGraph0ScaleAuto.Name = "bGraph0ScaleAuto";
            this.bGraph0ScaleAuto.Size = new System.Drawing.Size(45, 38);
            this.bGraph0ScaleAuto.TabIndex = 39;
            this.bGraph0ScaleAuto.Text = "auto";
            this.bGraph0ScaleAuto.UseVisualStyleBackColor = true;
            // 
            // bViewStatictic
            // 
            this.bViewStatictic.Location = new System.Drawing.Point(401, 697);
            this.bViewStatictic.Name = "bViewStatictic";
            this.bViewStatictic.Size = new System.Drawing.Size(103, 23);
            this.bViewStatictic.TabIndex = 40;
            this.bViewStatictic.Text = "view full log";
            this.bViewStatictic.UseVisualStyleBackColor = true;
            this.bViewStatictic.Click += new System.EventHandler(this.bViewStatictic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 729);
            this.Controls.Add(this.bViewStatictic);
            this.Controls.Add(this.bGraph0ScaleAuto);
            this.Controls.Add(this.bGraph1ScaleAuto);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bGraph1ScaleYLess);
            this.Controls.Add(this.bGraph1ScaleXLess);
            this.Controls.Add(this.bGraph1ScaleYMore);
            this.Controls.Add(this.bGraph1ScaleXMore);
            this.Controls.Add(this.bGraph0ScaleYLess);
            this.Controls.Add(this.bGraph0ScaleXLess);
            this.Controls.Add(this.bGraph0ScaleYMore);
            this.Controls.Add(this.bGraph0ScaleXMore);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.chbAddCR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbMsg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1114, 768);
            this.Name = "Form1";
            this.Text = "Serial Data Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Button bClosePort;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bOpenAvalPort;
        private System.Windows.Forms.Button bScanSerialPorts;
        private System.Windows.Forms.CheckBox chbAddCR;
        public ZedGraph.ZedGraphControl zedGraphControl1;
        public ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Button bGraph0ScaleXMore;
        private System.Windows.Forms.Button bGraph0ScaleYMore;
        private System.Windows.Forms.Button bGraph0ScaleXLess;
        private System.Windows.Forms.Button bGraph0ScaleYLess;
        private System.Windows.Forms.Button bGraph1ScaleYLess;
        private System.Windows.Forms.Button bGraph1ScaleXLess;
        private System.Windows.Forms.Button bGraph1ScaleYMore;
        private System.Windows.Forms.Button bGraph1ScaleXMore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button buttonRefreshMacros;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bGraph1ScaleAuto;
        private System.Windows.Forms.Button bGraph0ScaleAuto;
        private System.Windows.Forms.Button bViewStatictic;
    }
}

