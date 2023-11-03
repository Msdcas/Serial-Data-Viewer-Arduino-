namespace Arduino_Serial_Data_Viewer
{
    partial class FStatictic
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chbParseError = new System.Windows.Forms.CheckBox();
            this.chbSerialData = new System.Windows.Forms.CheckBox();
            this.labelCountParseErr = new System.Windows.Forms.Label();
            this.labelCountSerialDataMsh = new System.Windows.Forms.Label();
            this.chbAddCR = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(639, 293);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // chbParseError
            // 
            this.chbParseError.AutoSize = true;
            this.chbParseError.ForeColor = System.Drawing.Color.Red;
            this.chbParseError.Location = new System.Drawing.Point(12, 12);
            this.chbParseError.Name = "chbParseError";
            this.chbParseError.Size = new System.Drawing.Size(90, 17);
            this.chbParseError.TabIndex = 2;
            this.chbParseError.Text = "Parsing errors";
            this.chbParseError.UseVisualStyleBackColor = true;
            this.chbParseError.CheckedChanged += new System.EventHandler(this.chbParseError_CheckedChanged);
            // 
            // chbSerialData
            // 
            this.chbSerialData.AutoSize = true;
            this.chbSerialData.Location = new System.Drawing.Point(187, 12);
            this.chbSerialData.Name = "chbSerialData";
            this.chbSerialData.Size = new System.Drawing.Size(120, 17);
            this.chbSerialData.TabIndex = 3;
            this.chbSerialData.Text = "Data from serial port";
            this.chbSerialData.UseVisualStyleBackColor = true;
            this.chbSerialData.CheckedChanged += new System.EventHandler(this.chbSerialData_CheckedChanged);
            // 
            // labelCountParseErr
            // 
            this.labelCountParseErr.AutoSize = true;
            this.labelCountParseErr.Location = new System.Drawing.Point(108, 12);
            this.labelCountParseErr.Name = "labelCountParseErr";
            this.labelCountParseErr.Size = new System.Drawing.Size(13, 13);
            this.labelCountParseErr.TabIndex = 4;
            this.labelCountParseErr.Text = "0";
            // 
            // labelCountSerialDataMsh
            // 
            this.labelCountSerialDataMsh.AutoSize = true;
            this.labelCountSerialDataMsh.Location = new System.Drawing.Point(313, 13);
            this.labelCountSerialDataMsh.Name = "labelCountSerialDataMsh";
            this.labelCountSerialDataMsh.Size = new System.Drawing.Size(13, 13);
            this.labelCountSerialDataMsh.TabIndex = 5;
            this.labelCountSerialDataMsh.Text = "0";
            // 
            // chbAddCR
            // 
            this.chbAddCR.AutoSize = true;
            this.chbAddCR.Checked = true;
            this.chbAddCR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAddCR.Location = new System.Drawing.Point(604, 13);
            this.chbAddCR.Name = "chbAddCR";
            this.chbAddCR.Size = new System.Drawing.Size(47, 17);
            this.chbAddCR.TabIndex = 21;
            this.chbAddCR.Text = "+CR";
            this.chbAddCR.UseVisualStyleBackColor = true;
            // 
            // FStatictic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 392);
            this.Controls.Add(this.chbAddCR);
            this.Controls.Add(this.labelCountSerialDataMsh);
            this.Controls.Add(this.labelCountParseErr);
            this.Controls.Add(this.chbSerialData);
            this.Controls.Add(this.chbParseError);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FStatictic";
            this.Text = "FStatictic";
            this.Load += new System.EventHandler(this.FStatictic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox chbParseError;
        private System.Windows.Forms.CheckBox chbSerialData;
        private System.Windows.Forms.Label labelCountParseErr;
        private System.Windows.Forms.Label labelCountSerialDataMsh;
        private System.Windows.Forms.CheckBox chbAddCR;
    }
}