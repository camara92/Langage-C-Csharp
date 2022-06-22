using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //valider 
            //comboBox1.Items.Add(textBox1.Text);
            /*comboBox1.Items.Add("Daouda");
            comboBox1.Items.Add("Danis");
            comboBox1.Items.Add("Diallo");
            comboBox1.Items.Add("Selena");
            comboBox1.Items.Add("Sidi");
            comboBox1.Sorted = true;*/
            //ordre alpha
            string[] tab = { "jean", "gluck", "daouda" }; 
            comboBox1.Items.AddRange(tab);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear(); 
            //comboBox1.Items.RemoveAt(1);
            // comboBox1.Items.Remove("Daouda");
            // label1.Text = comboBox1.Items.Count.ToString(); 
            //if (comboBox1.Items.Contains("Daouda")) label1.Text = "Daouda existe bien dans la liste"; 

            //label1.Text= comboBox1.SelectedIndex.ToString();
             //label1.Text = comboBox1.SelectedItem.ToString();
            label1.Text = comboBox1.Items[0].ToString();

        }
    }
}
