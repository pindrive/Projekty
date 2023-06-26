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
using System.IO;

namespace Powtorzeniowe_1
{

    public partial class Deklaracja : Form
    {
        public Deklaracja()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (rb1.Checked || rb2.Checked)
            {
                panel1.BackColor = Color.White;
            }

            if (radioButton1.Checked || radioButton2.Checked)
            {
                panel2.BackColor = Color.White;
            }

            if (cb1.Checked || cb2.Checked)
            {
                panel3.BackColor = Color.White;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font INFfont = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);

            if (comboBox2.Text == "INF.02.")
            {
                Informacja.Font = INFfont;
                Informacja.Text = "Administracja i eksploatacja systemów komputerowych, urządzeń peryferyjnych i lokalnych sieci komputerowych.";
                comboBox2.BackColor = Color.White;
            }

            if (comboBox2.Text == "INF.03.")
            {
                Informacja.Text = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz bazami danych.";
                comboBox2.BackColor = Color.White;
            }

            if (comboBox2.Text == "INF.04.")
            {
                Informacja.Text = "Projektowanie, programowanie i testowanie aplikacji.";
                comboBox2.BackColor = Color.White;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

            textBox2.BackColor = Color.White;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

            textBox11.BackColor = Color.White;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == '/');

            e.KeyChar = Char.ToUpper(e.KeyChar);

            textBox10.BackColor = Color.White;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                cb1.Enabled = false;
                cb2.Enabled = false;
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked == true)
            {
                cb1.Enabled = true;
                cb2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            Regex imie = new Regex(@"([A-Z]{3,})$");
            Regex nazwisko = new Regex(@"([A-Z]{3,})$");
            Regex data_ur = new Regex(@"([0-9]{2})(\-)([0-9]{2})(\-)([0-9]{4})$");
            Regex miejsce_ur = new Regex(@"([A-Z]{3,})$");
            Regex pesel = new Regex(@"([0-9]{11})$");
            Regex miejscowosc = new Regex(@"([A-Z]{3,})$");
            Regex ulica_nr_dom = new Regex(@"([A-Z]{3,})(\s)([0-9]{1,2})(\/){1}([0-9]{1,2})$");
            Regex kod_pocztowy = new Regex(@"([0-9]{2})(\-)([0-9]{3})$");
            Regex poczta = new Regex(@"([A-Z]{3,})$");
            Regex telefon = new Regex(@"(\+)([0-9]{2})(\s)([0-9]{3})(\-)([0-9]{3})(\-)([0-9]{3})$");
            Regex mail = new Regex(@"([A-Za-z0-9]+)*@([a-z0-9]{2,5})(\.){1}([a-z]{2,6})$");

            Regex mail_check_a = new Regex(@"(\@)");

            string maska1 = maskedTextBox1.Text;
            string maska2 = maskedTextBox2.Text;
            string maska3 = maskedTextBox3.Text;
            string maska4 = maskedTextBox4.Text;

            string imię = textBox3.Text;

            string płeć_imię = "";
            Regex imie_k = new Regex(@"([A-Z]{1,})([A]{1})$");
            Regex imie_m = new Regex(@"([A-Z]{1,})([B-Z]{1})$");

            if (imie_k.IsMatch(imię))
            {
                płeć_imię = "Żeńska";
            }

            if (imie_m.IsMatch(imię))
            {
                płeć_imię = "Męska";
            }

            string płeć_pesel = "";
            Regex pesel_k = new Regex(@"([0-9]{9})([02468]{1})([0-9]{1})$");
            Regex pesel_m = new Regex(@"([0-9]{9})([13579]{1})([0-9]{1})$");

            if (pesel_k.IsMatch(maska2))
            {
                płeć_pesel = "Żeńska";
            }

            if (pesel_m.IsMatch(maska2))
            {
                płeć_pesel = "Męska";
            }

            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text == "")
            {
                textBox3.BackColor = Color.Red;
            }

            if (textBox6.Text == "")
            {
                textBox6.BackColor = Color.Red;
            }

            if (textBox7.Text == "")
            {
                textBox7.BackColor = Color.Red;
            }

            if (textBox10.Text == "")
            {
                textBox10.BackColor = Color.Red;
            }

            if (textBox11.Text == "")
            {
                textBox11.BackColor = Color.Red;
            }

            if (textBox12.Text == "")
            {
                textBox12.BackColor = Color.Red;
            }

            if (data_ur.IsMatch(maskedTextBox1.Text))
            {
                // NIC
            }

            else
            {
                maskedTextBox1.BackColor = Color.Red;
            }

            if (maska2 == "")
            {
                maskedTextBox2.BackColor = Color.Red;
            }

            if (kod_pocztowy.IsMatch(maskedTextBox3.Text))
            {
                // NIC
            }

