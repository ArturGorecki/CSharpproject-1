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
    public partial class Form_WszystkieNaprawy : Form
    {
        public Form_WszystkieNaprawy()
        {
            InitializeComponent();

            Mechanik m = new Mechanik();
            m.Imię = "Mieszko";
            m.Nazwisko = "Sobczak";
            m.Rok_Zatrudnienia = 2021;
            m.Stawka = 50;
            Mechanik.mechanikowie.Add(m);

            m = new Mechanik();
            m.Imię = "Norbert";
            m.Nazwisko = "Sikora";
            m.Rok_Zatrudnienia = 2020;
            m.Stawka = 50;
            Mechanik.mechanikowie.Add(m);

            m = new Mechanik();
            m.Imię = "Aleksander";
            m.Nazwisko = "Kucharski";
            m.Rok_Zatrudnienia = 2018;
            m.Stawka = 65;
            Mechanik.mechanikowie.Add(m);

            m = new Mechanik();
            m.Imię = "Olgierd";
            m.Nazwisko = "Ostrowski";
            m.Rok_Zatrudnienia = 2015;
            m.Stawka = 80;
            Mechanik.mechanikowie.Add(m);


        }


        private void button_DodajNaprawę_Click(object sender, EventArgs e)
        {
            CzynnośćSerwisowa nowa_naprawa = new CzynnośćSerwisowa();
            Form_DodajNaprawę form = new Form_DodajNaprawę(nowa_naprawa);
            form.ShowDialog();

            CzynnośćSerwisowa.Naprawy.Add(nowa_naprawa);

            wyświetl_naprawy();
        }

        private void button_Rozliczenia_Click(object sender, EventArgs e)
        {
            Form_Rozliczenia form = new Form_Rozliczenia();
            form.ShowDialog();
        }

        void wyświetl_naprawy()
        {
            dataGridView1.Rows.Clear();
            foreach (CzynnośćSerwisowa cz in CzynnośćSerwisowa.Naprawy)
            {
                dataGridView1.Rows.Add(cz.Numer_Rejestracyjny, cz.Data_Naprawy.ToShortDateString(), cz.Mechanik, cz.Koszt_Części, cz.Czas_Pracy);
            }    
        }

        private void button_IleSamochodówZŁodzi_Click(object sender, EventArgs e)
        {
            int counter = 0;

            foreach(CzynnośćSerwisowa cz in CzynnośćSerwisowa.Naprawy)
            {
                if (cz.Numer_Rejestracyjny.Contains("EL "))
                {
                    counter++;
                }

            }

            label_wynik.Text = "Procent naprawionych samochodów z Łodzi to " + (100*counter / CzynnośćSerwisowa.Naprawy.Count) + "%";

        }
    }
}
