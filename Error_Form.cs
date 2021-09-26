using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSGO_Cheat_Cleaner_Detector
{
    public partial class Error_Form : Form
    {
        public Error_Form()
        {
            InitializeComponent();
        }
        // Form Design
        private int r = 0, g = 210, b = 0;
        private bool Rainbow;
        private readonly Timer FadeIn = new Timer();
        private readonly Timer FadeOut = new Timer();
        private void Rainbow_Text_Tick(object sender, EventArgs e)
        {
            FormNameLabel.ForeColor = Color.FromArgb(r, g, b);
            Exit.ForeColor = Color.FromArgb(r, g, b);
            Wrong_Pass_Label.ForeColor = Color.FromArgb(r, g, b);
            RainbowText.ForeColor = Color.FromArgb(r, g, b);
            RainbowText2.ForeColor = Color.FromArgb(r, g, b);
            Clock1.ForeColor = Color.FromArgb(r, g, b);
            Try_Again.ForeColor = Color.FromArgb(r, g, b);
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

        private void Clock1Timer_Tick(object sender, EventArgs e)
        {
            Clock1.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                FadeOut.Stop();    //if it is, we stop the time
                Close();
                Login_Form OpenForm = new Login_Form();
                OpenForm.Show();
            }
            else
            {
                Opacity -= 0.05;
            }
        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            FadeOut.Tick += new EventHandler(fadeOut);  //this calls the fade out function
            FadeOut.Interval = 2;
            FadeOut.Start();
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

                Wrong_Pass_Label.ForeColor = Color.White;
                Try_Again.ForeColor = Color.White;
                RainbowText.ForeColor = Color.White;
                RainbowText2.ForeColor = Color.White;
                FormNameLabel.ForeColor = Color.Red;
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

        private void Try_Again_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            FadeOut.Tick += new EventHandler(fadeOut);  //this calls the fade out function
            FadeOut.Interval = 2;
            FadeOut.Start();
        }

        private void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 0.9)
            {
                FadeIn.Stop();   //this stops the timer if the form is completely displayed
            }
            else
            {
                Opacity += 0.05;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Rainbow = true;
            Clock1.Text = DateTime.Now.ToString("HH:mm:ss tt");

            Opacity = 0;      //first the opacity is 0
            FadeIn.Interval = 2;  //we'll increase the opacity every 10ms
            FadeIn.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity
            FadeIn.Start();
        }
    }
}
