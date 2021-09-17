using System;
using System.Collections.Generic;
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

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            IEnumerable<Process> EverythingProcess = Process.GetProcesses().
            Where(pr => pr.ProcessName == "Everything-1.4.1.1009.x64-Setup");
            foreach (Process process in EverythingProcess)
            {
                process.Kill();
            }
            Clock1Timer.Enabled = false;
            Close();
            string sPath = Path.GetTempPath(); //getting temp's path
            string dir2 = @"\Gorkido_App_Downloader\Gorkido_Downloads";
            if (Directory.Exists(sPath + dir2))
            {
                Directory.Delete(sPath + dir2, true);// Deleting %temp%\Gorkido_Stuff\Gorkido_Downloads
            }
            Start OpenForm = new Start();
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
                Everything.ForeColor = Color.White;
                Click.ForeColor = Color.White;
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
            RainbowText2.Show();
        }

        private void RainbowDisableEnable_MouseLeave(object sender, EventArgs e)
        {
            RainbowText.Hide();
            RainbowText2.Hide();
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
                        webClient.DownloadFile("https://download1648.mediafire.com/7d3cokjl2mgg/qy17pw47objmdf5/Everything-1.4.1.1009.x64-Setup.exe", (sPath + dir + @"\Everything-1.4.1.1009.x64-Setup.exe"));
                        if (MessageBox.Show("Do you want to install Everything Application?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Process.Start((sPath + dir + @"\Everything-1.4.1.1009.x64-Setup.exe"));// If user clicks "yes" then it will open "Everything-1.4.1.1009.x64-Setup.exe".
                        }
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
                        webClient.DownloadFile("https://download849.mediafire.com/jyp3uxuflaug/g7yy3tiqjdpi39k/Everything-1.4.1.1009.x86-Setup.exe", (sPath + dir + @"\Everything-1.4.1.1009.x86-Setup.exe"));
                        if (MessageBox.Show("Do you want to install Everything Application?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Process.Start((sPath + dir + @"\Everything-1.4.1.1009.x86-Setup.exe"));// If user clicks "yes" then it will open "Everything-1.4.1.1009.x86-Setup.exe".
                        }
                    }
                }
            }
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
