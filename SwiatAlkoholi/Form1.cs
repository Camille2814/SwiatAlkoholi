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

namespace SwiatAlkoholi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            int data = int.Parse(dateTimePicker1.Value.ToString("yyyyMMdd"));
            int dataNow = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int age = ((dataNow - data)/10000);

            if(age >= 18)
            {
                panel4.Visible = true;
                button2.Visible = true;
            }
            else 
            {
                panel4.Visible = false;
                button2.Visible = false;
            }
        }

        
    }
}
