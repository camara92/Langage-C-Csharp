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

namespace SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Filter = "Fichier texte (*.txt)|*.txt*";
            saveFileDialog1.Filter = "Fichier texte (*.txt)|*.txt| Fichier PDF(*.pdf)|*.pdf";
            saveFileDialog1.Title = "Enregistrer votre fichier svp ";
            saveFileDialog1.ShowDialog(); 
            //recuperer 
            if(saveFileDialog1.FileName !="")
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        MessageBox.Show("Enregistrement au format txt");
                        break; 
                    case 2:
                        MessageBox.Show("Enregistrement au format PDF");
                        break; 

                }
               StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Close(); 
            }
        }
    }
}
