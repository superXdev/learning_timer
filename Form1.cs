using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Learning_Timer
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            siderPanel.Height = button2.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Move(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep(20000, 5000);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            siderPanel.Height = button2.Height;
            siderPanel.Top = button2.Top;
            formHome1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            siderPanel.Height = button3.Height;
            siderPanel.Top = button3.Top;
        }

        private void formHome1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            siderPanel.Height = button4.Height;
            siderPanel.Top = button4.Top;
            formAbout1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                e.Cancel = true;
        }

        private void formHome1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
