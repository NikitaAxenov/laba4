using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace money
{
    public partial class Form1 : Form
    {
        const double k = 0.5;
        double price;
        int days;
        int i;
        string r_string;
        string u_string;
        int r;
        int r_now = 10000;
        int u;
        int u_now = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            price = (double)forPrice.Value;
            days = (int)forDays.Value;
            i = 0;
            chart1.Series[0].Points.AddXY(0, price);
            timer1.Start();
            timer1.Interval = 5000; // Вообще, в идеале выставлять хотя бы секунд 30, конечно, чтобы успеть подумать, выставить количество и купить
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            forBuy.Value = forBuy.Minimum;
            transfer_For_Rub();
            transfer_For_Ue();
            i++;
            price = price * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(i, price);
            if (days > 10)
            {
                if (i >= 11)
                {
                    chart1.ChartAreas[0].AxisX.Maximum = i;
                    chart1.ChartAreas[0].AxisX.Minimum = i - 10;
                }
            }
            if (i == days)
            {
                timer1.Stop();
                forBuy.Maximum = 0;
                forBuy.Minimum = 0;
                forBuy.Value = 0;
                forSell.Maximum = 0;
                forSell.Minimum = 0;
                forSell.Value = 0;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            rub.Text = (r_now - ((int)forBuy.Value * (int)price)).ToString();
            r_now -= (int)forBuy.Value * (int)price;
            ue.Text = (forBuy.Value + u_now).ToString();
            u_now = (int)forBuy.Value + u_now;
            forBuy.Value = forBuy.Minimum;
            forSell.Minimum = 1;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            rub.Text = (r_now + ((int)forSell.Value * (int)price)).ToString();
            r_now += (int)forSell.Value * (int)price;
            ue.Text = (forSell.Value - u_now).ToString();
            u_now = (int)forSell.Value - u_now;
            forSell.Value = forSell.Minimum;
            if (ue.Text == "0")
            {
                forSell.Minimum = 0;
                forSell.Maximum = 0;
                forSell.Value = 0;
            }
        }

        private void transfer_For_Rub()
        {
            r_string = rub.Text;
            r = 0;
            for (int i1 = 0; i1 < r_string.Length; i1++)
            {
                if (r_string[i1] == 48)
                    r = r * 10;
                if (r_string[i1] == 49)
                    r = r * 10 + 1;
                if (r_string[i1] == 50)
                    r = r * 10 + 2;
                if (r_string[i1] == 51)
                    r = r * 10 + 3;
                if (r_string[i1] == 52)
                    r = r * 10 + 4;
                if (r_string[i1] == 53)
                    r = r * 10 + 5;
                if (r_string[i1] == 54)
                    r = r * 10 + 6;
                if (r_string[i1] == 55)
                    r = r * 10 + 7;
                if (r_string[i1] == 56)
                    r = r * 10 + 8;
                if (r_string[i1] == 57)
                    r = r * 10 + 9;
            }
            if (r / Math.Ceiling(price) >= 1)
                forBuy.Maximum = (decimal)(r / Math.Ceiling(price));
            else
                forBuy.Minimum = 0;
        }
        
        private void transfer_For_Ue()
        {
            u_string = ue.Text;
            u = 0;
            for (int i2 = 0; i2 < u_string.Length; i2++)
            {
                if (u_string[i2] == 48)
                    u = u * 10;
                if (u_string[i2] == 49)
                    u = u * 10 + 1;
                if (u_string[i2] == 50)
                    u = u * 10 + 2;
                if (u_string[i2] == 51)
                    u = u * 10 + 3;
                if (u_string[i2] == 52)
                    u = u * 10 + 4;
                if (u_string[i2] == 53)
                    u = u * 10 + 5;
                if (u_string[i2] == 54)
                    u = u * 10 + 6;
                if (u_string[i2] == 55)
                    u = u * 10 + 7;
                if (u_string[i2] == 56)
                    u = u * 10 + 8;
                if (u_string[i2] == 57)
                    u = u * 10 + 9;
            }
            if (u >= 1)
                forSell.Maximum = (decimal)(u);
            else
                forSell.Minimum = 0;
        }
    }
}
