using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBouton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton2.Checked = true;
            //radioButton1.Text = "Daouda"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (radioButton1.Checked) label1.Text = radioButton1.Text;
            if (radioButton2.Checked) label1.Text = radioButton2.Text;
            if (radioButton3.Checked) label1.Text = radioButton3.Text;*/
            label1.Text = isChecked(groupBox1); 
        }

        string isChecked(Control container)
        {
            foreach(Control control in container.Controls)
            {
                RadioButton radio = control as RadioButton;
                if (radio.Checked) return radio.Text; 
            }
            return null; 
        }
    }
}
