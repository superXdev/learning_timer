using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Learning_Timer
{
    public partial class FormHome : UserControl
    {
        int learn, breaks;
        int seconds, minutes; int hours = 0;
        string timerState;
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }



        private void countTimer_Tick(object sender, EventArgs e)
        {
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0 && numericUpDown2.Value != 0)
            {
                if (button1.Text == "Start")
                {
                    int belajar = Decimal.ToInt32(numericUpDown1.Value) * 60000;
                    int istirahat = Decimal.ToInt32(numericUpDown2.Value) * 60000;
                    

                    learn = Decimal.ToInt32(numericUpDown1.Value);
                    breaks = Decimal.ToInt32(numericUpDown2.Value);

                    minutes = learn % 60;
                    hours = learn / 60;
                    Timer.Start();

                    timerState = "learn";

                    button1.Text = "Stop";
                    button1.BackColor = Color.FromArgb(192, 0, 0);
                    lblTimer.ForeColor = Color.FromArgb(192, 0, 0);
                }
                else
                {
                    Timer.Stop();

                    seconds = 0; minutes = 0; hours = 0;
                    lblTimer.Text = "00 : 00 : 00";

                    button1.Text = "Start";
                    button1.BackColor = Color.FromArgb(0, 0, 192);
                }
            }
            else
            {
                MessageBox.Show("Textbox is null!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string secTxt, minTxt, hrsTxt;
            if (seconds == 0)
            {
                minutes -= 1;
                seconds = 59;
            }
            else if (minutes == 0 && hours > 0)
            {
                hours -= 1;
                minutes = 59;
            }
            else
            {
                seconds -= 1;
            }

            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                if (timerState == "learn")
                {
                    Timer.Stop();
                    PlayRingtone(true);
                    new istirahatMessage().Show();
                    minutes = breaks % 60;
                    hours = breaks / 60;
                    timerState = "break";
                    lblTimer.ForeColor = Color.FromArgb(0, 192, 0);
                    Timer.Start();
                }
                else
                {
                    Timer.Stop();
                    PlayRingtone(true);
                    new belajarMessage().Show();
                    minutes = learn % 60;
                    hours = learn / 60;
                    timerState = "learn";
                    lblTimer.ForeColor = Color.FromArgb(192, 0, 0);
                    Timer.Start();
                }
            }
            // For second
            if (seconds < 10)
                secTxt = "0" + seconds.ToString();
            else
                secTxt = seconds.ToString();
            // For minutes
            if (minutes < 10)
                minTxt = "0" + minutes.ToString();
            else
                minTxt = minutes.ToString();

            if (hours < 10)
                hrsTxt = "0" + hours.ToString();
            else
                hrsTxt = hours.ToString();

            lblTimer.Text = hrsTxt + " : " + minTxt + " : " + secTxt;
        }

        public void PlayRingtone(bool isPlay)
        {
            string soundPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\sound\bell_in_temple.mp3";

            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.settings.playCount = 10;
            player.URL = soundPath;

            if (isPlay)
            {
                player.controls.play();
            }
            else
            {
                player.controls.stop();
            }
        }

    }
}
