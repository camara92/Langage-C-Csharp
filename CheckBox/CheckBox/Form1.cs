﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string str = null; 

            /*  List<string> maListe = new List<string>();
               label1.Text = ""; 
               if (checkBox1.Checked) maListe.Add(checkBox1.Text);
               if (checkBox2.Checked) maListe.Add(checkBox2.Text);
               if (checkBox3.Checked) maListe.Add(checkBox3.Text);
               if (checkBox4.Checked) maListe.Add(checkBox4.Text);

               foreach(string ma in maListe)
               {
                   label1.Text += ma + ", ";  
               }*/
            label1.Text = "";

            label1.Text = isChecked(groupBox1); 

        }
        string isChecked(Control container)
        {
            string str = null; 
            foreach(var control in container.Controls)
            {
                CheckBox cb = control as checkBox1;  
                if(cb.Checked) str += " "+ cb.Text;
            }
            return str;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
