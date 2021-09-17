using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSGO_Cheat_Cleaner_Detector
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        // Form Design
        private int r = 0, g = 210, b = 0;
        private bool Rainbow;

        private void Rainbow_Text_Tick(object sender, EventArgs e)
        {
            FormNameLabel.ForeColor = Color.FromArgb(r, g, b);
            CSGO_Cheat_Cleaner.ForeColor = Color.FromArgb(r, g, b);
            Application_Downloader.ForeColor = Color.FromArgb(r, g, b);
            RainbowText.ForeColor = Color.FromArgb(r, g, b);
            CSGO_Cheat_Detector.ForeColor = Color.FromArgb(r, g, b);
            Exit.ForeColor = Color.FromArgb(r, g, b);
            Clock1.ForeColor = Color.FromArgb(r, g, b);
            Minimize.ForeColor = Color.FromArgb(r, g, b);
            if (r > 0 && b == 0)
            {
                r--;
                g++;
            }
            if (g > 0 && r == 0)
            {
                g--;
                b++;
            }
            if (b > 0 && g == 0)
            {
                b--;
                r++;
            }
            // Form Design
        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Exit_Form OpenForm = new Exit_Form();
            OpenForm.Show();
        }

        private void CSGO_Cheat_Cleaner_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Close();
            Cleaner_Form OpenForm = new Cleaner_Form();
            OpenForm.Show();
        }

        private void CSGO_Cheat_Detector_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Close();
            Detector_Form OpenForm = new Detector_Form();
            OpenForm.Show();
        }

        private void Clock1Timer_Tick(object sender, EventArgs e)
        {
            Clock1.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void RainbowDisableEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (Rainbow == true)
            {
                Rainbow = false;
                Rainbow_Text.Enabled = false;
                CSGO_Cheat_Cleaner.ForeColor = Color.White;
                CSGO_Cheat_Detector.ForeColor = Color.White;
                Application_Downloader.ForeColor = Color.White;
                RainbowText.ForeColor = Color.White;
                FormNameLabel.ForeColor = Color.White;
                Minimize.ForeColor = Color.White;
                Exit.ForeColor = Color.White;
                Clock1.ForeColor = Color.White;
            }
            else
            {
                Rainbow = true;
                Rainbow_Text.Enabled = true;
            }
        }

        private void RainbowDisableEnable_MouseEnter(object sender, EventArgs e)
        {
            RainbowText.Show();
        }

        private void RainbowDisableEnable_MouseLeave(object sender, EventArgs e)
        {
            RainbowText.Hide();
        }

        private void Application_Downloader_MouseDown(object sender, MouseEventArgs e)
        {
            Rainbow_Text.Enabled = false;
            Close();
            Application_Downloader_Form OpenForm = new Application_Downloader_Form();
            OpenForm.Show();
        }

        private void exitToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Restart();
        }

        private void Minimize_MouseDown(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Rainbow = true;
            Clock1.Text = DateTime.Now.ToString("HH:mm:ss tt");
            Clock1Timer.Enabled = true;
        }
    }
}
