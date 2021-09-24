using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSGO_Cheat_Cleaner_Detector
{
    public partial class Login_Information : Form
    {
        public Login_Information()
        {
            InitializeComponent();
        }

        // Form Design
        private int r = 0, g = 210, b = 0;
        private bool Rainbow;
        private void Rainbow_Text_Tick(object sender, EventArgs e)
        {
            FormNameLabel.ForeColor = Color.FromArgb(r, g, b);
            Exit.ForeColor = Color.FromArgb(r, g, b);
            Are_You_Sure.ForeColor = Color.FromArgb(r, g, b);
            Clock1.ForeColor = Color.FromArgb(r, g, b);
            Continue_App.ForeColor = Color.FromArgb(r, g, b);
            RainbowText.ForeColor = Color.FromArgb(r, g, b);
            RainbowText2.ForeColor = Color.FromArgb(r, g, b);
            Cancel.ForeColor = Color.FromArgb(r, g, b);
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

        private void Cancel_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Close();
            Login_Form OpenForm = new Login_Form();
            OpenForm.Show();
        }

        private void Continue_App_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Close();
            Start OpenForm = new Start();
            OpenForm.Show();
        }

        private void Clock1Timer_Tick(object sender, EventArgs e)
        {
            Clock1.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Close();
            Login_Form OpenForm = new Login_Form();
            OpenForm.Show();
        }

        private void RainbowDisableEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (Rainbow == true)
            {
                Rainbow = false;
                Rainbow_Text.Enabled = true;
            }
            else
            {
                Rainbow = true;
                Rainbow_Text.Enabled = false;
                Are_You_Sure.ForeColor = Color.White;
                Continue_App.ForeColor = Color.White;
                RainbowText.ForeColor = Color.White;
                RainbowText2.ForeColor = Color.White;
                Cancel.ForeColor = Color.White;
                FormNameLabel.ForeColor = Color.White;
                Exit.ForeColor = Color.White;
                Clock1.ForeColor = Color.White;
            }
        }

        private void RainbowDisableEnable_MouseEnter(object sender, EventArgs e)
        {
            RainbowText.Show();
            RainbowText2.Show();
        }

        private void RainbowDisableEnable_MouseLeave(object sender, EventArgs e)
        {
            RainbowText.Hide();
            RainbowText2.Hide();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Rainbow = true;
            Clock1.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
