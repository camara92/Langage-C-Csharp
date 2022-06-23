using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string initial = textBox1.Text;
            string prenom = textBox2.Text;
            string nom = textBox3.Text;

            //ajout 
            ListViewItem ligne = new ListViewItem(initial);
            ligne.SubItems.Add(nom);
            ligne.SubItems.Add(prenom); 

            listView1.Items.Add(ligne);
        }
    }
}
