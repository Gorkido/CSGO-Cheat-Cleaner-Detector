using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CSGO_Cheat_Cleaner_Detector
{
    public partial class Cleaner_Form : Form
    {
        public Cleaner_Form()
        {
            InitializeComponent();
        }

        private bool Rainbow;
        private readonly System.Windows.Forms.Timer FadeIn = new System.Windows.Forms.Timer();
        private readonly string Recent = Environment.GetFolderPath(Environment.SpecialFolder.Recent); // Recent
        private readonly string Prefetch = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + "\\Windows\\Prefetch"; // Prefetch
        private readonly string Temp = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Temp"; // Temp
        private readonly string Temp2 = Path.GetTempPath(); // %Temp%
        private readonly FilePaths FileLocation = new FilePaths();
        private int r = 0, g = 210, b = 0;

        // Clearing folder's content (\\)
        private void ClearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                try
                {
                    fi.Delete();
                    CleanLog.Items.Add("File deleted: " + fi.FullName);
                }
                catch (Exception) { } // Ignore all exceptions
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                ClearFolder(di.FullName);
                try
                {
                    di.Delete();
                    CleanLog.Items.Add("Folder deleted: " + di.FullName);
                }
                catch (Exception) { } // Ignore all exceptions
            }
        }
        // Clearing folder's content (\\)

        // Deleting folder (FolderName)
        private void DeleteFolder(string FolderName)
        {
            try
            {
                if (Directory.Exists(FolderName))
                {
                    Directory.Delete(FolderName);
                    CleanLog.Items.Add("'" + FolderName + "'" + " " + "is found and deleted!");
                }
                else
                {
                    CleanLog.Items.Add(FolderName + " " + "is not found.");
                }
            }
            catch (Exception ex)
            {
                ErrorLog.Items.Add(ex.Message);
            }
        }
        // Deleting folder (FolderName)

        public void Wait(int milliseconds)
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
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        // Form Design

        private void Rainbow_Text_Tick(object sender, EventArgs e)
        {
            FormNameLabel.ForeColor = Color.FromArgb(r, g, b);
            Clean.ForeColor = Color.FromArgb(r, g, b);
            CleanLog.ForeColor = Color.FromArgb(r, g, b);
            ErrorLog.ForeColor = Color.FromArgb(r, g, b);
            Exit.ForeColor = Color.FromArgb(r, g, b);
            Clock1.ForeColor = Color.FromArgb(r, g, b);
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

        private void Clean_MouseDown(object sender, MouseEventArgs e)
        {
            CleanLog.Items.Clear();

            foreach (string dir in FileLocation.Cheats)
            {
                if (Directory.Exists(dir))
                {
                    try
                    {
                        DeleteFolder(dir);
                        CleanLog.Items.Add("Folder deleted: " + dir);
                    }
                    catch (Exception ex) { ErrorLog.Items.Add(ex.Message); } // Ignore all exceptions
                }
                else
                {
                    ErrorLog.Items.Add("Cheat Cannot Be Found: " + dir);
                }
            }

            foreach (string dir in FileLocation.Temporary)
            {
                if (Directory.Exists(dir))
                {
                    try
                    {
                        CleanLog.Items.Add("Folder cleared: " + Temp2);
                        ClearFolder(dir);
                        CleanLog.Items.Add("Folder cleared: " + dir);
                    }
                    catch (Exception ex) { ErrorLog.Items.Add(ex.Message); } // Ignore all exceptions
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

                Clean.ForeColor = Color.White;
                CleanLog.ForeColor = Color.White;
                ErrorLog.ForeColor = Color.White;
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
            string sPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Opacity = 0;      //first the opacity is 0
            FadeIn.Interval = 2;  //we'll increase the opacity every 10ms
            FadeIn.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity
            FadeIn.Start();
        }
    }
}