namespace Mechanikowie
{
    partial class Form_Rozliczenia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_NrRejestracyjny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Mechanik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Koszt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Czas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_SumaNależności = new System.Windows.Forms.Label();
            this.button_PokażSumę = new System.Windows.Forms.Button();
            this.comboBox_Mechanik = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz mechanika:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NrRejestracyjny,
            this.Column_Data,
            this.Column_Mechanik,
            this.Column_Koszt,
            this.Column_Czas,
            this.Column_Suma});
            this.dataGridView1.Location = new System.Drawing.Point(36, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(754, 355);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column_NrRejestracyjny
            // 
            this.Column_NrRejestracyjny.HeaderText = "Numer rejestracyjny";
            this.Column_NrRejestracyjny.Name = "Column_NrRejestracyjny";
            this.Column_NrRejestracyjny.ReadOnly = true;
            // 
            // Column_Data
            // 
            this.Column_Data.HeaderText = "Data naprawy";
            this.Column_Data.Name = "Column_Data";
            this.Column_Data.ReadOnly = true;
            this.Column_Data.Width = 200;
            // 
            // Column_Mechanik
            // 
            this.Column_Mechanik.HeaderText = "Wykonawca";
            this.Column_Mechanik.Name = "Column_Mechanik";
            this.Column_Mechanik.ReadOnly = true;
            this.Column_Mechanik.Width = 250;
            // 
            // Column_Koszt
            // 
            this.Column_Koszt.HeaderText = "Koszt części zamiennych";
            this.Column_Koszt.Name = "Column_Koszt";
            this.Column_Koszt.ReadOnly = true;
            this.Column_Koszt.Width = 75;
            // 
            // Column_Czas
            // 
            this.Column_Czas.HeaderText = "Czas pracy";
            this.Column_Czas.Name = "Column_Czas";
            this.Column_Czas.ReadOnly = true;
            this.Column_Czas.Width = 50;
            // 
            // Column_Suma
            // 
            this.Column_Suma.HeaderText = "Suma";
            this.Column_Suma.Name = "Column_Suma";
            this.Column_Suma.ReadOnly = true;
            this.Column_Suma.Width = 75;
            // 
            // label_SumaNależności
            // 
            this.label_SumaNależności.AutoSize = true;
            this.label_SumaNależności.Location = new System.Drawing.Point(643, 32);
            this.label_SumaNależności.Name = "label_SumaNależności";
            this.label_SumaNależności.Size = new System.Drawing.Size(48, 13);
            this.label_SumaNależności.TabIndex = 4;
            this.label_SumaNależności.Text = "Łącznie:";
            // 
            // button_PokażSumę
            // 
            this.button_PokażSumę.Location = new System.Drawing.Point(381, 27);
            this.button_PokażSumę.Name = "button_PokażSumę";
            this.button_PokażSumę.Size = new System.Drawing.Size(246, 23);
            this.button_PokażSumę.TabIndex = 5;
            this.button_PokażSumę.Text = "Pokaż sumę napraw danego mechanika!";
            this.button_PokażSumę.UseVisualStyleBackColor = true;
            this.button_PokażSumę.Click += new System.EventHandler(this.button_PokażSumę_Click);
            // 
            // comboBox_Mechanik
            // 
            this.comboBox_Mechanik.FormattingEnabled = true;
            this.comboBox_Mechanik.Location = new System.Drawing.Point(163, 30);
            this.comboBox_Mechanik.Name = "comboBox_Mechanik";
            this.comboBox_Mechanik.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Mechanik.TabIndex = 6;
            // 
            // Form_Rozliczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.comboBox_Mechanik);
            this.Controls.Add(this.button_PokażSumę);
            this.Controls.Add(this.label_SumaNależności);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Rozliczenia";
            this.Text = "Rozliczenia";
            this.Load += new System.EventHandler(this.Form_Rozliczenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_SumaNależności;
        private System.Windows.Forms.Button button_PokażSumę;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NrRejestracyjny;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Mechanik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Koszt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Czas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Suma;
        private System.Windows.Forms.ComboBox comboBox_Mechanik;
    }
}