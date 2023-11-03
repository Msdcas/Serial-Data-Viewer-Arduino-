namespace Arduino_Serial_Data_Viewer
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPictureTittle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCurveTittle = new System.Windows.Forms.TextBox();
            this.comboBoxCurveSymbolType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbCountOfCurvePoints = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbCurveColor = new System.Windows.Forms.ComboBox();
            this.cbPictures = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCurveFromPicture = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPictureXAxisName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbYAxisName = new System.Windows.Forms.TextBox();
            this.bApplyPlot = new System.Windows.Forms.Button();
            this.bApplyCurve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPictureTittle
            // 
            this.tbPictureTittle.Location = new System.Drawing.Point(12, 65);
            this.tbPictureTittle.Name = "tbPictureTittle";
            this.tbPictureTittle.Size = new System.Drawing.Size(227, 20);
            this.tbPictureTittle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Picture tittle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Curve tittle";
            // 
            // tbCurveTittle
            // 
            this.tbCurveTittle.Location = new System.Drawing.Point(12, 248);
            this.tbCurveTittle.Name = "tbCurveTittle";
            this.tbCurveTittle.Size = new System.Drawing.Size(145, 20);
            this.tbCurveTittle.TabIndex = 10;
            // 
            // comboBoxCurveSymbolType
            // 
            this.comboBoxCurveSymbolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurveSymbolType.FormattingEnabled = true;
            this.comboBoxCurveSymbolType.Location = new System.Drawing.Point(12, 285);
            this.comboBoxCurveSymbolType.Name = "comboBoxCurveSymbolType";
            this.comboBoxCurveSymbolType.Size = new System.Drawing.Size(145, 21);
            this.comboBoxCurveSymbolType.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Curve symbol type";
            // 
            // mtbCountOfCurvePoints
            // 
            this.mtbCountOfCurvePoints.Location = new System.Drawing.Point(12, 364);
            this.mtbCountOfCurvePoints.Mask = "00000";
            this.mtbCountOfCurvePoints.Name = "mtbCountOfCurvePoints";
            this.mtbCountOfCurvePoints.Size = new System.Drawing.Size(86, 20);
            this.mtbCountOfCurvePoints.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Amount of points";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Curve Color";
            // 
            // cbCurveColor
            // 
            this.cbCurveColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurveColor.FormattingEnabled = true;
            this.cbCurveColor.Location = new System.Drawing.Point(12, 324);
            this.cbCurveColor.Name = "cbCurveColor";
            this.cbCurveColor.Size = new System.Drawing.Size(108, 21);
            this.cbCurveColor.TabIndex = 25;
            // 
            // cbPictures
            // 
            this.cbPictures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPictures.FormattingEnabled = true;
            this.cbPictures.Location = new System.Drawing.Point(12, 25);
            this.cbPictures.Name = "cbPictures";
            this.cbPictures.Size = new System.Drawing.Size(226, 21);
            this.cbPictures.TabIndex = 26;
            this.cbPictures.SelectedIndexChanged += new System.EventHandler(this.cbPictures_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Select picture";
            // 
            // cbCurveFromPicture
            // 
            this.cbCurveFromPicture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurveFromPicture.FormattingEnabled = true;
            this.cbCurveFromPicture.Location = new System.Drawing.Point(12, 209);
            this.cbCurveFromPicture.Name = "cbCurveFromPicture";
            this.cbCurveFromPicture.Size = new System.Drawing.Size(145, 21);
            this.cbCurveFromPicture.TabIndex = 28;
            this.cbCurveFromPicture.SelectedIndexChanged += new System.EventHandler(this.cbCurveFromPicture_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Select curve";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Picture X axis name";
            // 
            // tbPictureXAxisName
            // 
            this.tbPictureXAxisName.Location = new System.Drawing.Point(12, 104);
            this.tbPictureXAxisName.Name = "tbPictureXAxisName";
            this.tbPictureXAxisName.Size = new System.Drawing.Size(152, 20);
            this.tbPictureXAxisName.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Picture Y axis name";
            // 
            // tbYAxisName
            // 
            this.tbYAxisName.Location = new System.Drawing.Point(12, 143);
            this.tbYAxisName.Name = "tbYAxisName";
            this.tbYAxisName.Size = new System.Drawing.Size(152, 20);
            this.tbYAxisName.TabIndex = 32;
            // 
            // bApplyPlot
            // 
            this.bApplyPlot.Location = new System.Drawing.Point(170, 140);
            this.bApplyPlot.Name = "bApplyPlot";
            this.bApplyPlot.Size = new System.Drawing.Size(75, 23);
            this.bApplyPlot.TabIndex = 34;
            this.bApplyPlot.Text = "Apply";
            this.bApplyPlot.UseVisualStyleBackColor = true;
            this.bApplyPlot.Click += new System.EventHandler(this.bApplyPlot_Click);
            // 
            // bApplyCurve
            // 
            this.bApplyCurve.Location = new System.Drawing.Point(170, 361);
            this.bApplyCurve.Name = "bApplyCurve";
            this.bApplyCurve.Size = new System.Drawing.Size(75, 23);
            this.bApplyCurve.TabIndex = 35;
            this.bApplyCurve.Text = "Apply";
            this.bApplyCurve.UseVisualStyleBackColor = true;
            this.bApplyCurve.Click += new System.EventHandler(this.bApplyCurve_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 397);
            this.Controls.Add(this.bApplyCurve);
            this.Controls.Add(this.bApplyPlot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbYAxisName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPictureXAxisName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCurveFromPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPictures);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCurveColor);
            this.Controls.Add(this.tbPictureTittle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbCurveTittle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbCountOfCurvePoints);
            this.Controls.Add(this.comboBoxCurveSymbolType);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Plot & Curve Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPictureTittle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCurveTittle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCurveSymbolType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbCountOfCurvePoints;
        private System.Windows.Forms.ComboBox cbCurveColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbPictures;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCurveFromPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPictureXAxisName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbYAxisName;
        private System.Windows.Forms.Button bApplyPlot;
        private System.Windows.Forms.Button bApplyCurve;
    }
}