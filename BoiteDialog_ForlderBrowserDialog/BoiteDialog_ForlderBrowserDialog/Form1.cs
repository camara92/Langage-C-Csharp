using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoiteDialog_ForlderBrowserDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //méthode qui a pour but de ne pas créer un folderbrowserdialog 
            /*
            FolderBrowserDialog monFolder = new FolderBrowserDialog();
            monFolder.ShowNewFolderButton = true; 
            monFolder.Description = "Ma description";
            monFolder.RootFolder = Environment.SpecialFolder.Desktop;
            monFolder.ShowDialog(); 
             */
            folderBrowserDialog1.Description = "Une description";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.ProgramFiles; 
            //folderBrowserDialog1 = new FolderBrowserDialog();
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //recherche d'un dossier 
                label1.Text = folderBrowserDialog1.SelectedPath; 

            }
        }
    }
}
