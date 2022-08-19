namespace Mechanikowie
{
    partial class Form_WszystkieNaprawy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_NrRejestracyjny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Mechanik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Koszt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Czas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_DodajNaprawę = new System.Windows.Forms.Button();
            this.button_Rozliczenia = new System.Windows.Forms.Button();
            this.button_IleSamochodówZŁodzi = new System.Windows.Forms.Button();
            this.label_wynik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Column_Czas});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(684, 355);
            this.dataGridView1.TabIndex = 0;
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
            // button_DodajNaprawę
            // 
            this.button_DodajNaprawę.Location = new System.Drawing.Point(12, 373);
            this.button_DodajNaprawę.Name = "button_DodajNaprawę";
            this.button_DodajNaprawę.Size = new System.Drawing.Size(213, 42);
            this.button_DodajNaprawę.TabIndex = 1;
            this.button_DodajNaprawę.Text = "Dodaj naprawę";
            this.button_DodajNaprawę.UseVisualStyleBackColor = true;
            this.button_DodajNaprawę.Click += new System.EventHandler(this.button_DodajNaprawę_Click);
            // 
            // button_Rozliczenia
            // 
            this.button_Rozliczenia.Location = new System.Drawing.Point(259, 373);
            this.button_Rozliczenia.Name = "button_Rozliczenia";
            this.button_Rozliczenia.Size = new System.Drawing.Size(213, 42);
            this.button_Rozliczenia.TabIndex = 3;
            this.button_Rozliczenia.Text = "Rozliczenia";
            this.button_Rozliczenia.UseVisualStyleBackColor = true;
            this.button_Rozliczenia.Click += new System.EventHandler(this.button_Rozliczenia_Click);
            // 
            // button_IleSamochodówZŁodzi
            // 
            this.button_IleSamochodówZŁodzi.Location = new System.Drawing.Point(505, 373);
            this.button_IleSamochodówZŁodzi.Name = "button_IleSamochodówZŁodzi";
            this.button_IleSamochodówZŁodzi.Size = new System.Drawing.Size(191, 42);
            this.button_IleSamochodówZŁodzi.TabIndex = 4;
            this.button_IleSamochodówZŁodzi.Text = "Ile samochodów jest z Łodzi?";
            this.button_IleSamochodówZŁodzi.UseVisualStyleBackColor = true;
            this.button_IleSamochodówZŁodzi.Click += new System.EventHandler(this.button_IleSamochodówZŁodzi_Click);
            // 
            // label_wynik
            // 
            this.label_wynik.AutoSize = true;
            this.label_wynik.Location = new System.Drawing.Point(505, 425);
            this.label_wynik.Name = "label_wynik";
            this.label_wynik.Size = new System.Drawing.Size(135, 13);
            this.label_wynik.TabIndex = 5;
            this.label_wynik.Text = "Ilość samochodów z Łodzi:";
            // 
            // Form_WszystkieNaprawy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.label_wynik);
            this.Controls.Add(this.button_IleSamochodówZŁodzi);
            this.Controls.Add(this.button_Rozliczenia);
            this.Controls.Add(this.button_DodajNaprawę);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_WszystkieNaprawy";
            this.Text = "Wszystkie naprawy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_DodajNaprawę;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NrRejestracyjny;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Mechanik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Koszt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Czas;
        private System.Windows.Forms.Button button_Rozliczenia;
        private System.Windows.Forms.Button button_IleSamochodówZŁodzi;
        private System.Windows.Forms.Label label_wynik;
    }
}

