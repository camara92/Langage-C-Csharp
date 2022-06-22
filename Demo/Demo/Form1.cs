using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        int sec = 0; //accessible partout 
        bool activation = false;
        public Form1()
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Salut Daouda");
        }
        private void btn_Click2(object sender, EventArgs e)
        {
            Console.WriteLine("SaluCode 2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Troixieme bouton");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;
            string[] tableau = textBox1.Lines;
            foreach (string s in tableau)
            {
                Console.WriteLine(s);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            activation = !activation;
            timer1.Enabled = activation;
            // timer1.Stop();
            // timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sec++;
            label1.Text = sec.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
