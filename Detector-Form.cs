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
                string Prefetch = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\Windows\Prefetch\"; // Prefetch";
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
            // Folder Locations
            string Temp = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\Temp"; // Temp
            string Temp2 = Path.GetTempPath(); // %Temp%
            string Appdata = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Appdata\local"; // Appdata\local
            string Appdata2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // %Appdata%
            string Appdata3 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Appdata\LocalLow"; // Appdata\LocalLow
            string Recent = Environment.GetFolderPath(Environment.SpecialFolder.Recent); // Recent
            string Prefetch = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\Windows\Prefetch"; // Prefetch
            string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Documents
            string Disk = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer); // Main Disk
            string ProgramFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string CSGO = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive"; // CSGO's Folder
            // Folder Locations

            // Cheats
            string[] Cheats = {
            Temp + @"\Osiris", Temp2 + @"Osiris", Appdata + @"\Osiris", Appdata2 + @"\Osiris", Appdata3 + @"\Osiris", Recent + @"\Osiris", Prefetch + @"\Osiris", Documents + @"\Osiris", Disk + @"\Osiris", ProgramFilesX86 + @"\Osiris", CSGO + @"\Osiris",
            Temp + @"\Nixware", Temp2 + @"Nixware", Appdata + @"\Nixware", Appdata2 + @"\Nixware", Appdata3 + @"\Nixware", Recent + @"\Nixware", Prefetch + @"\Nixware", Documents + @"\Nixware", Disk + @"\Nixware", ProgramFilesX86 + @"\Nixware", CSGO + @"\Nixware",
            Temp + @"\Aimfall", Temp2 + @"Aimfall", Appdata + @"\Aimfall", Appdata2 + @"\Aimfall", Appdata3 + @"\Aimfall", Recent + @"\Aimfall", Prefetch + @"\Aimfall", Documents + @"\Aimfall", Disk + @"\Aimfall", ProgramFilesX86 + @"\Aimfall", CSGO + @"\Aimfall",
            Temp + @"\GODWARE", Temp2 + @"GODWARE", Appdata + @"\GODWARE", Appdata2 + @"\GODWARE", Appdata3 + @"\GODWARE", Recent + @"\GODWARE", Prefetch + @"\GODWARE", Documents + @"\GODWARE", Disk + @"\GODWARE", ProgramFilesX86 + @"\GODWARE", CSGO + @"\GODWARE",
            Temp + @"\PPHUD V3", Temp2 + @"PPHUD V3", Appdata + @"\PPHUD V3", Appdata2 + @"\PPHUD V3", Appdata3 + @"\PPHUD V3", Recent + @"\PPHUD V3", Prefetch + @"\PPHUD V3", Documents + @"\PPHUD V3", Disk + @"\PPHUD V3", ProgramFilesX86 + @"\PPHUD V3", CSGO + @"\PPHUD V3",
            Temp + @"\Aurora-Project", Temp2 + @"Aurora-Project", Appdata + @"\Aurora-Project", Appdata2 + @"\Aurora-Project", Appdata3 + @"\Aurora-Project", Recent + @"\Aurora-Project", Prefetch + @"\Aurora-Project", Documents + @"\Aurora-Project", Disk + @"\Aurora-Project", ProgramFilesX86 + @"\Aurora-Project", CSGO + @"\Aurora-Project",
            Temp + @"\saphire", Temp2 + @"saphire", Appdata + @"\saphire", Appdata2 + @"\saphire", Appdata3 + @"\saphire", Recent + @"\saphire", Prefetch + @"\saphire", Documents + @"\saphire", Disk + @"\saphire", ProgramFilesX86 + @"\saphire", CSGO + @"\saphire",
            Temp + @"\ot", Temp2 + @"ot", Appdata + @"\ot", Appdata2 + @"\ot", Appdata3 + @"\ot", Recent + @"\ot", Prefetch + @"\ot", Documents + @"\ot", Disk + @"\ot", ProgramFilesX86 + @"\ot", CSGO + @"\ot",
            Temp + @"\otc", Temp2 + @"otc", Appdata + @"\otc", Appdata2 + @"\otc", Appdata3 + @"\otc", Recent + @"\otc", Prefetch + @"\otc", Documents + @"\otc", Disk + @"\otc", ProgramFilesX86 + @"\otc", CSGO + @"\otc",
            Temp + @"\YeahNot_CS", Temp2 + @"YeahNot_CS", Appdata + @"\YeahNot_CS", Appdata2 + @"\GODWARE", Appdata3 + @"\GODWARE", Recent + @"\YeahNot_CS", Prefetch + @"\YeahNot_CS", Documents + @"\YeahNot_CS", Disk + @"\YeahNot_CS", ProgramFilesX86 + @"\YeahNot_CS", CSGO + @"\YeahNot_CS",
            Temp + @"\BlazeHack", Temp2 + @"BlazeHack", Appdata + @"\BlazeHack", Appdata2 + @"\BlazeHack", Appdata3 + @"\BlazeHack", Recent + @"\BlazeHack", Prefetch + @"\BlazeHack", Documents + @"\BlazeHack", Disk + @"\BlazeHack", ProgramFilesX86 + @"\BlazeHack", CSGO + @"\BlazeHack",
            Temp + @"\Legendware", Temp2 + @"Legendware", Appdata + @"\Legendware", Appdata2 + @"\Legendware", Appdata3 + @"\Legendware", Recent + @"\Legendware", Prefetch + @"\Legendware", Documents + @"\Legendware", Disk + @"\Legendware", ProgramFilesX86 + @"\Legendware", CSGO + @"\Legendware",
            Temp + @"\weave", Temp2 + @"weave", Appdata + @"\weave", Appdata2 + @"\weave", Appdata3 + @"\weave", Recent + @"\weave", Prefetch + @"\weave", Documents + @"\weave", Disk + @"\weave", ProgramFilesX86 + @"\weave", CSGO + @"\weave",
            Temp + @"\Aimware", Temp2 + @"Aimware", Appdata + @"\Aimware", Appdata2 + @"\Aimware", Appdata3 + @"\Aimware", Recent + @"\Aimware", Prefetch + @"\Aimware", Documents + @"\Aimware", Disk + @"\Aimware", ProgramFilesX86 + @"\Aimware", CSGO + @"\Aimware",
            Temp + @"\fatality", Temp2 + @"fatality", Appdata + @"\fatality", Appdata2 + @"\fatality", Appdata3 + @"\fatality", Recent + @"\fatality", Prefetch + @"\fatality", Documents + @"\fatality", Disk + @"\fatality", ProgramFilesX86 + @"\fatality", CSGO + @"\fatality",
            Temp + @"\JustGlow", Temp2 + @"JustGlow", Appdata + @"\JustGlow", Appdata2 + @"\JustGlow", Appdata3 + @"\JustGlow", Recent + @"\JustGlow", Prefetch + @"\JustGlow", Documents + @"\JustGlow", Disk + @"\JustGlow", ProgramFilesX86 + @"\JustGlow", CSGO + @"\JustGlow",
            Temp + @"\rawetripp", Temp2 + @"rawetripp", Appdata + @"\rawetripp", Appdata2 + @"\rawetripp", Appdata3 + @"\rawetripp", Recent + @"\rawetripp", Prefetch + @"\rawetripp", Documents + @"\rawetripp", Disk + @"\rawetripp", ProgramFilesX86 + @"\rawetripp", CSGO + @"\rawetripp",
            Temp + @"\pdr", Temp2 + @"pdr", Appdata + @"\pdr", Appdata2 + @"\pdr", Appdata3 + @"\pdr", Recent + @"\pdr", Prefetch + @"\pdr", Documents + @"\pdr", Disk + @"\pdr", ProgramFilesX86 + @"\pdr", CSGO + @"\pdr",
            Temp + @"\LUCKERBY", Temp2 + @"LUCKERBY", Appdata + @"\LUCKERBY", Appdata2 + @"\LUCKERBY", Appdata3 + @"\LUCKERBY", Recent + @"\LUCKERBY", Prefetch + @"\LUCKERBY", Documents + @"\LUCKERBY", Disk + @"\LUCKERBY", ProgramFilesX86 + @"\LUCKERBY", CSGO + @"\LUCKERBY",
            Temp + @"\sensum", Temp2 + @"sensum", Appdata + @"\sensum", Appdata2 + @"\sensum", Appdata3 + @"\sensum", Recent + @"\sensum", Prefetch + @"\sensum", Documents + @"\sensum", Disk + @"\sensum", ProgramFilesX86 + @"\sensum", CSGO + @"\sensum",
            Temp + @"\Anubis", Temp2 + @"Anubis", Appdata + @"\Anubis", Appdata2 + @"\Anubis", Appdata3 + @"\Anubis", Recent + @"\Anubis", Prefetch + @"\Anubis", Documents + @"\Anubis", Disk + @"\Anubis", ProgramFilesX86 + @"\Anubis", CSGO + @"\Anubis",
            Temp + @"\Legithook", Temp2 + @"Legithook", Appdata + @"\Legithook", Appdata2 + @"\Legithook", Appdata3 + @"\Legithook", Recent + @"\Legithook", Prefetch + @"\Legithook", Documents + @"\Legithook", Disk + @"\Legithook", ProgramFilesX86 + @"\Legithook", CSGO + @"\Legithook",
            Temp + @"\sByteCSGONew", Temp2 + @"sByteCSGONew", Appdata + @"\sByteCSGONew", Appdata2 + @"\sByteCSGONew", Appdata3 + @"\sByteCSGONew", Recent + @"\sByteCSGONew", Prefetch + @"\sByteCSGONew", Documents + @"\sByteCSGONew", Disk + @"\sByteCSGONew", ProgramFilesX86 + @"\sByteCSGONew", CSGO + @"\sByteCSGONew",
            Temp + @"\R41N3W4R3", Temp2 + @"R41N3W4R3", Appdata + @"\R41N3W4R3", Appdata2 + @"\R41N3W4R3", Appdata3 + @"\R41N3W4R3", Recent + @"\R41N3W4R3", Prefetch + @"\R41N3W4R3", Documents + @"\R41N3W4R3", Disk + @"\R41N3W4R3", ProgramFilesX86 + @"\R41N3W4R3", CSGO + @"\R41N3W4R3"
            };
            // Cheats

            // Cheats2
            string[] Cheats2 = {
            Prefetch + @"\OSIRIS.DLL",Prefetch + @"\NIXWARE.DLL",Prefetch + @"\AIMFALL.DLL",Prefetch + @"\GODWARE.DLL",Prefetch + @"\PPHUD V3",Prefetch + @"\Aurora-Project",Prefetch + @"\saphire",Prefetch + @"\ot", Prefetch + @"\otc",Prefetch + @"\YeahNot_CS",Prefetch + @"\BlazeHack",Prefetch + @"\LEGENDWARE.DLL",Prefetch + @"\weave",Prefetch + @"\AIMWARE.DLL",Prefetch + @"\FATALITY.DLL",Prefetch + @"\JustGlow",Prefetch + @"\rawetripp",Prefetch + @"\pdr",Prefetch + @"\LUCKERBY",Prefetch + @"\sensum",Prefetch + @"\Anubis",Prefetch + @"\Legithook",Prefetch + @"\sByteCSGONew",Prefetch + @"\R41N3W4R3"
            };
            // Cheats2

            CheatLog.Items.Clear();
            if (Directory.Exists(Prefetch))
            {
                PrefetchFinder();
            }
            else
            {
                CheatLog2.Items.Add(Prefetch + " " + "Cannot Be Found");
            }


            foreach (string dir in Cheats)
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

            foreach (string file in Cheats2)
            {
                if (File.Exists(file))
                {
                    try
                    {
                        Process.Start(Prefetch);
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
            string Appdata = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Appdata"; // Appdata\local
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

        private void IfWin10()
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

        private void IfHigherThanWin8()
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
            string Prefetch = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\Windows\Prefetch"; // Prefetch
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
                    IfWin10();
                }
                else
                {
                    IfHigherThanWin8();
                }

            }
        }

        private void CSGOFolder_MouseDown(object sender, MouseEventArgs e)
        {
            // Folder Location
            string CSGO = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive"; // CSGO's Folder
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
            string Disk = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\"; // Main Disk
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

        private void Form_Load(object sender, EventArgs e)
        {
            Rainbow = true;
            Clock1.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
