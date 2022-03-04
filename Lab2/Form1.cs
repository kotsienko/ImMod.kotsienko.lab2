using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.05;
        double rateE, rateD;
        int day = 0;

        Random random = new Random();     

        private void btPredict_Click(object sender, EventArgs e)
        {
            timer1.Start();
            rateE = (double)edRateE.Value;
            rateD = (double)edRateD.Value;

            chart1.Series[0].Points.Clear();            
            chart1.Series[0].Points.AddXY(0, rateE);

            chart1.Series[1].Points.Clear();
            chart1.Series[1].Points.AddXY(0, rateD);

            
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rateE = rateE * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(day++, rateE);

            rateD = rateE * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[1].Points.AddXY(day, rateD);                      
        }
    }
}
