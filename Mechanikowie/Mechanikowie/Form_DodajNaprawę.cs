using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mechanikowie
{
    public partial class Form_DodajNaprawę : Form
    {
        CzynnośćSerwisowa czynnośćSerwisowa;
        internal Form_DodajNaprawę(CzynnośćSerwisowa czynnośćSerwisowa)
        {
            InitializeComponent();
            this.czynnośćSerwisowa = czynnośćSerwisowa;
        }

        private void Form_DodajNaprawę_Load(object sender, EventArgs e)
        {
            foreach (Mechanik m in Mechanik.mechanikowie)
                comboBox_Mechanik.Items.Add(m);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            czynnośćSerwisowa.Numer_Rejestracyjny = textBox_NumerRejestracji.Text;
            czynnośćSerwisowa.Data_Naprawy = dateTimePicker_DataNaprawy.Value;
            czynnośćSerwisowa.Mechanik = (Mechanik)comboBox_Mechanik.SelectedItem;
            czynnośćSerwisowa.Koszt_Części = numericUpDown_KosztCzęści.Value;
            czynnośćSerwisowa.Czas_Pracy = (int)numericUpDown_CzasPracy.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_Anuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
