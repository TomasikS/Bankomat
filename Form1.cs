using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Form f=new Form();
        string code;
        int count;

        public Form1()
        {
            InitializeComponent();
            code = "";
            count = 0;
        }

 
        private void processclick(int v) {


            if (count < 4)
            {
                string str = v.ToString();
                code = code + str;
                textBox1.Text = code;
                count++;
               
              
                button12.Enabled = (textBox1.Text.Length ==4);
                   
                
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            processclick(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            processclick(2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            processclick(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            processclick(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            processclick(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            processclick(6);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            processclick(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            processclick(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            processclick(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            count =0; code = " ";textBox1.Text = " ";textBox1.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            processclick(0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            Database d = new Database();
            d.openConnection();
            //0 ok 1 -zly  2 - blokovana karta
            int res = d.checkPIN(code);

        }
    }
}
