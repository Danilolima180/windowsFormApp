using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible= false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            label2.Text = "Texto apaga";
        }

        private void label2_Click(object sender, EventArgs e)
        {
           label2.Visible=false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible= true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
