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
    public partial class istirahatMessage : Form
    {
        public istirahatMessage()
        {
            InitializeComponent();
        }

        private void istirahatMessage_Load(object sender, EventArgs e)
        {
            Tools.MakeTopMost(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHome frm = new FormHome();
            frm.PlayRingtone(false);

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
