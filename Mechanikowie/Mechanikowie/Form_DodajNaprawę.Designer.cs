namespace Mechanikowie
{
    partial class Form_DodajNaprawę
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NumerRejestracji = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_DataNaprawy = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Mechanik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_KosztCzęści = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CzasPracy = new System.Windows.Forms.NumericUpDown();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Anuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KosztCzęści)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CzasPracy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr rejestracyjny";
            // 
            // textBox_NumerRejestracji
            // 
            this.textBox_NumerRejestracji.Location = new System.Drawing.Point(117, 26);
            this.textBox_NumerRejestracji.Name = "textBox_NumerRejestracji";
            this.textBox_NumerRejestracji.Size = new System.Drawing.Size(200, 20);
            this.textBox_NumerRejestracji.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data naprawy";
            // 
            // dateTimePicker_DataNaprawy
            // 
            this.dateTimePicker_DataNaprawy.Location = new System.Drawing.Point(117, 52);
            this.dateTimePicker_DataNaprawy.Name = "dateTimePicker_DataNaprawy";
            this.dateTimePicker_DataNaprawy.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_DataNaprawy.TabIndex = 3;
            // 
            // comboBox_Mechanik
            // 
            this.comboBox_Mechanik.FormattingEnabled = true;
            this.comboBox_Mechanik.Location = new System.Drawing.Point(117, 78);
            this.comboBox_Mechanik.Name = "comboBox_Mechanik";
            this.comboBox_Mechanik.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Mechanik.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mechanik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Koszt części";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Czas pracy";
            // 
            // numericUpDown_KosztCzęści
            // 
            this.numericUpDown_KosztCzęści.DecimalPlaces = 2;
            this.numericUpDown_KosztCzęści.Location = new System.Drawing.Point(117, 105);
            this.numericUpDown_KosztCzęści.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_KosztCzęści.Name = "numericUpDown_KosztCzęści";
            this.numericUpDown_KosztCzęści.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown_KosztCzęści.TabIndex = 8;
            // 
            // numericUpDown_CzasPracy
            // 
            this.numericUpDown_CzasPracy.Location = new System.Drawing.Point(117, 131);
            this.numericUpDown_CzasPracy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_CzasPracy.Name = "numericUpDown_CzasPracy";
            this.numericUpDown_CzasPracy.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown_CzasPracy.TabIndex = 9;
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(35, 166);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(108, 38);
            this.button_OK.TabIndex = 10;
            this.button_OK.Text = "OK!";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Anuluj
            // 
            this.button_Anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Anuluj.Location = new System.Drawing.Point(209, 166);
            this.button_Anuluj.Name = "button_Anuluj";
            this.button_Anuluj.Size = new System.Drawing.Size(108, 38);
            this.button_Anuluj.TabIndex = 11;
            this.button_Anuluj.Text = "Anuluj!";
            this.button_Anuluj.UseVisualStyleBackColor = true;
            this.button_Anuluj.Click += new System.EventHandler(this.button_Anuluj_Click);
            // 
            // Form_DodajNaprawę
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 216);
            this.Controls.Add(this.button_Anuluj);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.numericUpDown_CzasPracy);
            this.Controls.Add(this.numericUpDown_KosztCzęści);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Mechanik);
            this.Controls.Add(this.dateTimePicker_DataNaprawy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NumerRejestracji);
            this.Controls.Add(this.label1);
            this.Name = "Form_DodajNaprawę";
            this.Text = "Formularz dodawania naprawy";
            this.Load += new System.EventHandler(this.Form_DodajNaprawę_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KosztCzęści)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CzasPracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NumerRejestracji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataNaprawy;
        private System.Windows.Forms.ComboBox comboBox_Mechanik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_KosztCzęści;
        private System.Windows.Forms.NumericUpDown numericUpDown_CzasPracy;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Anuluj;
    }
}