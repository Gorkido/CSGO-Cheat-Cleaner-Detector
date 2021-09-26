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
        private readonly Timer FadeIn = new Timer();
        private readonly Timer FadeOut = new Timer();
        private readonly Timer FadeOut2 = new Timer();
        private readonly Timer FadeOut3 = new Timer();

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
            FormCollection AllForms = Application.OpenForms;
            bool FormOpen = false;
            Form OpenedForm = new Form();
            foreach (Form form in AllForms)
            {
                if (form.Name == "Exit_Form")
                {
                    OpenedForm = form;
                    FormOpen = true;
                }
            }
            if (FormOpen == true)
            {
                OpenedForm.Close();
                Exit_Form OpenForm = new Exit_Form();
                OpenForm.Show();
            }
            else
            {
                Exit_Form OpenForm = new Exit_Form();
                OpenForm.Show();
            }
        }

        private void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                FadeOut.Stop();    //if it is, we stop the timer
                Close();
                Cleaner_Form OpenForm = new Cleaner_Form();
                OpenForm.Show();
            }
            else
            {
                Opacity -= 0.05;
            }
        }

        private void fadeOut2(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                FadeOut2.Stop();    //if it is, we stop the timer
                Close();
                Detector_Form OpenForm = new Detector_Form();
                OpenForm.Show();
            }
            else
            {
                Opacity -= 0.05;
            }
        }

        private void fadeOut3(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                FadeOut3.Stop();    //if it is, we stop the timer
                Close();
                Application_Downloader_Form OpenForm = new Application_Downloader_Form();
                OpenForm.Show();
            }
            else
            {
                Opacity -= 0.05;
            }
        }

        private void CSGO_Cheat_Cleaner_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            FadeOut.Tick += new EventHandler(fadeOut);  //this calls the fade out function
            FadeOut.Interval = 2;
            FadeOut.Start();
        }

        private void CSGO_Cheat_Detector_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            FadeOut2.Tick += new EventHandler(fadeOut2);  //this calls the fade out function
            FadeOut2.Interval = 2;
            FadeOut2.Start();
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
                Rainbow_Text.Enabled = true;
            }
            else
            {
                Rainbow = true;
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
            FadeOut3.Tick += new EventHandler(fadeOut3);  //this calls the fade out function
            FadeOut3.Interval = 2;
            FadeOut3.Start();
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
