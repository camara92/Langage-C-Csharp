using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageListe
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
            //listView1.View = View.SmallIcon;
            //listView1.View = View.LargeIcon;
            //listView1.LargeImageList = imageList1; 
            listView1.Items.Add("Terra", 0);
            listView1.Items.Add("Valhala", 1);
            //listView1.Items.Add("Valhala", "daouda.png");
            listView1.Items.Add("Soniky", 2);
            listView1.Items.Add("Brumomars", 3);
            listView1.Items.Add("Lucienne", 4);
        }
    }
}