            else
            {
                maskedTextBox3.BackColor = Color.Red;
            }

            if (telefon.IsMatch(maskedTextBox4.Text))
            {
                // NIC
            }

            else
            {
                maskedTextBox4.BackColor = Color.Red;
            }

            if (textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("Wszystkie pola muszą być uzupełnione!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (maska1 == "" || maska2 == "" || maska3 == "" || maska4 == "")
                {
                    MessageBox.Show("Wszystkie pola muszą być uzupełnione!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (nazwisko.IsMatch(textBox2.Text))
                    {
                        if (imie.IsMatch(textBox3.Text))
                        {
                            if (data_ur.IsMatch(maska1))
                            {
                                if (miejsce_ur.IsMatch(textBox6.Text))
                                {
                                    if (pesel.IsMatch(maska2))
                                    {
                                        if (miejscowosc.IsMatch(textBox11.Text))
                                        {
                                            if (ulica_nr_dom.IsMatch(textBox10.Text))
                                            {
                                                if (kod_pocztowy.IsMatch(maska3))
                                                {
                                                    if (poczta.IsMatch(textBox7.Text))
                                                    {
                                                        if (telefon.IsMatch(maska4))
                                                        {
                                                            if (mail.IsMatch(textBox12.Text))
                                                            {
                                                                if (mail_check_a.IsMatch(textBox12.Text))
                                                                {
                                                                    if (comboBox1.Text == "styczeń" || comboBox1.Text == "czerwiec")
                                                                    {
                                                                        if (radioButton1.Checked || radioButton2.Checked)
                                                                        {
                                                                            if (comboBox2.Text == "INF.02." || comboBox2.Text == "INF.03." || comboBox2.Text == "INF.04.")
                                                                            {
                                                                                if (rb1.Checked)
                                                                                {
                                                                                    if ((płeć_imię == "Żeńska" && płeć_pesel == "Żeńska") || (płeć_imię == "Męska" && płeć_pesel == "Męska"))
                                                                                    {
                                                                                        textBox1.Text = "";

                                                                                        textBox1.SelectedText += "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie przeprowadzanego w terminie " + comboBox1.Text;

                                                                                        textBox1.SelectedText += "\r\n\r\nDane osobowe ucznia";
                                                                                        textBox1.SelectedText += "\r\nNazwisko: " + textBox2.Text;
                                                                                        textBox1.SelectedText += "\r\nImię (imiona): " + textBox3.Text;
                                                                                        textBox1.SelectedText += "\r\nData i miejsce urodzenia: " + maskedTextBox1.Text + " " + textBox6.Text;
                                                                                        textBox1.SelectedText += "\r\nPESEL: " + maskedTextBox2.Text;

                                                                                        textBox1.SelectedText += "\r\n\r\nAdres korespondencyjny";
                                                                                        textBox1.SelectedText += "\r\nmiejscowość: " + textBox11.Text;
                                                                                        textBox1.SelectedText += "\r\nulica i numer domu: " + textBox10.Text;
                                                                                        textBox1.SelectedText += "\r\nkod pocztowy i poczta: " + maskedTextBox3.Text + " " + textBox7.Text;
                                                                                        textBox1.SelectedText += "\r\nnr telefonu z kierunkowym: " + maskedTextBox4.Text;
                                                                                        textBox1.SelectedText += "\r\nmail: " + textBox12.Text;

                                                                                        textBox1.SelectedText += "\r\n\r\n\r\nDeklaruję przystąpienie do egzaminu ";

                                                                                        textBox1.SelectedText += rb1.Text + " do części pisemnej i praktycznej";

                                                                                        textBox1.SelectedText += "\r\n\r\nOznaczenie kwalifikacji zgodnie z podstawą programową: " + comboBox2.Text;
                                                                                        textBox1.SelectedText += "\r\nNazwa kwalifikacji: ";

                                                                                        if (comboBox2.Text == "INF.02.")
                                                                                        {
                                                                                            textBox1.SelectedText += "Administracja i eksploatacja systemów komputerowych, urządzeń peryferyjnych i lokalnych sieci komputerowych.";
                                                                                        }

                                                                                        if (comboBox2.Text == "INF.03.")
                                                                                        {
                                                                                            textBox1.SelectedText += "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz bazami danych.";
                                                                                        }

                                                                                        if (comboBox2.Text == "INF.04.")
                                                                                        {
                                                                                            textBox1.SelectedText += "Projektowanie, programowanie i testowanie aplikacji.";
                                                                                        }

                                                                                        textBox1.SelectedText += "\r\n\r\nSymbol cyfrowy zawodu: ";

                                                                                        if (radioButton1.Checked)
                                                                                        {
                                                                                            textBox1.SelectedText += "351203";
                                                                                        }

                                                                                        else if (radioButton2.Checked)
                                                                                        {
                                                                                            textBox1.SelectedText += "351406";
                                                                                        }

                                                                                        textBox1.SelectedText += "\r\nNazwa zawodu: ";

                                                                                        if (radioButton1.Checked)
                                                                                        {
                                                                                            textBox1.SelectedText += radioButton1.Text;
                                                                                        }

                                                                                        else if (radioButton2.Checked)
                                                                                        {
                                                                                            textBox1.SelectedText += radioButton2.Text;
                                                                                        }
                                                                                    }

                                                                                    else
                                                                                    {
                                                                                        MessageBox.Show("Niepoprawne imię lub PESEL!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                    }
                                                                                }

                                                                                else if (rb2.Checked)
                                                                                {
                                                                                    if (cb1.Checked || cb2.Checked)
                                                                                    {
                                                                                        if ((płeć_imię == "Żeńska" && płeć_pesel == "Żeńska") || (płeć_imię == "Męska" && płeć_pesel == "Męska"))
                                                                                        {
                                                                                            textBox1.Text = "";

                                                                                            textBox1.SelectedText += "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie przeprowadzanego w terminie " + comboBox1.Text;

                                                                                            textBox1.SelectedText += "\r\n\r\nDane osobowe ucznia";
                                                                                            textBox1.SelectedText += "\r\nNazwisko: " + textBox2.Text;
                                                                                            textBox1.SelectedText += "\r\nImię (imiona): " + textBox3.Text;
                                                                                            textBox1.SelectedText += "\r\nData i miejsce urodzenia: " + maskedTextBox1.Text + " " + textBox6.Text;
                                                                                            textBox1.SelectedText += "\r\nPESEL: " + maskedTextBox2.Text;

                                                                                            textBox1.SelectedText += "\r\n\r\nAdres korespondencyjny";
                                                                                            textBox1.SelectedText += "\r\nmiejscowość: " + textBox11.Text;
                                                                                            textBox1.SelectedText += "\r\nulica i numer domu: " + textBox10.Text;
                                                                                            textBox1.SelectedText += "\r\nkod pocztowy i poczta: " + maskedTextBox3.Text + " " + textBox7.Text;
                                                                                            textBox1.SelectedText += "\r\nnr telefonu z kierunkowym: " + maskedTextBox4.Text;
                                                                                            textBox1.SelectedText += "\r\nmail: " + textBox12.Text;

                                                                                            textBox1.SelectedText += "\r\n\r\n\r\nDeklaruję przystąpienie do egzaminu ";

                                                                                            textBox1.SelectedText += rb2.Text;

                                                                                            if (cb1.Checked && cb2.Checked)
                                                                                            {
                                                                                                textBox1.SelectedText += " pisemnej i praktycznej";
                                                                                            }

                                                                                            else if (cb1.Checked)
                                                                                            {
                                                                                                textBox1.SelectedText += " " + cb1.Text;
                                                                                            }

                                                                                            else if (cb2.Checked)
                                                                                            {
                                                                                                textBox1.SelectedText += " " + cb2.Text;
                                                                                            }

                                                                                            textBox1.SelectedText += "\r\n\r\nOznaczenie kwalifikacji zgodnie z podstawą programową: " + comboBox2.Text;
                                                                                            textBox1.SelectedText += "\r\nNazwa kwalifikacji: ";

                                                                                            if (comboBox2.Text == "INF.02.")
                                                                                            {
                                                                                                textBox1.SelectedText += "Administracja i eksploatacja systemów komputerowych, urządzeń peryferyjnych i lokalnych sieci komputerowych.";
                                                                                            }

                                                                                            if (comboBox2.Text == "INF.03.")
                                                                                            {
                                                                                                textBox1.SelectedText += "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz bazami danych.";
                                                                                            }

                                                                                            if (comboBox2.Text == "INF.04.")
                                                                                            {
                                                                                                textBox1.SelectedText += "Projektowanie, programowanie i testowanie aplikacji.";
                                                                                            }

                                                                                            textBox1.SelectedText += "\r\n\r\nSymbol cyfrowy zawodu: ";

                                                                                            if (radioButton1.Checked)
                                                                                            {
                                                                                                textBox1.SelectedText += "351203";
                                                                                            }

                                                                                            else if (radioButton2.Checked)
                                                                                            {
                                                                                                textBox1.SelectedText += "351406";
                                                                                            }

                                                                                            textBox1.SelectedText += "\r\nNazwa zawodu: ";

                                                                                            if (radioButton1.Checked)
                                                                                            {
                                                                                                textBox1.SelectedText += radioButton1.Text;
                                                                                            }

                                                                                            else if (radioButton2.Checked)
                                                                                            {
                                                                                                textBox1.SelectedText += radioButton2.Text;
                                                                                            }
                                                                                        }

                                                                                        else
                                                                                        {
                                                                                            MessageBox.Show("Niepoprawne imię lub PESEL!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        MessageBox.Show("Wybierz, do której części egzaminu podchodzisz!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                        panel3.BackColor = Color.Red;
                                                                                    }
                                                                                }

                                                                                else
                                                                                {
                                                                                    MessageBox.Show("Wybierz, który raz podchodzisz do egzaminu!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                    panel2.BackColor = Color.Red;
                                                                                }
                                                                            }

                                                                            else
                                                                            {
                                                                                MessageBox.Show("Wybierz swoją kwalifikacje!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                comboBox2.BackColor = Color.Red;
                                                                            }
                                                                        }

                                                                        else
                                                                        {
                                                                            MessageBox.Show("Wybierz swój zawód!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            panel1.BackColor = Color.Red;
                                                                        }
                                                                    }

                                                                    else
                                                                    {
                                                                        MessageBox.Show("Wybierz miesiąć przystąpienia do egzaminu!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        comboBox1.BackColor = Color.Red;
                                                                    }
                                                                }

                                                                else
                                                                {
                                                                    MessageBox.Show("Brak '@' w składni maila!!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    textBox12.BackColor = Color.Red;
                                                                }
                                                            }

                                                            else
                                                            {
                                                                MessageBox.Show("Niepoprawny mail!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                textBox12.BackColor = Color.Red;
                                                            }
                                                        }

                                                        else
                                                        {
                                                            MessageBox.Show("Niepoprawny nr. telefonu!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            maskedTextBox4.BackColor = Color.Red;
                                                        }
                                                    }

                                                    else
                                                    {
                                                        MessageBox.Show("Niepoprawne wypełnienie polu 'poczta' !", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        textBox7.BackColor = Color.Red;
                                                    }
                                                }

                                                else
                                                {
                                                    MessageBox.Show("Niepoprawny kod pocztowy!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    maskedTextBox3.BackColor = Color.Red;
                                                }
                                            }

                                            else
                                            {
                                                MessageBox.Show("Niepoprawne wypełnienie pola 'ulica i numer domu'!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                textBox10.BackColor = Color.Red;
                                            }
                                        }

                                        else
                                        {
                                            MessageBox.Show("Niepoprawna miejscowość!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            textBox11.BackColor = Color.Red;
                                        }
                                    }

                                    else
                                    {
                                        MessageBox.Show("Niepoprawny pesel!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        maskedTextBox2.BackColor = Color.Red;
                                    }
                                }

                                else
                                {
                                    MessageBox.Show("Niepoprawne miejsce urodzenia!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox6.BackColor = Color.Red;
                                }
                            }

                            else
                            {
                                MessageBox.Show("Niepoprawna data urodzenia!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                maskedTextBox1.BackColor = Color.Red;
                            }
                        }

                        else
                        {
                            MessageBox.Show("Niepoprawne imię!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox3.BackColor = Color.Red;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Niepoprawne nazwisko!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btn_wyczysc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";

            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";

            Informacja.Text = "";

            comboBox1.Text = "";
            comboBox2.Text = "";

            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox10.BackColor = Color.White;
            textBox11.BackColor = Color.White;
            textBox12.BackColor = Color.White;
            maskedTextBox1.BackColor = Color.White;
            maskedTextBox2.BackColor = Color.White;
            maskedTextBox3.BackColor = Color.White;
            maskedTextBox4.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox12.BackColor = Color.White;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

            textBox3.BackColor = Color.White;

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

            textBox6.BackColor = Color.White;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

            textBox7.BackColor = Color.White;
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            maskedTextBox2.BackColor = Color.White;
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            maskedTextBox1.BackColor = Color.White;
        }

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            maskedTextBox3.BackColor = Color.White;
        }

        private void maskedTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            maskedTextBox4.BackColor = Color.White;
        }

        private void btn_zapisz_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("C:\\Users\\Ryzen\\Desktop\\Własne\\C#\\Deklaracja\\dane.txt");
            txt.Write(textBox1.Text);
            txt.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "styczeń" || comboBox1.Text == "czerwiec")
            {
                comboBox1.BackColor = Color.White;
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            Informacja.Text = "";
            comboBox2.Items.Clear();
            comboBox2.Items.Add("INF.02.");
            comboBox2.Items.Add("INF.03.");

            panel1.BackColor = Color.White;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            Informacja.Text = "";
            comboBox2.Items.Clear();
            comboBox2.Items.Add("INF.03.");
            comboBox2.Items.Add("INF.04.");

            panel1.BackColor = Color.White;
        }

        private void rb1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
        }

        private void rb2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
        }

        private void cb1_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
        }

        private void cb2_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
        }
    }
}
