using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoiteMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result; 
           result=  MessageBox.Show("Vous êtes sûr de vous déconnecter du programme ? ",
               "Message",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                //MessageBox.Show("Bye Daouda"); 
                //Application.Exit(); 
                label1.Text = "Vous avez dit Oui";
            }
            else
            {
                label1.Text = "Vous avez dit Non";
            }
        }
    }
}
