using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        int progress = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.Value++; 
            progress++;
            if (progress <= progressBar1.Maximum)
            {
                progressBar1.Value = progress;
                //label1.Text = progressBar1.Value + "%" + progressBar1.Maximum; 
                label1.Text = progressBar1.Value + "%" ;
            }
            if (progressBar1.Value>60)
            {
                //aller dans Program et desactiver le code correspondant :style visuel 
                progressBar1.ForeColor = Color.Red;
            }

        }
    }
}
