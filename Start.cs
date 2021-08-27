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
        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Red;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.White;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.ForeColor = Color.Gray;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.ForeColor = Color.White;
        }
        private int r = 0, g = 210, b = 0;

        private void Rainbow_Text_Tick(object sender, EventArgs e)
        {
            FormNameLabel.ForeColor = Color.FromArgb(r, g, b);
            CSGO_Cheat_Cleaner.ForeColor = Color.FromArgb(r, g, b);
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
            Application.Exit();
        }

        private void CSGO_Cheat_Cleaner_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Hide();
            Cleaner_Form openTest = new Cleaner_Form();
            openTest.Show();
        }

        private void CSGO_Cheat_Detector_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Hide();
            Detector_Form openTest = new Detector_Form();
            openTest.Show();
        }

        private void Clock1Timer_Tick(object sender, EventArgs e)
        {
            Clock1.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Minimize_MouseDown(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Clock1.Text = DateTime.Now.ToString("HH:mm:ss tt");
            Clock1Timer.Enabled = true;
        }
    }
}
