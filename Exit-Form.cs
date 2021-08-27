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

        private void Rainbow_Text_Tick(object sender, EventArgs e)
        {
            FormNameLabel.ForeColor = Color.FromArgb(r, g, b);
            Exit.ForeColor = Color.FromArgb(r, g, b);
            Are_You_Sure.ForeColor = Color.FromArgb(r, g, b);
            Clock1.ForeColor = Color.FromArgb(r, g, b);
            Exit_App.ForeColor = Color.FromArgb(r, g, b);
            Cancel.ForeColor = Color.FromArgb(r, g, b);
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
            Hide();
        }

        private void Cancel_MouseDown(object sender, MouseEventArgs e)
        {
            Clock1Timer.Enabled = false;
            Hide();
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
            Hide();
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

        private void Minimize_MouseDown(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Clock1.Text = DateTime.Now.ToString("HH:mm:ss tt");
            Clock1Timer.Enabled = true;
        }
    }
}
