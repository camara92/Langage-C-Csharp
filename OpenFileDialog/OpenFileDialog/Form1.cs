using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filecontent = string.Empty;
            var filepath = string.Empty;
            openFileDialog1.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            openFileDialog1.Filter = "jpg files (*.jpg)|.jpg|all files (*.*)| *.*";
            //openFileDialog1.Filter = "txt files (*.txt)|.txt|all files (*.*)| *.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Choisissez votre fichier image "; 

            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                //recuperer le path du fichier 
                filepath= openFileDialog1.FileName;
                textBox1.Text = filepath;
            }
            var filesstring = openFileDialog1.OpenFile();
            using(StreamReader reader =new StreamReader(filesstring))
            {
                filecontent = reader.ReadToEnd();
            }
            textBox2.Text = filecontent;

            pictureBox1.Load(filepath);

        }
    }
}
