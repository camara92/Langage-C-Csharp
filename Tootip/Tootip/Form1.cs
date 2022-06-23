using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tootip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Valeur de la trrackbar " + trackBar1.Value; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //modifier 
            trackBar1.Value += 10;
           // trackBar1.Value = 0;
            label1.Text = "Valeur de la trrackbar " + trackBar1.Value;

        }
    }
}
