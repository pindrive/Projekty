using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularzWłasne
{
    public partial class Formularz : Form
    {
        public Formularz()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sprawdź swoje IQ już teraz!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Jeżeli są jakieś problemy napisz do naszego supportu na adres: formularzsupport@gmail.com!", "Pomoc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SPRAWDŹ_Click(object sender, EventArgs e)
        {

            // INT 

            int iq = 20;

            // INT WIEK 

            int mniej18 = 8;
            int rowno18 = 10;
            int wiecej18 = 12;

            // INT ZADANIE 1

            int odp11 = 0;
            int odp12 = 2;
            int odp13 = 0; 

            // INT ZADANIE 2

            int odp21 = 5;
            int odp22 = 0;
            int odp23 = 0;

            // INT ZADANIE 3

            int odp31 = 8;
            int odp32 = 0;
            int odp33 = 0;

            // INT ZADANIE 4

            int odp41 = 10;
            int odp42 = 0;
            int odp43 = 0;

            // INT ZADANIE 5

            int odp51 = 0;
            int odp52 = 30;
            int odp53 = 0;

            // INT ZADANIE 6

            int odp61 = 50;
            int odp62 = 0;
            int odp63 = 0;

            // SUMA IQ ODP

            

            // WIEK

            if (rb01.Checked)
            {
                iq += mniej18;
            }

            if (rb02.Checked)
            {
                iq += rowno18;
            }

            if (rb03.Checked)
            {
                iq += wiecej18;
            }

            // ZADANIE 1

            if (rb11.Checked)
            {
                iq += odp11;
            }

            if (rb12.Checked)
            {
                iq += odp12;
            }

            if (rb13.Checked)
            {
                iq += odp13;
            }

            // ZADANIE 2

            if (rb21.Checked)
            {
                iq += odp21;
            }

            if (rb22.Checked)
            {
                iq += odp22;
            }

            if (rb23.Checked)
            {
                iq += odp23;
            }

            // ZADANIE 3

            if (rb31.Checked)
            {
                iq += odp31;
            }

            if (rb32.Checked)
            {
                iq += odp32;
            }

            if (rb33.Checked)
            {
                iq += odp33;
            }

            // ZADANIE 4

            if (rb41.Checked)
            {
                iq += odp41;        
            }

            if (rb42.Checked)
            {
                iq += odp42;
            }

            if (rb43.Checked)
            {
                iq += odp43;
            }

            // ZADANIE 5

            if (rb51.Checked)
            {
                iq += odp51;
            }

            if (rb52.Checked)
            {
                iq += odp52;
            }

            if (rb53.Checked)
            {
                iq += odp53;
            }

            // ZADANIE 6

            if (rb61.Checked)
            {
                iq += odp61;
            }

            if (rb62.Checked)
            {
                iq += odp62;
            }

            if (rb63.Checked)
            {
                iq += odp63;
            }

            if (iq == 0)
            {
                Wynik_IQ.Text = "Twoje matematyczne IQ wynosi około: " + iq + " XDDDDD";
            }

            else
            {
                Wynik_IQ.Text = "Twoje matematyczne IQ wynosi około: " + iq;
            }

            // NIEPOPRAWNE ODPOWIEDZI
            
            // ZADANIE 1

            if (rb11.Checked)
            {
                rb11.ForeColor = Color.Black;
                rb12.ForeColor = Color.Black;
                rb13.ForeColor = Color.Black;

                rb11.ForeColor = Color.Red;
                rb12.ForeColor = Color.Green;
            }

            if (rb13.Checked)
            {
                rb11.ForeColor = Color.Black;
                rb12.ForeColor = Color.Black;
                rb13.ForeColor = Color.Black;

                rb13.ForeColor = Color.Red;
                rb12.ForeColor = Color.Green;
            }

            // ZADANIE 2

            if (rb22.Checked)
            {
                rb21.ForeColor = Color.Black;
                rb22.ForeColor = Color.Black;
                rb23.ForeColor = Color.Black;

                rb22.ForeColor = Color.Red;
                rb21.ForeColor = Color.Green;
            }

            if (rb23.Checked)
            {
                rb21.ForeColor = Color.Black;
                rb22.ForeColor = Color.Black;
                rb23.ForeColor = Color.Black;

                rb23.ForeColor = Color.Red;
                rb21.ForeColor = Color.Green;
            }

            // ZADANIE 3

            if (rb32.Checked)
            {
                rb31.ForeColor = Color.Black;
                rb32.ForeColor = Color.Black;
                rb33.ForeColor = Color.Black;

                rb32.ForeColor = Color.Red;
                rb31.ForeColor = Color.Green;
            }

            if (rb33.Checked)
            {
                rb31.ForeColor = Color.Black;
                rb32.ForeColor = Color.Black;
                rb33.ForeColor = Color.Black;

                rb33.ForeColor = Color.Red;
                rb31.ForeColor = Color.Green;
            }

            // ZADANIE 4

            if (rb42.Checked)
            {
                rb41.ForeColor = Color.Black;
                rb42.ForeColor = Color.Black;
                rb43.ForeColor = Color.Black;

                rb42.ForeColor = Color.Red;
                rb41.ForeColor = Color.Green;
            }  

            if (rb43.Checked)
            {
                rb41.ForeColor = Color.Black;
                rb42.ForeColor = Color.Black;
                rb43.ForeColor = Color.Black;

                rb43.ForeColor = Color.Red;
                rb41.ForeColor = Color.Green;
            }

            // ZADANIE 5

            if (rb51.Checked)
            {
                rb51.ForeColor = Color.Black;
                rb52.ForeColor = Color.Black;
                rb53.ForeColor = Color.Black;

                rb51.ForeColor = Color.Red;
                rb52.ForeColor = Color.Green;
            }

            if (rb53.Checked)
            {
                rb51.ForeColor = Color.Black;
                rb52.ForeColor = Color.Black;
                rb53.ForeColor = Color.Black;

                rb53.ForeColor = Color.Red;
                rb52.ForeColor = Color.Green;
            }

            // ZADANIE 6

            if (rb62.Checked)
            {
                rb61.ForeColor = Color.Black;
                rb62.ForeColor = Color.Black;
                rb63.ForeColor = Color.Black;

                rb62.ForeColor = Color.Red;
                rb61.ForeColor = Color.Green;
            }

            if (rb63.Checked)
            {
                rb61.ForeColor = Color.Black;
                rb62.ForeColor = Color.Black;
                rb63.ForeColor = Color.Black;

                rb63.ForeColor = Color.Red;
                rb61.ForeColor = Color.Green;
            }

            // POPRAWNE ODPOWIEDZI

            // ZADANIE 1

            if (rb12.Checked)

            {

                rb11.ForeColor = Color.Black;
                rb12.ForeColor = Color.Black;
                rb13.ForeColor = Color.Black;

                rb12.ForeColor = Color.Green;

            }

            // ZADANIE 2


            if (rb21.Checked)

            {

                rb21.ForeColor = Color.Black;
                rb22.ForeColor = Color.Black;
                rb23.ForeColor = Color.Black;

                rb21.ForeColor = Color.Green;

            }

            // ZADANIE 3

            if (rb31.Checked)

            {

                rb31.ForeColor = Color.Black;
                rb32.ForeColor = Color.Black;
                rb33.ForeColor = Color.Black;

                rb31.ForeColor = Color.Green;

            }

            // ZADANIE 4

            if (rb41.Checked)

            {

                rb41.ForeColor = Color.Black;
                rb42.ForeColor = Color.Black;
                rb43.ForeColor = Color.Black;

                rb41.ForeColor = Color.Green;

            }

            // ZADANIE 5

            if (rb52.Checked)

            {

                rb51.ForeColor = Color.Black;
                rb52.ForeColor = Color.Black;
                rb53.ForeColor = Color.Black;

                rb52.ForeColor = Color.Green;

            }

            // ZADANIE 6

            if (rb61.Checked)

            {

                rb61.ForeColor = Color.Black;
                rb62.ForeColor = Color.Black;
                rb63.ForeColor = Color.Black;

                rb61.ForeColor = Color.Green;

            }
        }
    }
}
