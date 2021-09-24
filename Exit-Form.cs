using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CSGO_Cheat_Cleaner_Detector
{
    public partial class Exit_Form : System.Windows.Forms.Form
    {
        public Exit_Form()
        {
            InitializeComponent();
        }

        // Form Design
        private int r = 0, g = 210, b = 0;
        private bool Rainbow;
        private readonly System.Windows.Forms.Timer FadeIn = new System.Windows.Forms.Timer();

        private void Rainbow_Text_Tick(object sender, EventArgs e)
        {
            FormNameLabel.ForeColor = Color.FromArgb(r, g, b);
            Exit.ForeColor = Color.FromArgb(r, g, b);
            Are_You_Sure.ForeColor = Color.FromArgb(r, g, b);
            Clock1.ForeColor = Color.FromArgb(r, g, b);
            Exit_App.ForeColor = Color.FromArgb(r, g, b);
            Cancel.ForeColor = Color.FromArgb(r, g, b);
            RainbowText.ForeColor = Color.FromArgb(r, g, b);
            RainbowText2.ForeColor = Color.FromArgb(r, g, b);
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

        private void Cancel_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Close();
        }

        // Executing .Bat file
        private static void ExecuteCommand(string command)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };

            Process process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("output>>" + e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("error>>" + e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            Console.WriteLine("ExitCode: {0}", process.ExitCode);
            process.Close();
        }
        // Executing .Bat file
        private void Exit_App_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Close();
            string sPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dir2 = @"\Cleaner.bat";
            ExecuteCommand(sPath + dir2);
            Thread.Sleep(1000);
            File.Delete(sPath + dir2);// Deleting Desktop\Cleaner
            Thread.Sleep(1000);
            Application.Exit();// Exit from the application.
        }

        private void Clock1Timer_Tick(object sender, EventArgs e)
        {
            Clock1.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Close();
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
                Exit_App.ForeColor = Color.White;
                RainbowText.ForeColor = Color.White;
                RainbowText2.ForeColor = Color.White;
                Cancel.ForeColor = Color.White;
                FormNameLabel.ForeColor = Color.White;
                Minimize.ForeColor = Color.White;
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
