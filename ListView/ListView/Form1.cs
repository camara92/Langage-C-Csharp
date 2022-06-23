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
           // listView1.Items.Add(initial).SubItems.Add(nom); //pour une colonne 
            ListViewItem ligne = new ListViewItem(initial);
            ligne.SubItems.Add(nom);
            ligne.SubItems.Add(prenom); 

            listView1.Items.Add(ligne);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lire 
            /* label4.Text = listView1.Items[0].Text+ " "+
                listView1.Items[0].SubItems[1].Text + " "+
                listView1.Items[0].SubItems[2].Text;  */

            //parcourir 
            /* foreach(ListViewItem ligne in listView1.Items)
             {
                 for(int i=0; i<ligne.SubItems.Count; i++)
                 {
                     string str = ligne.SubItems[i].Text;
                     // string str = ligne.SubItems[i].ToString();
                     Console.WriteLine(str); 
                 }
             }*/
          
      

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
