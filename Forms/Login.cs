using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSGO_Cheat_Cleaner_Detector
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        // Form Design
        private int r = 0, g = 210, b = 0;
        private bool Rainbow;
        private readonly Timer FadeIn = new Timer();
        private readonly Timer FadeOut = new Timer();
        private readonly Timer FadeOut2 = new Timer();

        private void Rainbow_Text_Tick(object sender, EventArgs e)
        {
            FormNameLabel.ForeColor = Color.FromArgb(r, g, b);
            Password.ForeColor = Color.FromArgb(r, g, b);
            RainbowText.ForeColor = Color.FromArgb(r, g, b);
            RainbowText2.ForeColor = Color.FromArgb(r, g, b);
            Exit.ForeColor = Color.FromArgb(r, g, b);
            Login.ForeColor = Color.FromArgb(r, g, b);
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

        private void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                FadeOut.Stop();    //if it is, we stop the timer
                Application.Exit();   //and we try to close the form
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
                FadeOut.Stop();    //if it is, we stop the timer
                Hide();
                Login_Information OpenForm = new Login_Information();
                OpenForm.Show();
            }
            else
            {
                Opacity -= 0.05;
            }
        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            FadeOut.Tick += new EventHandler(fadeOut);  //this calls the fade out function
            FadeOut.Interval = 2;
            FadeOut.Start();
            Clock1Timer.Enabled = false;
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

                Login.ForeColor = Color.White;
                RainbowText.ForeColor = Color.White;
                RainbowText2.ForeColor = Color.White;
                FormNameLabel.ForeColor = Color.White;
                Minimize.ForeColor = Color.White;
                Exit.ForeColor = Color.White;
                Password.ForeColor = Color.White;
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

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            /*string URL = ""; // No more password
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();*/ // No more password
            string Pass = "Gorkido";
            if (Password.Text == "")
            {
                Password.UseSystemPasswordChar = false;
                Password.Text = "                    This field cannot be empty";
                wait(2000);
                Password.UseSystemPasswordChar = true;
                Password.Text = "";
            }
            else
            {
                if (Password.Text == Pass)
                {
                    FadeOut.Tick += new EventHandler(fadeOut2);  //this calls the fade out function
                    FadeOut.Interval = 2;
                    FadeOut.Start();
                }
                else
                {
                    Error_Form OpenForm = new Error_Form();
                    OpenForm.Show();
                    Hide();
                }
            }
            /*response.Close();
            readStream.Close();
            }*/
        }

        private void Minimize_MouseDown(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void OpenedEye_MouseDown(object sender, MouseEventArgs e)
        {
            OpenedEye.Hide();
            Password.UseSystemPasswordChar = true;
            ClosedEye.Show();
        }

        private void ClosedEye_MouseDown(object sender, MouseEventArgs e)
        {
            OpenedEye.Show();
            Password.UseSystemPasswordChar = false;
            ClosedEye.Hide();
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
