using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        float result = 0;
        int num = 0;
        int math_char = 0;

        string[] tab;
        string[] tab_AC;
        string tB_result = "";

        Regex ujemna_cyfra = new Regex(@"([\-]{1})([0-9]{1,})$");
        Regex ujemna_cyfra_i_minus = new Regex(@"([\-]{1})([0-9]{1,})([\s]{1})([\-]{1})([\s]{1})([0-9]{1,})$");

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("Błąd!") == true)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 1;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 1;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 1;
                    textBox_result.Text += num;
                }
            }
         
            else if (textBox_result.Text.Contains("Błąd!") == false)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 1;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 1;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 1;
                    textBox_result.Text += num;
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("Błąd!") == true)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 2;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 2;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 2;
                    textBox_result.Text += num;
                }
            }

            else if (textBox_result.Text.Contains("Błąd!") == false)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 2;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 2;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 2;
                    textBox_result.Text += num;
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("Błąd!") == true)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 3;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 3;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 3;
                    textBox_result.Text += num;
                }
            }

            else if (textBox_result.Text.Contains("Błąd!") == false)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 3;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 3;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 3;
                    textBox_result.Text += num;
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("Błąd!") == true)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 4;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 4;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 4;
                    textBox_result.Text += num;
                }
            }

            else if (textBox_result.Text.Contains("Błąd!") == false)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 4;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 4;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 4;
                    textBox_result.Text += num;
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("Błąd!") == true)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 5;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 5;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 5;
                    textBox_result.Text += num;
                }
            }

            else if (textBox_result.Text.Contains("Błąd!") == false)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 5;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 5;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 5;
                    textBox_result.Text += num;
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("Błąd!") == true)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 6;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 6;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 6;
                    textBox_result.Text += num;
                }
            }

            else if (textBox_result.Text.Contains("Błąd!") == false)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 6;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 6;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 6;
                    textBox_result.Text += num;
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("Błąd!") == true)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 7;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 7;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 7;
                    textBox_result.Text += num;
                }
            }

            else if (textBox_result.Text.Contains("Błąd!") == false)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 7;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 7;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 7;
                    textBox_result.Text += num;
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("Błąd!") == true)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 8;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 8;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 8;
                    textBox_result.Text += num;
                }
            }

            else if (textBox_result.Text.Contains("Błąd!") == false)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 8;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 8;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 8;
                    textBox_result.Text += num;
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("Błąd!") == true)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 9;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 9;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 9;
                    textBox_result.Text += num;
                }
            }

            else if (textBox_result.Text.Contains("Błąd!") == false)
            {
                if (textBox_result.Text.StartsWith("0") == true)
                {
                    if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                    {
                        num = 9;
                        textBox_result.Text += num;
                    }

                    else if (textBox_result.Text.Contains("+") == false && textBox_result.Text.Contains("-") == false && textBox_result.Text.Contains("*") == false && textBox_result.Text.Contains("/") == false)
                    {
                        textBox_result.Text = "";

                        num = 9;
                        textBox_result.Text += num;
                    }
                }

                else if (textBox_result.Text.StartsWith("0") == false)
                {
                    num = 9;
                    textBox_result.Text += num;
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.EndsWith("/ ") == false)
            {
                if (textBox_result.Text.Contains("Błąd!") == true)
                {
                    textBox_result.Text = "";

                    num = 0;
                    textBox_result.Text += num;
                }

                else if (textBox_result.Text.Contains("Błąd!") == false)
                {
                    num = 0;
                    textBox_result.Text += num;
                }
            }

            else if (textBox_result.Text.EndsWith("/ ") == true)
            {

            }
            
        }


        private void btn_AC_Click(object sender, EventArgs e)
        {
            num = 0;
            result = 0;
            math_char = 0;
            textBox_result.Text = "";
        }

        private void btn_float_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text != "")
            {
                if (textBox_result.Text.Contains(",") == true)
                {
                    if (textBox_result.Text.EndsWith(",") == true || textBox_result.Text.EndsWith("+ ") == true || textBox_result.Text.EndsWith("- ") == true || textBox_result.Text.EndsWith("* ") == true || textBox_result.Text.EndsWith("/ ") == true)
                    {

                    }

                    else if (textBox_result.Text.EndsWith(",") == false && textBox_result.Text.EndsWith("+ ") == false && textBox_result.Text.EndsWith("- ") == false && textBox_result.Text.EndsWith("* ") == false && textBox_result.Text.EndsWith("/ ") == false)
                    {
                        textBox_result.Text += ",";
                    }
                }

                else if (textBox_result.Text.Contains(",") == false && textBox_result.Text.EndsWith("+ ") == false && textBox_result.Text.EndsWith("- ") == false && textBox_result.Text.EndsWith("* ") == false && textBox_result.Text.EndsWith("/ ") == false) // DONE
                {
                    textBox_result.Text += ",";
                }
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text != "" && textBox_result.Text.Contains("Błąd!") == false)
            {
                if (textBox_result.Text.EndsWith(",") == false && textBox_result.Text.EndsWith("+ ") == false && textBox_result.Text.EndsWith("- ") == false && textBox_result.Text.EndsWith("* ") == false && textBox_result.Text.EndsWith("/ ") == false)
                {
                    if (textBox_result.Text.StartsWith("-") == false)
                    {
                        if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                        {
                            if (textBox_result.Text.Contains("+") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('+');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a + b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " + ";
                            }

                            else if (textBox_result.Text.Contains("-") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('-');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a - b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " + ";
                            }

                            else if (textBox_result.Text.Contains("*") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('*');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a * b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " + ";
                            }

                            else if (textBox_result.Text.Contains("/") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('/');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a / b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " + ";
                            }
                        }

                        else if (textBox_result.Text.Contains("+") == false || textBox_result.Text.Contains("-") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.EndsWith(",") == false)
                        {
                            textBox_result.Text += " + ";
                        }
                    }

                    else if (textBox_result.Text.StartsWith("-") == true)
                    {
                        if (textBox_result.Text.Contains("+") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('+');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a + b;
                            textBox_result.Text = "";
                            textBox_result.Text += result + " + ";
                        }

                        else if (textBox_result.Text.StartsWith("-") == true && textBox_result.Text.Contains("+") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('+');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a + b;
                            textBox_result.Text = "";
                            textBox_result.Text += result + " + ";
                        }

                        else if (textBox_result.Text.StartsWith("-") == false && textBox_result.Text.Contains("-") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('-');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a - b;
                            textBox_result.Text = "";
                            textBox_result.Text += result + " + ";
                        }

                        else if (ujemna_cyfra.IsMatch(textBox_result.Text))
                        {
                            textBox_result.Text += " + ";
                        }

                        else if (textBox_result.Text.Contains("*") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('*');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a * b;
                            textBox_result.Text = "";
                            textBox_result.Text += result + " + ";
                        }

                        else if (textBox_result.Text.Contains("/") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('/');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a / b;
                            textBox_result.Text = "";
                            textBox_result.Text += result + " + ";
                        }
                    }

                    else if (textBox_result.Text.Contains("+") == false || textBox_result.Text.Contains("-") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.Contains("/") == false || textBox_result.Text.EndsWith(",") == false)
                    {
                        textBox_result.Text += " + ";
                    }
                }
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text != "" && textBox_result.Text.Contains("Błąd!") == false)
            {
                if (textBox_result.Text.EndsWith(",") == false && textBox_result.Text.EndsWith("+ ") == false && textBox_result.Text.EndsWith("- ") == false && textBox_result.Text.EndsWith("* ") == false && textBox_result.Text.EndsWith("/ ") == false)
                {
                    if (textBox_result.Text.StartsWith("-") == false)
                    {
                        if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                        {
                            if (textBox_result.Text.Contains("+") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('+');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a + b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " - ";
                            }

                            else if (textBox_result.Text.Contains("-") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('-');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a - b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " - ";
                            }

                            else if (textBox_result.Text.Contains("*") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('*');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a * b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " - ";
                            }

                            else if (textBox_result.Text.Contains("/") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('/');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a / b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " - ";
                            }
                        }

                        else if (textBox_result.Text.Contains("+") == false || textBox_result.Text.Contains("-") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.EndsWith(",") == false)
                        {
                            textBox_result.Text += " - ";
                        }
                    }

                    else if (textBox_result.Text.StartsWith("-") == true)
                    {
                        if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                        {
                            if (textBox_result.Text.Contains("+") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('+');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a + b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " - ";
                            }

                            else if (textBox_result.Text.StartsWith("-") == false && textBox_result.Text.Contains("-") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('-');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a - b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " - ";
                            }

                            else if (ujemna_cyfra_i_minus.IsMatch(textBox_result.Text))
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split(' ');

                                string a_str = tab[0];
                                string b_str = tab[2];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a - b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " - ";
                            }

                            else if (ujemna_cyfra.IsMatch(textBox_result.Text))
                            {
                                textBox_result.Text += " - ";
                            }

                            else if (textBox_result.Text.Contains("*") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('*');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a * b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " - ";
                            }

                            else if (textBox_result.Text.Contains("/") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('/');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a / b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " - ";
                            }
                        }

                        else if (textBox_result.Text.Contains("+") == false || textBox_result.Text.Contains("-") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.EndsWith(",") == false)
                        {
                            textBox_result.Text += " - ";
                        }
                    }
                }
            }
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text != "" && textBox_result.Text.Contains("Błąd!") == false && textBox_result.Text.Contains("log") == false)
            {
                if (textBox_result.Text.EndsWith(",") == false && textBox_result.Text.EndsWith("+ ") == false && textBox_result.Text.EndsWith("- ") == false && textBox_result.Text.EndsWith("* ") == false && textBox_result.Text.EndsWith("/ ") == false)
                {
                    if (textBox_result.Text.StartsWith("-") == false)
                    {
                        if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                        {
                            if (textBox_result.Text.Contains("+") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('+');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a + b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " * ";
                            }

                            else if (textBox_result.Text.Contains("-") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('-');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a - b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " * ";
                            }

                            else if (textBox_result.Text.Contains("*") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('*');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a * b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " * ";
                            }

                            else if (textBox_result.Text.Contains("/") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('/');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a / b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " * ";
                            }
                        }

                        else if (textBox_result.Text.Contains("+") == false || textBox_result.Text.Contains("-") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.EndsWith(",") == false)
                        {
                            textBox_result.Text += " * ";
                        }
                    }

                    else if (textBox_result.Text.StartsWith("-") == true)
                    {
                        if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                        {
                            if (textBox_result.Text.Contains("+") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('+');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a + b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " * ";
                            }

                            else if (textBox_result.Text.StartsWith("-") == true && textBox_result.Text.Contains("*") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('*');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a * b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " + ";
                            }

                            else if (textBox_result.Text.StartsWith("-") == false && textBox_result.Text.Contains("-") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('-');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a - b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " * ";
                            }

                            else if (ujemna_cyfra.IsMatch(textBox_result.Text))
                            {
                                textBox_result.Text += " * ";
                            }

                            else if (textBox_result.Text.Contains("*") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('*');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a * b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " * ";
                            }

                            else if (textBox_result.Text.Contains("/") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('/');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a / b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " * ";
                            }
                        }

                        else if (textBox_result.Text.Contains("+") == false || textBox_result.Text.Contains("-") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.EndsWith(",") == false)
                        {
                            textBox_result.Text += " * ";
                        }
                    }
                }
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text != "" && textBox_result.Text.Contains("Błąd!") == false && textBox_result.Text.Contains("log") == false)
            {
                if (textBox_result.Text.EndsWith(",") == false && textBox_result.Text.EndsWith("+ ") == false && textBox_result.Text.EndsWith("- ") == false && textBox_result.Text.EndsWith("* ") == false && textBox_result.Text.EndsWith("/ ") == false)
                {
                    if (textBox_result.Text.StartsWith("-") == false)
                    {
                        if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                        {
                            if (textBox_result.Text.Contains("+") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('+');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a + b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " / ";
                            }

                            else if (textBox_result.Text.Contains("-") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('-');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a - b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " / ";
                            }

                            else if (textBox_result.Text.Contains("*") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('*');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a * b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " / ";
                            }

                            else if (textBox_result.Text.Contains("/") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('/');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a / b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " / ";
                            }
                        }

                        else if (textBox_result.Text.Contains("+") == false || textBox_result.Text.Contains("-") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.EndsWith(",") == false)
                        {
                            textBox_result.Text += " / ";
                        }
                    }

                    else if (textBox_result.Text.StartsWith("-") == true)
                    {
                        if (textBox_result.Text.Contains("+") == true || textBox_result.Text.Contains("-") == true || textBox_result.Text.Contains("*") == true || textBox_result.Text.Contains("/") == true)
                        {
                            if (textBox_result.Text.Contains("+") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('+');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a + b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " / ";
                            }

                            else if (textBox_result.Text.StartsWith("-") == true && textBox_result.Text.Contains("/") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('/');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a / b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " / ";
                            }

                            else if (textBox_result.Text.StartsWith("-") == false && textBox_result.Text.Contains("-") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('-');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a - b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " / ";
                            }

                            else if (ujemna_cyfra.IsMatch(textBox_result.Text))
                            {
                                textBox_result.Text += " / ";
                            }

                            else if (textBox_result.Text.Contains("*") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('*');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a * b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " / ";
                            }

                            else if (textBox_result.Text.Contains("/") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('/');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                float a = float.Parse(a_str);
                                float b = float.Parse(b_str);

                                result = a / b;
                                textBox_result.Text = "";
                                textBox_result.Text += result + " / ";
                            }
                        }

                        else if (textBox_result.Text.Contains("+") == false || textBox_result.Text.Contains("-") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.Contains("*") == false || textBox_result.Text.EndsWith(",") == false)
                        {
                            textBox_result.Text += " / ";
                        }
                    }
                }
            }
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            Regex percent_dodania = new Regex(@"([0-9]{1,})$");
            Regex percent_ujemna = new Regex(@"([\-]{1})([0-9]{1,})$");

            Regex percent_dodania_znak = new Regex(@"([0-9]{1,})([\s]{1})([\-\+\*\/]{1})([\s]{1})$");
            Regex percent_ujemna_znak = new Regex(@"([\-]{1})([0-9]{1,})([\s]{1})([\-\+\*\/]{1})([\s]{1})$");

            Regex percent_dzialanie_dodatnia = new Regex(@"([0-9]{1,})([\s]{1})([\-\+\*\/]{1})([\s]{1})([0-9]{1,})$");
            Regex percent_dzialanie_ujemna = new Regex(@"([\-]{1})([0-9]{1,})([\s]{1})([\-\+\*\/]{1})([\s]{1})([0-9]{1,})$");

            if (textBox_result.Text == "" || textBox_result.Text == "Błąd!" || textBox_result.Text.Contains("Błąd!") == true)
            {

            }

            else if (textBox_result.Text != "" && textBox_result.Text.Contains("Błąd!") == false && textBox_result.Text.Contains("log") == false)
            {
                if (percent_dodania.IsMatch(textBox_result.Text) || percent_ujemna.IsMatch(textBox_result.Text))
                {
                    if (percent_dzialanie_dodatnia.IsMatch(textBox_result.Text) || percent_dzialanie_ujemna.IsMatch(textBox_result.Text))
                    {

                        if (textBox_result.Text.StartsWith("-") == true)
                        {
                            if (textBox_result.Text.Contains("+") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('+');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                double a = Convert.ToDouble(a_str);
                                double b = Convert.ToDouble(b_str);

                                double result_float = (a + b) / 100;
                                textBox_result.Text = "";
                                textBox_result.Text += result_float;
                            }

                            else if (textBox_result.Text.Contains("*") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('*');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                double a = Convert.ToDouble(a_str);
                                double b = Convert.ToDouble(b_str);

                                double result_float = (a * b) / 100;
                                textBox_result.Text = "";
                                textBox_result.Text += result_float;
                            }

                            else if (textBox_result.Text.StartsWith("-") == false && textBox_result.Text.Contains("-") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('-');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                double a = Convert.ToDouble(a_str);
                                double b = Convert.ToDouble(b_str);

                                double result_float = (a - b) / 100;
                                textBox_result.Text = "";
                                textBox_result.Text += result_float;
                            }

                            else if (ujemna_cyfra_i_minus.IsMatch(textBox_result.Text))
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split(' ');

                                string a_str = tab[0];
                                string b_str = tab[2];

                                double a = Convert.ToDouble(a_str);
                                double b = Convert.ToDouble(b_str);

                                double result_float = (a - b) / 100;
                                textBox_result.Text = "";
                                textBox_result.Text += result_float;
                            }

                            else if (textBox_result.Text.Contains("/") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('/');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                double a = Convert.ToDouble(a_str);
                                double b = Convert.ToDouble(b_str);

                                double result_float = (a / b) / 100;
                                textBox_result.Text = "";
                                textBox_result.Text += result_float;
                            }
                        }

                        else if (textBox_result.Text.StartsWith("-") == false)
                        {
                            if (textBox_result.Text.Contains("+") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('+');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                double a = Convert.ToDouble(a_str);
                                double b = Convert.ToDouble(b_str);

                                double result_float = (a + b) / 100;
                                textBox_result.Text = "";
                                textBox_result.Text += result_float;
                            }

                            else if (textBox_result.Text.Contains("-") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('-');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                double a = Convert.ToDouble(a_str);
                                double b = Convert.ToDouble(b_str);

                                double result_float = (a - b) / 100;
                                textBox_result.Text = "";
                                textBox_result.Text += result_float;
                            }

                            else if (textBox_result.Text.Contains("*") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('*');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                double a = Convert.ToDouble(a_str);
                                double b = Convert.ToDouble(b_str);

                                double result_float = (a * b) / 100;
                                textBox_result.Text = "";
                                textBox_result.Text += result_float;
                            }

                            else if (textBox_result.Text.Contains("/") == true)
                            {
                                tB_result = textBox_result.Text;
                                tab = tB_result.Split('/');

                                string a_str = tab[0];
                                string b_str = tab[1];

                                double a = Convert.ToDouble(a_str);
                                double b = Convert.ToDouble(b_str);

                                double result_float = (a / b) / 100;
                                textBox_result.Text = "";
                                textBox_result.Text += result_float;
                            }
                        }
                    }

                    else
                    {
                        tB_result = textBox_result.Text;
                        double n = Convert.ToDouble(tB_result);

                        double result_float = n / 100;
                        textBox_result.Text = "";
                        textBox_result.Text += result_float;
                    }
                }

                else if (percent_dodania_znak.IsMatch(textBox_result.Text) || percent_ujemna_znak.IsMatch(textBox_result.Text))
                {

                }
            }
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("Błąd!") == false && textBox_result.Text.Contains("log") == false)
            {
                if (textBox_result.Text.EndsWith(",") == false && textBox_result.Text.EndsWith("+ ") == false && textBox_result.Text.EndsWith("- ") == false && textBox_result.Text.EndsWith("* ") == false && textBox_result.Text.EndsWith("/ ") == false)
                {
                    if (textBox_result.Text.StartsWith("-") == false)
                    {
                        if (textBox_result.Text.Contains("+") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('+');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a + b;
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }

                        else if (textBox_result.Text.Contains("-") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('-');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a - b;
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }

                        else if (textBox_result.Text.Contains("*") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('*');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str); ;

                            result = a * b;
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }

                        else if (textBox_result.Text.Contains("/") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('/');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a / b;
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }
                    }

                    else if (textBox_result.Text.StartsWith("-") == true)
                    {
                        if (textBox_result.Text.Contains("+") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('+');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a + b;
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }

                        else if (textBox_result.Text.StartsWith("-") == false && textBox_result.Text.Contains("-") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('-');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a - b;
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }

                        else if (ujemna_cyfra_i_minus.IsMatch(textBox_result.Text))
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split(' ');

                            string a_str = tab[0];
                            string b_str = tab[2];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a - b;
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }

                        else if (textBox_result.Text.Contains("*") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('*');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str); ;

                            result = a * b;
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }

                        else if (textBox_result.Text.Contains("/") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('/');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            result = a / b;
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }
                    }
                }
            }
        }

        private void btn_char_Click(object sender, EventArgs e)
        {
            Regex AC_regex = new Regex(@"([0-9]{1,})");
            Regex min_regex = new Regex(@"([-]{1,})$");
            Regex action = new Regex(@"([0-9]{1,})([\s]{1})([\+\-\*\/]{1})([\s]{1})([0-9]{1,})$");

            if (textBox_result.Text != "" && textBox_result.Text.Contains("Błąd!") == false && min_regex.IsMatch(textBox_result.Text) == false && textBox_result.Text.Contains("log") == false && action.IsMatch(textBox_result.Text) == false && textBox_result.Text.EndsWith(" + ") == false && textBox_result.Text.EndsWith(" - ") == false && textBox_result.Text.EndsWith(" * ") == false && textBox_result.Text.EndsWith(" / ") == false)
            {
                string tb_result = textBox_result.Text;
                int tb_result_int = int.Parse(tb_result);

                if (tb_result_int != 0)
                {
                    if (AC_regex.IsMatch(textBox_result.Text))
                    {
                        if (math_char == 0)
                        {
                            tB_result = textBox_result.Text;
                            textBox_result.Text = "";
                            textBox_result.Text += "-" + tB_result;

                            math_char = 1;
                        }

                        else if (math_char == 1)
                        {
                            tB_result = textBox_result.Text;
                            tab_AC = tB_result.Split('-');

                            string num = tab_AC[1];
                            int num_AC = int.Parse(num);

                            textBox_result.Text = "";
                            textBox_result.Text += num_AC;

                            math_char = 0;
                        }
                    }

                    else
                    {
                        if (math_char == 0)
                        {
                            textBox_result.Text = "";
                            textBox_result.Text += "-";
                            math_char = 1;
                        }

                        else if (math_char == 1)
                        {
                            textBox_result.Text = "";
                            math_char = 0;
                        }
                    }
                }
            }

            else if (textBox_result.Text.EndsWith(" + ") == true || textBox_result.Text.EndsWith(" - ") == true || textBox_result.Text.EndsWith(" * ") == true || textBox_result.Text.EndsWith(" / ") == true)
            {
                Regex EndsWith_char = new Regex(@"([0-9]{1,})([\s]{1})([\+\-\*\/]{1})([\s]{1})$");

                if (EndsWith_char.IsMatch(textBox_result.Text))
                {
                    if (textBox_result.Text.StartsWith("-") == false)
                    {
                        string text = textBox_result.Text;

                        textBox_result.Text = "";
                        textBox_result.Text += "-" + text;

                        math_char = 1;
                    }

                    else if (textBox_result.Text.StartsWith("-") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab_AC = tB_result.Split('-');

                        string text = tab_AC[1];
                        textBox_result.Text = "";
                        textBox_result.Text += text;

                        math_char = 0;
                    }
                }
            }

            else if (action.IsMatch(textBox_result.Text) == true)
            {
                string text = textBox_result.Text;

                if (math_char == 0)
                {
                    textBox_result.Text = "";
                    textBox_result.Text += "-" + text;
                    math_char = 1;
                }

                else if (math_char == 1)
                {
                    tB_result = textBox_result.Text;
                    tab_AC = tB_result.Split('-');

                    string num_action = tab_AC[1];

                    textBox_result.Text = "";
                    textBox_result.Text += num_action;

                    math_char = 0;
                }

            }

            else
            {
                if (math_char == 0)
                {
                    textBox_result.Text += "-";
                    math_char = 1;
                }

                else if (math_char == 1)
                {
                    textBox_result.Text = "";
                    math_char = 0;
                }
            }
        }

        private void cb_rozszerzenie_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_rozszerzenie.Checked == true)
            {
                Size = new Size(280, 335);
                this.textBox_result.Size = new System.Drawing.Size(254, 20);
                btn_backspace.Location = new Point(216, 5);
            }

            else if (cb_rozszerzenie.Checked == false)
            {
                Size = new Size(225, 335);
                this.textBox_result.Size = new System.Drawing.Size(196, 20);
                btn_backspace.Location = new Point(158, 5);
            }
        }

        private void btn_pierwiastek_Click(object sender, EventArgs e)
        {
            Regex n = new Regex(@"([0-9]{1,})$");
            Regex n_znak = new Regex(@"([0-9]{1,})([\s]{1})([\+\-\*\/]{1})([\s]{1})([0-9]{1,})$");

            if (textBox_result.Text.Contains("Błąd!") == false && textBox_result.Text.Contains("log") == false && n_znak.IsMatch(textBox_result.Text) == true)
            {
                if (textBox_result.Text.EndsWith(",") == false && textBox_result.Text.EndsWith("+ ") == false && textBox_result.Text.EndsWith("- ") == false && textBox_result.Text.EndsWith("* ") == false && textBox_result.Text.EndsWith("/ ") == false)
                {
                    if (textBox_result.Text.StartsWith("-") == false)
                    {
                        if (textBox_result.Text.Contains("+") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('+');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a + b;
                            result = Math.Sqrt(result);
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }

                        else if (textBox_result.Text.Contains("-") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('-');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a - b;

                            if (result >= 0)
                            {
                                result = Math.Sqrt(result);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (result < 0)
                            {
                                textBox_result.Text = "Błąd!";
                            }
                        }

                        else if (textBox_result.Text.Contains("*") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('*');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str); ;

                            double result = a * b;
                            result = Math.Sqrt(result);
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }

                        else if (textBox_result.Text.Contains("/") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('/');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a / b;
                            result = Math.Sqrt(result);
                            textBox_result.Text = "";
                            textBox_result.Text += result;
                        }
                    }

                    else if (textBox_result.Text.StartsWith("-") == true)
                    {
                        if (textBox_result.Text.Contains("+") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('+');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a + b;
                            if (result >= 0)
                            {
                                result = Math.Sqrt(result);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (result < 0)
                            {
                                textBox_result.Text = "Błąd!";
                            }
                        }

                        else if (textBox_result.Text.StartsWith("-") == false && textBox_result.Text.Contains("-") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('-');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a - b;
                            if (result >= 0)
                            {
                                result = Math.Sqrt(result);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (result < 0)
                            {
                                textBox_result.Text = "Błąd!";
                            }
                        }

                        else if (ujemna_cyfra_i_minus.IsMatch(textBox_result.Text))
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split(' ');

                            string a_str = tab[0];
                            string b_str = tab[2];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a - b;

                            if (result >= 0)
                            {
                                result = Math.Sqrt(result);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (result <= 0)
                            {
                                textBox_result.Text = "Błąd!";
                            }
                        }

                        else if (textBox_result.Text.Contains("*") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('*');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str); ;

                            double result = a * b;

                            if (result >= 0)
                            {
                                result = Math.Sqrt(result);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (result < 0)
                            {
                                textBox_result.Text = "Błąd!";
                            }
                        }

                        else if (textBox_result.Text.Contains("/") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('/');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a / b;

                            if (result >= 0)
                            {
                                result = Math.Sqrt(result);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (result < 0)
                            {
                                textBox_result.Text = "Błąd!";
                            }
                        }
                    }
                }
            }

            else if (n.IsMatch(textBox_result.Text) == true)
            {
                string l = textBox_result.Text;
                double num_sqrt = double.Parse(l);

                if (num_sqrt > 0)
                {
                    num_sqrt = Math.Sqrt(num_sqrt);

                    textBox_result.Text = "";
                    textBox_result.Text += num_sqrt;
                }

                else if (num_sqrt <= 0)
                {
                    textBox_result.Text = "";
                    textBox_result.Text += "Błąd!";
                }
            }

            else if (textBox_result.Text.EndsWith(",") == true || textBox_result.Text.EndsWith("+ ") == true || textBox_result.Text.EndsWith("- ") == true || textBox_result.Text.EndsWith("* ") == true || textBox_result.Text.EndsWith("/ ") == true)
            {

            }
        }

        private void btn_potega_Click(object sender, EventArgs e)
        {
            Regex n = new Regex(@"([0-9]{1,})$");
            Regex n_znak = new Regex(@"([0-9]{1,})([\s]{1})([\+\-\*\/]{1})([\s]{1})([0-9]{1,})$");

            if (textBox_result.Text.Contains("Błąd!") == false && textBox_result.Text.Contains("log") == false && n_znak.IsMatch(textBox_result.Text) == true)
            {
                if (textBox_result.Text.EndsWith(",") == false && textBox_result.Text.EndsWith("+ ") == false && textBox_result.Text.EndsWith("- ") == false && textBox_result.Text.EndsWith("* ") == false && textBox_result.Text.EndsWith("/ ") == false)
                {
                    if (textBox_result.Text.StartsWith("-") == false)
                    {
                        if (textBox_result.Text.Contains("+") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('+');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a + b;

                            if (result == 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text += "0";
                            }

                            else
                            {
                                result = Math.Pow(result, 2);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }
                        }

                        else if (textBox_result.Text.Contains("-") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('-');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a - b;

                            if (result == 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text += "0";
                            }

                            else
                            {
                                result = Math.Pow(result, 2);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                        }

                        else if (textBox_result.Text.Contains("*") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('*');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str); ;

                            double result = a * b;

                            if (result == 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text += "0";
                            }

                            else
                            {
                                result = Math.Pow(result, 2);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }
                        }

                        else if (textBox_result.Text.Contains("/") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('/');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a / b;

                            if (result == 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text += "0";
                            }

                            else
                            {
                                result = Math.Pow(result, 2);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }
                        }
                    }

                    else if (textBox_result.Text.StartsWith("-") == true)
                    {
                        if (textBox_result.Text.Contains("+") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('+');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a + b;

                            if (result == 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text += "0";
                            }

                            else
                            {
                                result = Math.Pow(result, 2);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }
                        }

                        else if (textBox_result.Text.StartsWith("-") == false && textBox_result.Text.Contains("-") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('-');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a - b;

                            if (result == 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text += "0";
                            }

                            else
                            {
                                result = Math.Pow(result, 2);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                        }

                        else if (ujemna_cyfra_i_minus.IsMatch(textBox_result.Text))
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split(' ');

                            string a_str = tab[0];
                            string b_str = tab[2];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a - b;

                            if (result == 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text += "0";
                            }

                            else
                            {
                                result = Math.Pow(result, 2);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }
                        }

                        else if (textBox_result.Text.Contains("*") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('*');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str); ;

                            double result = a * b;

                            if (result == 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text += "0";
                            }

                            else
                            {
                                result = Math.Pow(result, 2);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }
                        }

                        else if (textBox_result.Text.Contains("/") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('/');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double result = a / b;

                            if (result == 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text += "0";
                            }

                            else
                            {
                                result = Math.Pow(result, 2);
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }
                        }
                    }
                }


                else if (textBox_result.Text.EndsWith(",") == true || textBox_result.Text.EndsWith("+ ") == true || textBox_result.Text.EndsWith("- ") == true || textBox_result.Text.EndsWith("* ") == true || textBox_result.Text.EndsWith("/ ") == true)
                {

                }
            }

            else if (n.IsMatch(textBox_result.Text) == true)
            {
                string l = textBox_result.Text;
                double num_pow = double.Parse(l);
                num_pow = Math.Pow(num_pow, 2);

                textBox_result.Text = "";
                textBox_result.Text += num_pow;
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            Regex action = new Regex(@"([0-9]{1,})([\s]{1})([/+/-/*//]{1})([\s]{1})([0-9]{1,})$");

            if (action.IsMatch(textBox_result.Text) == true)
            {
                if (textBox_result.Text.EndsWith("+") == false && textBox_result.Text.EndsWith("-") == false && textBox_result.Text.EndsWith("*") == false && textBox_result.Text.EndsWith("/") == false)
                {
                    if (textBox_result.Text.Contains("+") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('+');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double liczba_logarytmowana = a + b;

                        if (liczba_logarytmowana > 0)
                        {
                            double logarytm = Math.Log10(liczba_logarytmowana);

                            textBox_result.Text = "";
                            textBox_result.Text += logarytm;
                        }

                        else if (liczba_logarytmowana <= 0)
                        {
                            textBox_result.Text = "";
                            textBox_result.Text += "Błąd!";
                        }
                    }

                    else if (textBox_result.Text.Contains("-") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('-');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double liczba_logarytmowana = a - b;

                        if (liczba_logarytmowana > 0)
                        {
                            double logarytm = Math.Log10(liczba_logarytmowana);

                            textBox_result.Text = "";
                            textBox_result.Text += logarytm;
                        }

                        else if (liczba_logarytmowana <= 0)
                        {
                            textBox_result.Text = "";
                            textBox_result.Text += "Błąd!";
                        }
                    }

                    else if (textBox_result.Text.Contains("*") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('*');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double liczba_logarytmowana = a * b;

                        if (liczba_logarytmowana > 0)
                        {
                            double logarytm = Math.Log10(liczba_logarytmowana);

                            textBox_result.Text = "";
                            textBox_result.Text += logarytm;
                        }

                        else if (liczba_logarytmowana <= 0)
                        {
                            textBox_result.Text = "";
                            textBox_result.Text += "Błąd!";
                        }
                    }

                    else if (textBox_result.Text.Contains("/") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('/');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double liczba_logarytmowana = a / b;

                        if (liczba_logarytmowana > 0)
                        {
                            double logarytm = Math.Log10(liczba_logarytmowana);

                            textBox_result.Text = "";
                            textBox_result.Text += logarytm;
                        }

                        else if (liczba_logarytmowana <= 0)
                        {
                            textBox_result.Text = "";
                            textBox_result.Text += "Błąd!";
                        }
                    }
                }
            }

            else if (action.IsMatch(textBox_result.Text) == false)
            {
                Regex common = new Regex(@"([0-9]{1,})$");

                if (common.IsMatch(textBox_result.Text))
                {
                    string text = textBox_result.Text;
                    double liczba_logarytmowana = double.Parse(text);

                    if (liczba_logarytmowana <= 0)
                    {
                        textBox_result.Text = "";
                        textBox_result.Text += "Błąd!";
                    }

                    else if (liczba_logarytmowana > 0)
                    {
                        double logarytm = Math.Log10(liczba_logarytmowana);

                        textBox_result.Text = "";
                        textBox_result.Text += logarytm;
                    }
                }
            }
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text != "")
            {
                if (textBox_result.Text.Contains("Błąd!") == false)
                {
                    if (textBox_result.Text.EndsWith(" ") == false)
                    {
                        textBox_result.Text = textBox_result.Text.Remove(textBox_result.Text.Length - 1, 1);
                    }

                    else if (textBox_result.Text.EndsWith(" ") == true)
                    {
                        textBox_result.Text = textBox_result.Text.Remove(textBox_result.Text.Length - 2, 2);
                    }
                }
            }
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            Regex common = new Regex(@"([0-9]{1,})$");
            Regex action_pi = new Regex(@"([0-9]{1,})([\s]{1})([\+\-\*\/]{1})([\s]{1})([0-9]{1,})");
            double pi = 3.14;

            if (action_pi.IsMatch(textBox_result.Text) == true)
            {
                if (textBox_result.Text.StartsWith("-") == false)
                {
                    if (textBox_result.Text.Contains("+") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('+');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double num_pi = a + b;

                        if (action_pi.IsMatch(textBox_result.Text))
                        {
                            double asnwer = pi * num_pi;

                            textBox_result.Text = "";
                            textBox_result.Text += asnwer;
                        }

                        else if (textBox_result.Text == "")
                        {
                            textBox_result.Text += pi;
                        }
                    }

                    else if (textBox_result.Text.Contains("-") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('-');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double num_pi = a - b;

                        if (action_pi.IsMatch(textBox_result.Text))
                        {
                            double asnwer = pi * num_pi;

                            textBox_result.Text = "";
                            textBox_result.Text += asnwer;
                        }

                        else if (textBox_result.Text == "")
                        {
                            textBox_result.Text += pi;
                        }
                    }

                    else if (textBox_result.Text.Contains("*") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('*');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double num_pi = a * b;

                        if (action_pi.IsMatch(textBox_result.Text))
                        {
                            double asnwer = pi * num_pi;

                            textBox_result.Text = "";
                            textBox_result.Text += asnwer;
                        }

                        else if (textBox_result.Text == "")
                        {
                            textBox_result.Text += pi;
                        }
                    }

                    else if (textBox_result.Text.Contains("/") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('/');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double num_pi = a / b;

                        if (action_pi.IsMatch(textBox_result.Text))
                        {
                            double asnwer = pi * num_pi;

                            textBox_result.Text = "";
                            textBox_result.Text += asnwer;
                        }

                        else if (textBox_result.Text == "")
                        {
                            textBox_result.Text += pi;
                        }
                    }
                }

                else if (textBox_result.Text.StartsWith("-") == true)
                {
                    if (textBox_result.Text.Contains("+") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('+');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double num_pi = a + b;

                        if (action_pi.IsMatch(textBox_result.Text))
                        {
                            double asnwer = pi * num_pi;

                            textBox_result.Text = "";
                            textBox_result.Text += asnwer;
                        }

                        else if (textBox_result.Text == "")
                        {
                            textBox_result.Text += pi;
                        }
                    }

                    else if (textBox_result.Text.StartsWith("-") == false && textBox_result.Text.Contains("-") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('-');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double num_pi = a - b;

                        if (action_pi.IsMatch(textBox_result.Text))
                        {
                            double asnwer = pi * num_pi;

                            textBox_result.Text = "";
                            textBox_result.Text += asnwer;
                        }

                        else if (textBox_result.Text == "")
                        {
                            textBox_result.Text += pi;
                        }

                    }

                    else if (ujemna_cyfra_i_minus.IsMatch(textBox_result.Text))
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split(' ');

                        string a_str = tab[0];
                        string b_str = tab[2];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double num_pi = a - b;

                        if (action_pi.IsMatch(textBox_result.Text))
                        {
                            double asnwer = pi * num_pi;

                            textBox_result.Text = "";
                            textBox_result.Text += asnwer;
                        }

                        else if (textBox_result.Text == "")
                        {
                            textBox_result.Text += pi;
                        }
                    }

                    else if (textBox_result.Text.Contains("*") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('*');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double num_pi = a * b;

                        if (action_pi.IsMatch(textBox_result.Text))
                        {
                            double asnwer = pi * num_pi;

                            textBox_result.Text = "";
                            textBox_result.Text += asnwer;
                        }

                        else if (textBox_result.Text == "")
                        {
                            textBox_result.Text += pi;
                        }
                    }

                    else if (textBox_result.Text.Contains("/") == true)
                    {
                        tB_result = textBox_result.Text;
                        tab = tB_result.Split('/');

                        string a_str = tab[0];
                        string b_str = tab[1];

                        float a = float.Parse(a_str);
                        float b = float.Parse(b_str);

                        double num_pi = a / b;

                        if (action_pi.IsMatch(textBox_result.Text))
                        {
                            double asnwer = pi * num_pi;

                            textBox_result.Text = "";
                            textBox_result.Text += asnwer;
                        }

                        else if (textBox_result.Text == "")
                        {
                            textBox_result.Text += pi;
                        }
                    }
                }
            }

            else if (action_pi.IsMatch(textBox_result.Text) == false && common.IsMatch(textBox_result.Text) == true)
            {
                string text = textBox_result.Text;
                double number_for_pi = double.Parse(text);

                number_for_pi = number_for_pi * pi;

                textBox_result.Text = "";
                textBox_result.Text += number_for_pi;
            }
        }

        private void btn_1x_Click(object sender, EventArgs e)
        {
            Regex number = new Regex(@"([0-9]{1,})");
            Regex action = new Regex(@"([0-9]{1,})([\s]{1})([\+\-\*\/]{1})([\s]{1})([0-9]{1,})");

            if (textBox_result.Text.EndsWith(" + ") == false && textBox_result.Text.EndsWith(" - ") == false && textBox_result.Text.EndsWith(" * ") == false && textBox_result.Text.EndsWith(" / ") == false)
            {
                if (action.IsMatch(textBox_result.Text) == true)
                {
                    if (textBox_result.Text.StartsWith("-") == false)
                    {
                        if (textBox_result.Text.Contains("+") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('+');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double mianownik = a + b;
                            double result;

                            if (mianownik > 0)
                            {
                                result = 1 / mianownik;
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (mianownik <= 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text = "Błąd!";
                            }
                        }

                        else if (textBox_result.Text.Contains("-") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('-');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double mianownik = a - b;
                            double result;

                            if (mianownik > 0)
                            {
                                result = 1 / mianownik;
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (mianownik <= 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text = "Błąd!";
                            }
                        }

                        else if (textBox_result.Text.Contains("*") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('*');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double mianownik = a * b;
                            double result;

                            if (mianownik > 0)
                            {
                                result = 1 / mianownik;
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (mianownik <= 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text = "Błąd!";
                            }
                        }

                        else if (textBox_result.Text.Contains("/") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('/');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double mianownik = a / b;
                            double result;

                            if (mianownik > 0)
                            {
                                result = 1 / mianownik;
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (mianownik <= 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text = "Błąd!";
                            }
                        }

                    }

                    else if (textBox_result.Text.StartsWith("-") == true)
                    {
                        if (textBox_result.Text.Contains("+") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('+');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double mianownik = a + b;
                            double result;

                            if (mianownik > 0)
                            {
                                result = 1 / mianownik;
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (mianownik <= 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text = "Błąd!";
                            }
                        }

                        else if (textBox_result.Text.StartsWith("-") == false && textBox_result.Text.Contains("-") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('-');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double mianownik = a - b;
                            double result;

                            if (mianownik > 0)
                            {
                                result = 1 / mianownik;
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (mianownik <= 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text = "Błąd!";
                            }

                        }

                        else if (ujemna_cyfra_i_minus.IsMatch(textBox_result.Text))
                        {
                            textBox_result.Text = "";
                            textBox_result.Text = "Błąd!";
                        }

                        else if (textBox_result.Text.Contains("*") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('*');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double mianownik = a * b;
                            double result;

                            if (mianownik > 0)
                            {
                                result = 1 / mianownik;
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (mianownik <= 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text = "Błąd!";
                            }
                        }

                        else if (textBox_result.Text.Contains("/") == true)
                        {
                            tB_result = textBox_result.Text;
                            tab = tB_result.Split('/');

                            string a_str = tab[0];
                            string b_str = tab[1];

                            float a = float.Parse(a_str);
                            float b = float.Parse(b_str);

                            double mianownik = a / b;
                            double result;

                            if (mianownik > 0)
                            {
                                result = 1 / mianownik;
                                textBox_result.Text = "";
                                textBox_result.Text += result;
                            }

                            else if (mianownik <= 0)
                            {
                                textBox_result.Text = "";
                                textBox_result.Text = "Błąd!";
                            }
                        }
                    }
                }

                else if (number.IsMatch(textBox_result.Text) == true && action.IsMatch(textBox_result.Text) == false)
                {
                    string text = textBox_result.Text;
                    double mianownik = double.Parse(text);

                    if (mianownik > 0)
                    {
                        double result = 1 / mianownik;

                        textBox_result.Text = "";
                        textBox_result.Text += result;
                    }

                    else if (mianownik <= 0)
                    {
                        textBox_result.Text = "";
                        textBox_result.Text = "Błąd!";
                    }
                }
            }

        }
    }
}
