using System;
using System.Windows.Forms;

namespace CSGO_Cheat_Cleaner_Detector
{
    public partial class Login_Information : Form
    {
        public Login_Information()
        {
            InitializeComponent();
            Successful.Parent = GIF;
        }

        // Form Design
        private readonly Timer FadeIn = new Timer();
        private readonly Timer FadeOut = new Timer();

        public void wait(int milliseconds)
        {
            Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0)
            {
                return;
            }

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                FadeOut.Stop();    //if it is, we stop the time
                Close();
                Start OpenForm = new Start();
                OpenForm.Show();
            }
            else
            {
                Opacity -= 0.05;
            }
        }

        private void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 0.9)
            {
                FadeIn.Stop();   //this stops the timer if the form is completely displayed
                wait(1500);
                FadeOut.Tick += new EventHandler(fadeOut);  //this calls the fade out function
                FadeOut.Interval = 2;
                FadeOut.Start();
            }
            else
            {
                Opacity += 0.05;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0
            FadeIn.Interval = 2;  //we'll increase the opacity every 10ms
            FadeIn.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            FadeIn.Start();
        }
    }
}
