using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadItems(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(textBox1.Text); 
            //listBox1.Items.Remove("Ligne 3"); 
            //listBox1.Items.RemoveAt(2);
            //label1.Text ="il y a "+ listBox1.Items.Count.ToString()+ " éléments. "; 
            // listBox1.Items.Insert(1, "Nouvelle ligne");
            // listBox1.Items.Clear(); 
            /*string[] tab =
            {
                "a", "b", "Daouda"
            }; 
            listBox1.Items.AddRange(tab);*/
            //label1.Text= listBox1.Items.IndexOf("Ligne 3").ToString();
            /* string[] tableau = new string[listBox1.Items.Count];
             listBox1.Items.CopyTo(tableau, 0);
             foreach(var item in tableau)
             {
                 Console.WriteLine(item);

             }*/
            /*listBox1.SetSelected(5, true);
            listBox1.SetSelected(5, false);*/
            Console.WriteLine("-----------------------");
            foreach (var item in listBox1.SelectedItems)
            {
               
                Console.WriteLine(item.ToString());
            }


        }
        private void loadItems()
        {
            for(int i = 0; i <= 20; i++)
            {
                listBox1.Items.Add("Ligne "+i);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*label1.Text = listBox1.SelectedItem.ToString();
            label1.Text = listBox1.SelectedIndex.ToString();*/
        }
    }
}
