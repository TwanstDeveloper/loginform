using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Twanst" && textBox2.Text=="123" && comboBox1.Text=="Admin")
            {
                this.Hide();
                mainform obj = new mainform();
                obj.ShowDialog();
            }
            if (textBox1.Text!="Twanst")
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;

            }
            if (textBox2.Text != "123")
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;

            }
            if (comboBox1.Text!="Admin")
            {
                MessageBox.Show("Tkaia user Type Halbzhera");
            }
            else
            {
                return;
            }
        }
    }
}
