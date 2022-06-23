using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontDialogue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //avoir un fontdialog 
            if(fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                label1.Font = fontDialog1.Font;
                string mafonte = "size "+ fontDialog1.Font.Name+
                    "\n bold"+ fontDialog1.Font.Bold+
                      "\n italique" + fontDialog1.Font.Italic +
                        "\n family" + fontDialog1.Font.FontFamily+
                          "\n nom" + fontDialog1.Font.Name;
                MessageBox.Show(mafonte); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                //pour avoir la palette de couleur 

                label1.ForeColor = colorDialog1.Color;
                label1.BackColor = colorDialog1.Color;
                MessageBox.Show(colorDialog1.Color.ToString());
                button1.ForeColor = colorDialog1.Color; 
                button2.ForeColor = colorDialog1.Color;
            }
        }
    }
}
