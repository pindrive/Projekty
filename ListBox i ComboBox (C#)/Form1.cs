using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_i_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string imie = ImieBox.Text;
            string nazwisko = NazwiskoBox.Text;
            string pesel = PeselBox.Text;

            Regex reimie = new Regex(@"^([A-Z]{1})([a-z]{1,})$");
            Regex renazwisko = new Regex(@"^([A-ZŻ]{1})([a-z]{1,})$");
            Regex repesel = new Regex(@"^([0-9]{11})$");

            if (ImieBox.Text == "" || NazwiskoBox.Text == "" || PeselBox.Text == "")
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (reimie.IsMatch(imie))
                {
                    if (renazwisko.IsMatch(nazwisko))
                    {
                        if (repesel.IsMatch(pesel))
                        {

                            // MĘŻCZYZNA.CHECKED

                            if (rb2.Checked)
                            {
                                Regex regular1 = new Regex(@"^([A-Z]{1})([a-z]{1,12})([a]{1})$");
                                Regex regular2 = new Regex(@"^([0-9]{11})$");

                                if (regular1.IsMatch(ImieBox.Text))
                                {
                                    MessageBox.Show("Niepoprawne imię dla mężczyzny!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string PSL = PeselBox.Text;
                                    char A = PSL[9];
                                    int B = Convert.ToInt32(A);

                                    string polski, matematyka, dodatkowe, języki;

                                    if (regular2.IsMatch(pesel))
                                    {
                                        if (B % 2 == 0)
                                        {
                                            MessageBox.Show("Niepoprawny PESEL!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                        else
                                        {
                                            if (cb1.Checked)
                                            {
                                                matematyka = "\rMatematyka";
                                            }
                                            else
                                            {
                                                matematyka = "";
                                            }

                                            if (cb2.Checked)
                                            {
                                                polski = "\rPolski";
                                            }
                                            else
                                            {
                                                polski = "";
                                            }

                                            if (cb3.Checked)
                                            {
                                                języki = "\r" + comboBox1.Text;
                                            }
                                            else
                                            {
                                                języki = "";
                                            }

                                            if (cb4.Checked)
                                            {
                                                dodatkowe = "\r" + listBox1.Text;
                                            }
                                            else
                                            {
                                                dodatkowe = "";
                                            }

                                            MessageBox.Show("\rImię: " + ImieBox.Text + "\rNazwisko: " + NazwiskoBox.Text + "\rPesel: " + PSL + "\rWybrane przedmioty: " + matematyka + polski + języki + dodatkowe, "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                    
                                    }
                                    else
                                    {
                                        MessageBox.Show("Niepoprawny PESEL!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                            // KOBIETA.CHECKED

                            if (rb1.Checked)
                            {
                                Regex regular1 = new Regex(@"^([A-Z]{1})([a-z]{1,12})([a]{1})$");
                                Regex regular2 = new Regex(@"^([0-9]{11})$");

                                if (!regular1.IsMatch(ImieBox.Text))
                                {
                                    MessageBox.Show("Niepoprawne imię dla kobiety!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string PSL = PeselBox.Text;
                                    char A = PSL[9];
                                    int B = Convert.ToInt32(A);

                                    string polski, matematyka, dodatkowe, języki;

                                    if (regular2.IsMatch(pesel))
                                    {
                                        if (B % 2 != 0)
                                        {
                                            MessageBox.Show("Niepoprawny PESEL!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                        else
                                        {
                                            if (cb1.Checked)
                                            {
                                                matematyka = "\rMatematyka";
                                            }
                                            else
                                            {
                                                matematyka = "";
                                            }

                                            if (cb2.Checked)
                                            {
                                                polski = "\rPolski";
                                            }
                                            else
                                            {
                                                polski = "";
                                            }

                                            if (cb3.Checked)
                                            {
                                                języki = "\r" + comboBox1.Text;
                                            }
                                            else
                                            {
                                                języki = "";
                                            }

                                            if (cb4.Checked)
                                            {
                                                dodatkowe = "\r" + listBox1.Text;
                                            }
                                            else
                                            {
                                                dodatkowe = "";
                                            }

                                            MessageBox.Show("\rImię: " + ImieBox.Text + "\rNazwisko: " + NazwiskoBox.Text + "\rPesel: " + PSL + "\rWybrane przedmioty: " + matematyka + polski + języki + dodatkowe, "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Niepoprawny PESEL!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Niepoprawny PESEL!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Niepoprawne nazwisko!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Niepoprawne imię!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
