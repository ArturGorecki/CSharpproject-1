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
    public partial class Form_Rozliczenia : Form
    {
        public Form_Rozliczenia()
        {
            InitializeComponent();
        }

        private void Form_Rozliczenia_Load(object sender, EventArgs e)
        {
            foreach (Mechanik m in Mechanik.mechanikowie)
                comboBox_Mechanik.Items.Add(m);
        }

        private void button_PokażSumę_Click(object sender, EventArgs e)
        {

            label_SumaNależności.Text = "Łącznie: " + suma_napraw() + "zł";
            pokaż_naprawy();
        }

        void pokaż_naprawy()
        {
            dataGridView1.Rows.Clear();
            foreach (CzynnośćSerwisowa cz in CzynnośćSerwisowa.Naprawy)
            {
                if ((Mechanik)comboBox_Mechanik.SelectedItem == cz.Mechanik)
                {
                    dataGridView1.Rows.Add(cz.Numer_Rejestracyjny, cz.Data_Naprawy.ToShortDateString(), cz.Mechanik, cz.Koszt_Części, cz.Czas_Pracy, cz.Koszt);
                }
            }

        }

        decimal suma_napraw()
        {
            decimal suma = 0;
            foreach (CzynnośćSerwisowa cz in CzynnośćSerwisowa.Naprawy)
            {
                if ((Mechanik)comboBox_Mechanik.SelectedItem == cz.Mechanik)
                {
                    suma = suma + cz.Koszt;
                }
            }
            return suma;
        }

    }
}
