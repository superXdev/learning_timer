using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Timer
{
    public partial class belajarMessage : Form
    {
        public belajarMessage()
        {
            InitializeComponent();
        }

        private void belajarMessage_Load(object sender, EventArgs e)
        {
            Tools.MakeTopMost(this);
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            FormHome frm = new FormHome();
            frm.PlayRingtone(false);

            this.Close();
        }
    }
}
