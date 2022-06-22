using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // label1.Text = numericUpDown1.Value.ToString();
            // numericUpDown1.Value = 30;
            //incrementation 
            numericUpDown1.Increment = 5;
            numericUpDown1.Minimum = 50;
            numericUpDown1.Maximum = 150; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // label2.Text = dateTimePicker1.Value.ToString();
            dateTimePicker1.MinDate = new DateTime(2022, 1, 1);
            dateTimePicker1.MaxDate = new DateTime(2025, 1, 31);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //modifier l'affichage 
            DateTime date = dateTimePicker1.Value;
            //label2.Text = date.ToString("d");
            //label2.Text = date.ToString("t");
            //la différence est que la date s'affiche sans avoir à cliquer sur le bouton de validation 
            // label2.Text = dateTimePicker1.Value.ToString();
        }
    }
}
