namespace PublicApiWinClient
{
    partial class Form1
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
            this.textURI = new System.Windows.Forms.TextBox();
            this.cmdExecuta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdDeserializare = new System.Windows.Forms.Button();
            this.cmdClearDebug = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.converteste = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.valueForConversion = new System.Windows.Forms.NumericUpDown();
            this.valueAfterConversion = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textResponseAPI = new System.Windows.Forms.TextBox();
            this.textDebugOuput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.valueForConversion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueAfterConversion)).BeginInit();
            this.SuspendLayout();
            // 
            // textURI
            // 
            this.textURI.Location = new System.Drawing.Point(113, 36);
            this.textURI.Name = "textURI";
            this.textURI.Size = new System.Drawing.Size(404, 20);
            this.textURI.TabIndex = 0;
            // 
            // cmdExecuta
            // 
            this.cmdExecuta.Location = new System.Drawing.Point(545, 33);
            this.cmdExecuta.Name = "cmdExecuta";
            this.cmdExecuta.Size = new System.Drawing.Size(190, 23);
            this.cmdExecuta.TabIndex = 2;
            this.cmdExecuta.Text = "Executa";
            this.cmdExecuta.UseVisualStyleBackColor = true;
            this.cmdExecuta.Click += new System.EventHandler(this.CmdExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Request URI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Raspuns:";
            // 
            // cmdDeserializare
            // 
            this.cmdDeserializare.Location = new System.Drawing.Point(23, 330);
            this.cmdDeserializare.Name = "cmdDeserializare";
            this.cmdDeserializare.Size = new System.Drawing.Size(75, 23);
            this.cmdDeserializare.TabIndex = 5;
            this.cmdDeserializare.Text = "Deserializare";
            this.cmdDeserializare.UseVisualStyleBackColor = true;
            this.cmdDeserializare.Click += new System.EventHandler(this.CmdDeserialize_Click);
            // 
            // cmdClearDebug
            // 
            this.cmdClearDebug.Location = new System.Drawing.Point(104, 330);
            this.cmdClearDebug.Name = "cmdClearDebug";
            this.cmdClearDebug.Size = new System.Drawing.Size(75, 23);
            this.cmdClearDebug.TabIndex = 6;
            this.cmdClearDebug.Text = "Clear Debug";
            this.cmdClearDebug.UseVisualStyleBackColor = true;
            this.cmdClearDebug.Click += new System.EventHandler(this.CmdClearDebug_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alege monedă:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 538);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Suma:";
            // 
            // converteste
            // 
            this.converteste.Location = new System.Drawing.Point(325, 538);
            this.converteste.Name = "converteste";
            this.converteste.Size = new System.Drawing.Size(121, 25);
            this.converteste.TabIndex = 12;
            this.converteste.Text = "Convertește în:";
            this.converteste.UseVisualStyleBackColor = true;
            this.converteste.Click += new System.EventHandler(this.ConversionButton);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Alege monedă:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Valoare rezultată:";
            // 
            // valueForConversion
            // 
            this.valueForConversion.DecimalPlaces = 6;
            this.valueForConversion.Location = new System.Drawing.Point(43, 538);
            this.valueForConversion.Name = "valueForConversion";
            this.valueForConversion.Size = new System.Drawing.Size(75, 20);
            this.valueForConversion.TabIndex = 17;
            // 
            // valueAfterConversion
            // 
            this.valueAfterConversion.DecimalPlaces = 6;
            this.valueAfterConversion.Location = new System.Drawing.Point(663, 538);
            this.valueAfterConversion.Name = "valueAfterConversion";
            this.valueAfterConversion.Size = new System.Drawing.Size(75, 20);
            this.valueAfterConversion.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(476, 539);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // textResponseAPI
            // 
            this.textResponseAPI.Location = new System.Drawing.Point(36, 94);
            this.textResponseAPI.Multiline = true;
            this.textResponseAPI.Name = "textResponseAPI";
            this.textResponseAPI.Size = new System.Drawing.Size(702, 230);
            this.textResponseAPI.TabIndex = 26;
            // 
            // textDebugOuput
            // 
            this.textDebugOuput.Location = new System.Drawing.Point(36, 365);
            this.textDebugOuput.Multiline = true;
            this.textDebugOuput.Name = "textDebugOuput";
            this.textDebugOuput.Size = new System.Drawing.Size(702, 144);
            this.textDebugOuput.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 606);
            this.Controls.Add(this.textDebugOuput);
            this.Controls.Add(this.textResponseAPI);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.valueAfterConversion);
            this.Controls.Add(this.valueForConversion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.converteste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdClearDebug);
            this.Controls.Add(this.cmdDeserializare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdExecuta);
            this.Controls.Add(this.textURI);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.valueForConversion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueAfterConversion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textURI;
        //private static System.Windows.Forms.TextBox textResponseAPI;
        private System.Windows.Forms.Button cmdExecuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdDeserializare;
        private System.Windows.Forms.Button cmdClearDebug;
        //private static System.Windows.Forms.TextBox textDebugOuput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button converteste;
        private System.Windows.Forms.Label label5;
        //private static System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown valueForConversion;
        private System.Windows.Forms.NumericUpDown valueAfterConversion;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textResponseAPI;
        private System.Windows.Forms.TextBox textDebugOuput;
    }
}

