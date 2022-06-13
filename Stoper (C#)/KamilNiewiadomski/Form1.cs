using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamilNiewiadomski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int zs1 = 0;
        int zs2 = 0;
        int zm1 = 0;
        int zm2 = 0;
        int zh1 = 0;
        int zh2 = 0;

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            stop.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zs1 += 1;
            if(zs1 == 10)
            {
                zs1 = 0;
                zs2 += 1;
            }
            if(zs2 == 6)
            {
                zs2 = 0;
                zm1 += 1;
            }
            if(zm1 == 10)
            {
                zm1 = 0;
                zm2 += 1;
            }
            if(zm2 == 6)
            {
                zm2 = 0;
                zh1 += 1;
            }
            if (zh1 == 10)
            {
                zh2 += 1;
            }
            min2.Image = imageList1.Images[zm1];
            min2.Refresh();
            min1.Image = imageList1.Images[zm2];
            min1.Refresh();
            sek2.Image = imageList1.Images[zs1];
            sek2.Refresh();
            sek1.Image = imageList1.Images[zs2];
            sek1.Refresh();
            godz1.Image = imageList1.Images[zh2];
            godz1.Refresh();
            godz2.Image = imageList1.Images[zh1];
            godz2.Refresh();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            min2.Image = imageList1.Images[0];
            min2.Refresh();
            min1.Image = imageList1.Images[0];
            min1.Refresh();
            sek2.Image = imageList1.Images[0];
            sek2.Refresh();
            sek1.Image = imageList1.Images[0];
            sek1.Refresh();
            godz1.Image = imageList1.Images[0];
            godz1.Refresh();
            godz2.Image = imageList1.Images[0];
            godz2.Refresh();
            zs1 = 0;
            zs2 = 0;
            zm1 = 0;
            zm2 = 0;
            zh1 = 0;
            zh2 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
