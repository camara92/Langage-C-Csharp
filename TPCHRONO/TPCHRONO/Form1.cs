using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCHRONO
{
    public partial class Form1 : Form
    {
    int sec = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

            button1.Text = timer1.Enabled ? "Stop" : "Start"; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //variable qui increment 
            sec++; 
            label1.Text = sec.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sec = 0;
            label1.Text = sec.ToString(); 
        }
    }
}
