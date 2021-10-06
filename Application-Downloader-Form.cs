using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace CSGO_Cheat_Cleaner_Detector
{
    public partial class Application_Downloader_Form : Form
    {
        public Application_Downloader_Form()
        {
            InitializeComponent();
        }
        // Form Design
        private int r = 0, g = 210, b = 0;
        private bool Rainbow;
        private readonly WebClient webClient = new WebClient();
        private readonly Timer FadeIn = new Timer();
        private readonly Timer FadeOut = new Timer();
        private readonly Stopwatch sw = new Stopwatch();

        private void Rainbow_Text_Tick(object sender, EventArgs e)
        {
            FormNameLabel.ForeColor = Color.FromArgb(r, g, b);
            Everything.ForeColor = Color.FromArgb(r, g, b);
            Click.ForeColor = Color.FromArgb(r, g, b);
            RainbowText.ForeColor = Color.FromArgb(r, g, b);
            RainbowText2.ForeColor = Color.FromArgb(r, g, b);
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

        private void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                FadeOut.Stop();    //if it is, we stop the time
                Start OpenForm = new Start();
                OpenForm.Show();
                Close();
            }
            else
            {
                Opacity -= 0.05;
            }
        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            IEnumerable<Process> EverythingProcessx64 = Process.GetProcesses().
            Where(pr => pr.ProcessName == "Everything-1.4.1.1009.x64-Setup");
            foreach (Process process in EverythingProcessx64)
            {
                process.Kill();
            }

            IEnumerable<Process> EverythingProcessx86 = Process.GetProcesses().
            Where(pr => pr.ProcessName == "Everything-1.4.1.1009.x86-Setup");
            foreach (Process process in EverythingProcessx86)
            {
                process.Kill();
            }
            Clock1Timer.Enabled = false;
            System.Threading.Thread.Sleep(500);
            FadeOut.Tick += new EventHandler(fadeOut);  //this calls the fade out function
            FadeOut.Interval = 2;
            FadeOut.Start();
            string sPath = Path.GetTempPath(); //getting temp's path
            string dir2 = @"\Gorkido_App_Downloader\Gorkido_Downloads";
            if (Directory.Exists(sPath + dir2))
            {
                Directory.Delete(sPath + dir2, true);// Deleting %temp%\Gorkido_Stuff\Gorkido_Downloads
            }
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

                Everything.ForeColor = Color.White;
                Click.ForeColor = Color.White;
                RainbowText.ForeColor = Color.White;
                RainbowText2.ForeColor = Color.White;
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

        private void Everything_MouseDown(object sender, MouseEventArgs e)
        {
            if (Environment.Is64BitOperatingSystem)
            {
                string dir = @"\Gorkido_App_Downloader\Gorkido_Downloads";
                string dir2 = @"\Gorkido_App_Downloader\Gorkido_Downloads\Everything-1.4.1.1009.x64-Setup.exe";
                string sPath = Path.GetTempPath(); //getting temp's path
                if (!Directory.Exists(sPath + dir))
                {
                    Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
                }
                if (File.Exists(sPath + dir2))
                {
                    if (MessageBox.Show("'Everything-1.4.1.1009.x64-Setup.exe' already exists. Do you want to install Everything Application?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Process.Start((sPath + dir + @"\Everything-1.4.1.1009.x64-Setup.exe"));// If user clicks "yes" then it will open "Everything-1.4.1.1009.x64-Setup.exe".
                    }
                }
                else
                {
                    {
                        webClient.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/895329334624124959/895329540849668136/Everything-1.4.1.1009.x64-Setup.exe"), (sPath + dir + @"\Everything-1.4.1.1009.x64-Setup.exe"));
                        wait(600);
                        ProgressBar.Show();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted64);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged64);
                    }
                }
            }
            else
            {
                string dir = @"\Gorkido_App_Downloader\Gorkido_Downloads";
                string dir2 = @"\Gorkido_App_Downloader\Gorkido_Downloads\Everything-1.4.1.1009.x86-Setup.exe";
                string sPath = Path.GetTempPath(); //getting temp's path
                if (!Directory.Exists(sPath + dir))
                {
                    Directory.CreateDirectory(sPath + dir); //if \Gorkido_Downloads doesn't exist it'll create the folder
                }
                if (File.Exists(sPath + dir2))
                {
                    if (MessageBox.Show("'Everything-1.4.1.1009.x86-Setup.exe' already exists. Do you want to install Everything Application?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Process.Start((sPath + dir + @"\Everything-1.4.1.1009.x86-Setup.exe"));// If user clicks "yes" then it will open "Everything-1.4.1.1009.x86-Setup.exe".
                    }
                }
                else
                {
                    {
                        webClient.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/895329334624124959/895329562974642176/Everything-1.4.1.1009.x86-Setup.exe"), (sPath + dir + @"\Everything-1.4.1.1009.x86-Setup.exe"));
                        wait(600);
                        ProgressBar.Show();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted86);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged86);
                    }
                }
            }
        }

        private void Minimize_MouseDown(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ProgressChanged64(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void DownloadCompleted64(object sender, AsyncCompletedEventArgs e)
        {
            string dir = @"\Gorkido_App_Downloader\Gorkido_Downloads";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (MessageBox.Show("Do you want to install Everything Application?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\Everything-1.4.1.1009.x64-Setup.exe"));// If user clicks "yes" then it will open "Everything-1.4.1.1009.x64-Setup.exe".
                ProgressBar.Hide();
            }
            else
            {
                ProgressBar.Hide();
            }
        }

        private void ProgressChanged86(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void DownloadCompleted86(object sender, AsyncCompletedEventArgs e)
        {
            string dir = @"\Gorkido_App_Downloader\Gorkido_Downloads";
            string sPath = Path.GetTempPath(); //getting temp's path
            if (MessageBox.Show("Do you want to install Everything Application?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start((sPath + dir + @"\Everything-1.4.1.1009.x86-Setup.exe"));// If user clicks "yes" then it will open "Everything-1.4.1.1009.x86-Setup.exe".
            }
            else
            {
                ProgressBar.Hide();
            }
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
