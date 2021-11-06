using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.ServiceProcess;
using System.Windows.Forms;

namespace CSGO_Cheat_Cleaner_Detector
{
    public partial class Detector_Form : System.Windows.Forms.Form
    {
        public Detector_Form()
        {
            InitializeComponent();
        }

        // Form Design
        private int r = 0, g = 210, b = 0;
        private bool Rainbow;
        private readonly Timer FadeIn = new Timer();
        private readonly FilePaths FileLocation = new FilePaths();
        private readonly string PrefetchLoc = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + "\\Windows\\Prefetch"; // Prefetch

        private void Rainbow_Text_Tick(object sender, EventArgs e)
        {
            FormNameLabel.ForeColor = Color.FromArgb(r, g, b);
            Find.ForeColor = Color.FromArgb(r, g, b);
            CheatLog.ForeColor = Color.FromArgb(r, g, b);
            CheatLog2.ForeColor = Color.FromArgb(r, g, b);
            Exit.ForeColor = Color.FromArgb(r, g, b);
            Clock1.ForeColor = Color.FromArgb(r, g, b);
            RainbowText.ForeColor = Color.FromArgb(r, g, b);
            RainbowText2.ForeColor = Color.FromArgb(r, g, b);
            Recent.ForeColor = Color.FromArgb(r, g, b);
            CSGOFolder.ForeColor = Color.FromArgb(r, g, b);
            Appdata.ForeColor = Color.FromArgb(r, g, b);
            Prefetch.ForeColor = Color.FromArgb(r, g, b);
            Documents.ForeColor = Color.FromArgb(r, g, b);
            C_Disk.ForeColor = Color.FromArgb(r, g, b);
            ProgramFilesX86.ForeColor = Color.FromArgb(r, g, b);
            ProgramFiles.ForeColor = Color.FromArgb(r, g, b);
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

        private void PrefetchFinder()
        {
            try
            {
                string Prefetch = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + "\\Windows\\Prefetch\\"; // Prefetch";
                DirectoryInfo d = new DirectoryInfo(Prefetch);

                FileInfo[] Files = d.GetFiles("*.pf"); //Getting pf files

                foreach (FileInfo file in Files)
                {
                    string str = Prefetch + "" + file.Name;
                    File.Copy(str, str.Remove(str.Length - 12), true);
                    File.Delete(str);
                }
            }
            catch (Exception ex)
            {
                CheatLog.Items.Add(ex.Message);
            }
        }

        private void Find_MouseDown(object sender, MouseEventArgs e)
        {
            CheatLog.Items.Clear();
            if (Directory.Exists(PrefetchLoc))
            {
                PrefetchFinder();
            }
            else
            {
                CheatLog2.Items.Add(Prefetch + " " + "Cannot Be Found");
            }


            foreach (string dir in FileLocation.Cheats)
            {
                if (Directory.Exists(dir))
                {
                    try
                    {
                        Process.Start(dir);
                        CheatLog.Items.Add("Cheat Found: " + dir);
                    }
                    catch (Exception ex)
                    {
                        CheatLog.Items.Add(ex.Message);
                        // ignore errors
                    }
                }
                else
                {
                    CheatLog2.Items.Add("Directory" + dir + " " + "Cannot Be Found");
                }
            }

            foreach (string file in FileLocation.Cheats2)
            {
                if (File.Exists(file))
                {
                    try
                    {
                        Process.Start(PrefetchLoc);
                        CheatLog.Items.Add("Cheat Found: " + file);
                    }
                    catch (Exception ex)
                    {
                        CheatLog.Items.Add(ex.Message);
                        // ignore errors
                    }
                }
                else
                {
                    CheatLog2.Items.Add("Directory" + file + " " + "Cannot Be Found");
                }
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

                Find.ForeColor = Color.White;
                CheatLog.ForeColor = Color.White;
                CheatLog2.ForeColor = Color.White;
                RainbowText.ForeColor = Color.White;
                RainbowText2.ForeColor = Color.White;
                FormNameLabel.ForeColor = Color.White;
                Minimize.ForeColor = Color.White;
                Exit.ForeColor = Color.White;
                Recent.ForeColor = Color.White;
                CSGOFolder.ForeColor = Color.White;
                Prefetch.ForeColor = Color.White;
                Appdata.ForeColor = Color.White;
                ProgramFiles.ForeColor = Color.White;
                ProgramFilesX86.ForeColor = Color.White;
                Documents.ForeColor = Color.White;
                C_Disk.ForeColor = Color.White;
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

        private void Appdata_MouseDown(object sender, MouseEventArgs e)
        {
            // Folder Location
            string Appdata = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata"; // Appdata\\local
            // Folder Location
            if (Directory.Exists(Appdata))
            {
                Process.Start(Appdata);
            }
            else
            {
                MessageBox.Show("Appdata Folder Cannot Be Found", "CSGO Cheat Detector");
            }
        }

        private void Recent_MouseDown(object sender, MouseEventArgs e)
        {
            // Folder Location
            string Recent = Environment.GetFolderPath(Environment.SpecialFolder.Recent); // Recent
            // Folder Location
            if (Directory.Exists(Recent))
            {
                Process.Start(Recent);
            }
            else
            {
                MessageBox.Show("Recent Folder Cannot Be Found", "CSGO Cheat Detector");
            }
        }

        private void IfHigherThanWin10()
        {
            OperatingSystem os = Environment.OSVersion;
            try
            {
                ServiceController[] services = ServiceController.GetServices();
                foreach (ServiceController service in services)
                {
                    string SysMain = service.ServiceName = "SysMain";
                    SysMain = SysMain + " = " + service.Status;
                    SysMainStatus.Text = SysMain;
                }
                if (SysMainStatus.Text == "SysMain = Stopped")
                {
                    MessageBox.Show("SysMain Service is disabled", "CSGO Cheat Detector");
                }
                else
                {
                    MessageBox.Show("Prefetch Folder Cannot Be Found", "CSGO Cheat Detector");
                }
            }
            catch (Exception ex)
            {
                CheatLog.Items.Add(ex.Message);
            }
        }

        private void IfLowerThanWin8()
        {
            OperatingSystem os = Environment.OSVersion;
            try
            {
                ServiceController[] services = ServiceController.GetServices();
                foreach (ServiceController service in services)
                {
                    string Superfetch = service.DisplayName = "Superfetch";
                    Superfetch = Superfetch + " = " + service.Status;
                    SuperfetchService.Text = Superfetch;
                }
                if (SuperfetchService.Text == "Superfetch = Stopped")
                {
                    MessageBox.Show("Superfetch Service is disabled", "CSGO Cheat Detector");
                }
                else
                {
                    MessageBox.Show("Prefetch Folder Cannot Be Found", "CSGO Cheat Detector");
                }
            }
            catch (Exception ex)
            {
                CheatLog.Items.Add(ex.Message);
            }
        }

        private void Prefetch_MouseDown(object sender, MouseEventArgs e)
        {
            // Folder Location
            string Prefetch = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + "\\Windows\\Prefetch"; // Prefetch
            // Folder Location
            OperatingSystem os = Environment.OSVersion;
            if (Directory.Exists(Prefetch))
            {
                Process.Start(Prefetch);
            }
            else
            {
                if (os.Version.Major >= 7)
                {
                    IfHigherThanWin10();
                }
                else
                {
                    IfLowerThanWin8();
                }

            }
        }

        private void CSGOFolder_MouseDown(object sender, MouseEventArgs e)
        {
            // Folder Location
            string CSGO = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + "\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive"; // CSGO's Folder
            // Folder Location
            if (Directory.Exists(CSGO))
            {
                Process.Start(CSGO);
            }
            else
            {
                MessageBox.Show("CSGO Installation Folder Cannot Be Found", "CSGO Cheat Detector");
            }
        }

        private void C_Disk_MouseDown(object sender, MouseEventArgs e)
        {
            // Folder Location
            string Disk = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + "\\"; // Main Disk
            // Folder Location
            if (Directory.Exists(Disk))
            {
                Process.Start(Disk);
            }
            else
            {
                MessageBox.Show("C Disk Folder Cannot Be Found", "CSGO Cheat Detector");
            }
        }

        private void Documents_MouseDown(object sender, MouseEventArgs e)
        {
            // Folder Location
            string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Documents
            // Folder Location
            if (Directory.Exists(Documents))
            {
                Process.Start(Documents);
            }
            else
            {
                MessageBox.Show("Documents Folder Cannot Be Found", "CSGO Cheat Detector");
            }
        }

        private void ProgramFilesX86_MouseDown(object sender, MouseEventArgs e)
        {
            // Folder Location
            string ProgramFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            // Folder Location
            if (Directory.Exists(ProgramFilesX86))
            {
                Process.Start(ProgramFilesX86);
            }
            else
            {
                MessageBox.Show("Program Files (X86) Folder Cannot Be Found", "CSGO Cheat Detector");
            }
        }

        private void ProgramFiles_MouseDown(object sender, MouseEventArgs e)
        {
            // Folder Location
            string ProgramFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            // Folder Location
            if (Directory.Exists(ProgramFiles))
            {
                Process.Start(ProgramFiles);
            }
            else
            {
                MessageBox.Show("Program Files (X86) Folder Cannot Be Found", "CSGO Cheat Detector");
            }
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
