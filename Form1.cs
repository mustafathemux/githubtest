using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double dcpu = performancecpu.NextValue();
            double dram = performanceram.NextValue();
            progressBar1.Value = (int)dcpu;
            progressBar2.Value = (int)dram;
            label3.Text = string.Format("{00:00.0}%", dcpu);
            label4.Text = string.Format("{00:00.0}%", dram);

            //label3.Text = dcpu.ToString();
            //label4.Text = dram.ToString();

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
