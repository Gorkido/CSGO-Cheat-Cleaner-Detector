
namespace CSGO_Cheat_Cleaner_Detector
{
    partial class Login_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.FormDrag5 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Clock1 = new System.Windows.Forms.Label();
            this.FormDrag3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.Rainbow_Text = new System.Windows.Forms.Timer(this.components);
            this.FormDrag2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Drag_Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Minimize = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Background_Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.RainbowText = new System.Windows.Forms.Label();
            this.RainbowText2 = new System.Windows.Forms.Label();
            this.RainbowDisableEnable = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Clock1Timer = new System.Windows.Forms.Timer(this.components);
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.TextBoxElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.GitHub = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Website = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Discord = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ClosedEye = new Guna.UI2.WinForms.Guna2PictureBox();
            this.OpenedEye = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Drag_Panel.SuspendLayout();
            this.Background_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Website)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenedEye)).BeginInit();
            this.SuspendLayout();
            // 
            // FormDrag5
            // 
            this.FormDrag5.DragEndTransparencyValue = 0.9D;
            this.FormDrag5.DragStartTransparencyValue = 0.5D;
            this.FormDrag5.TargetControl = this.Clock1;
            this.FormDrag5.TransparentWhileDrag = true;
            this.FormDrag5.UseTransparentDrag = true;
            // 
            // Clock1
            // 
            this.Clock1.BackColor = System.Drawing.Color.Transparent;
            this.Clock1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Clock1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clock1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock1.ForeColor = System.Drawing.Color.White;
            this.Clock1.Location = new System.Drawing.Point(0, 198);
            this.Clock1.Name = "Clock1";
            this.Clock1.Size = new System.Drawing.Size(514, 29);
            this.Clock1.TabIndex = 8;
            this.Clock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDrag3
            // 
            this.FormDrag3.DragEndTransparencyValue = 0.9D;
            this.FormDrag3.DragStartTransparencyValue = 0.5D;
            this.FormDrag3.TargetControl = this.FormNameLabel;
            this.FormDrag3.TransparentWhileDrag = true;
            this.FormDrag3.UseTransparentDrag = true;
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNameLabel.ForeColor = System.Drawing.Color.White;
            this.FormNameLabel.Location = new System.Drawing.Point(9, 17);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(422, 24);
            this.FormNameLabel.TabIndex = 2;
            this.FormNameLabel.Text = "Gorkido\'s Cheat Cleaner / Detector Login";
            // 
            // Rainbow_Text
            // 
            this.Rainbow_Text.Interval = 2;
            this.Rainbow_Text.Tick += new System.EventHandler(this.Rainbow_Text_Tick);
            // 
            // FormDrag2
            // 
            this.FormDrag2.DragEndTransparencyValue = 0.9D;
            this.FormDrag2.DragStartTransparencyValue = 0.5D;
            this.FormDrag2.TargetControl = this.Drag_Panel;
            this.FormDrag2.TransparentWhileDrag = true;
            this.FormDrag2.UseTransparentDrag = true;
            // 
            // Drag_Panel
            // 
            this.Drag_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Drag_Panel.BorderRadius = 20;
            this.Drag_Panel.Controls.Add(this.FormNameLabel);
            this.Drag_Panel.Controls.Add(this.Minimize);
            this.Drag_Panel.Controls.Add(this.Exit);
            this.Drag_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Drag_Panel.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.Drag_Panel.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Drag_Panel.FillColor3 = System.Drawing.Color.MediumSlateBlue;
            this.Drag_Panel.FillColor4 = System.Drawing.SystemColors.ActiveCaption;
            this.Drag_Panel.Location = new System.Drawing.Point(0, 0);
            this.Drag_Panel.Name = "Drag_Panel";
            this.Drag_Panel.Quality = 100;
            this.Drag_Panel.ShadowDecoration.Depth = 2;
            this.Drag_Panel.ShadowDecoration.Enabled = true;
            this.Drag_Panel.ShadowDecoration.Parent = this.Drag_Panel;
            this.Drag_Panel.Size = new System.Drawing.Size(514, 58);
            this.Drag_Panel.TabIndex = 0;
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(436, 13);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(27, 19);
            this.Minimize.TabIndex = 1;
            this.Minimize.Text = "__";
            this.Minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseDown);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(472, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(34, 34);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseDown);
            // 
            // FormDrag
            // 
            this.FormDrag.DragEndTransparencyValue = 0.9D;
            this.FormDrag.DragStartTransparencyValue = 0.5D;
            this.FormDrag.TargetControl = this.Background_Panel;
            this.FormDrag.TransparentWhileDrag = true;
            this.FormDrag.UseTransparentDrag = true;
            // 
            // Background_Panel
            // 
            this.Background_Panel.Controls.Add(this.GitHub);
            this.Background_Panel.Controls.Add(this.Website);
            this.Background_Panel.Controls.Add(this.Discord);
            this.Background_Panel.Controls.Add(this.RainbowText);
            this.Background_Panel.Controls.Add(this.RainbowText2);
            this.Background_Panel.Controls.Add(this.RainbowDisableEnable);
            this.Background_Panel.Controls.Add(this.Clock1);
            this.Background_Panel.Controls.Add(this.Login);
            this.Background_Panel.Controls.Add(this.Drag_Panel);
            this.Background_Panel.Controls.Add(this.ClosedEye);
            this.Background_Panel.Controls.Add(this.OpenedEye);
            this.Background_Panel.Controls.Add(this.Password);
            this.Background_Panel.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.Background_Panel.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Background_Panel.Location = new System.Drawing.Point(-1, 0);
            this.Background_Panel.Name = "Background_Panel";
            this.Background_Panel.ShadowDecoration.Parent = this.Background_Panel;
            this.Background_Panel.Size = new System.Drawing.Size(514, 227);
            this.Background_Panel.TabIndex = 3;
            // 
            // RainbowText
            // 
            this.RainbowText.AutoSize = true;
            this.RainbowText.BackColor = System.Drawing.Color.Transparent;
            this.RainbowText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RainbowText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RainbowText.ForeColor = System.Drawing.Color.White;
            this.RainbowText.Location = new System.Drawing.Point(145, 70);
            this.RainbowText.Name = "RainbowText";
            this.RainbowText.Size = new System.Drawing.Size(92, 14);
            this.RainbowText.TabIndex = 20;
            this.RainbowText.Text = "Disable / Enable";
            this.RainbowText.Visible = false;
            // 
            // RainbowText2
            // 
            this.RainbowText2.AutoSize = true;
            this.RainbowText2.BackColor = System.Drawing.Color.Transparent;
            this.RainbowText2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RainbowText2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RainbowText2.ForeColor = System.Drawing.Color.White;
            this.RainbowText2.Location = new System.Drawing.Point(276, 70);
            this.RainbowText2.Name = "RainbowText2";
            this.RainbowText2.Size = new System.Drawing.Size(87, 14);
            this.RainbowText2.TabIndex = 21;
            this.RainbowText2.Text = "Rainbow Texts";
            this.RainbowText2.Visible = false;
            // 
            // RainbowDisableEnable
            // 
            this.RainbowDisableEnable.BackColor = System.Drawing.Color.Transparent;
            this.RainbowDisableEnable.CheckedState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.RainbowDisableEnable.CheckedState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.RainbowDisableEnable.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RainbowDisableEnable.CheckedState.InnerColor = System.Drawing.Color.MediumSlateBlue;
            this.RainbowDisableEnable.CheckedState.Parent = this.RainbowDisableEnable;
            this.RainbowDisableEnable.Location = new System.Drawing.Point(238, 67);
            this.RainbowDisableEnable.Name = "RainbowDisableEnable";
            this.RainbowDisableEnable.ShadowDecoration.Parent = this.RainbowDisableEnable;
            this.RainbowDisableEnable.Size = new System.Drawing.Size(35, 20);
            this.RainbowDisableEnable.TabIndex = 11;
            this.RainbowDisableEnable.Tag = "";
            this.RainbowDisableEnable.UncheckedState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.RainbowDisableEnable.UncheckedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.RainbowDisableEnable.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RainbowDisableEnable.UncheckedState.InnerColor = System.Drawing.SystemColors.ActiveCaption;
            this.RainbowDisableEnable.UncheckedState.Parent = this.RainbowDisableEnable;
            this.RainbowDisableEnable.CheckedChanged += new System.EventHandler(this.RainbowDisableEnable_CheckedChanged);
            this.RainbowDisableEnable.MouseEnter += new System.EventHandler(this.RainbowDisableEnable_MouseEnter);
            this.RainbowDisableEnable.MouseLeave += new System.EventHandler(this.RainbowDisableEnable_MouseLeave);
            // 
            // Login
            // 
            this.Login.AutoRoundedCorners = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.BorderRadius = 23;
            this.Login.CheckedState.Parent = this.Login;
            this.Login.CustomImages.Parent = this.Login;
            this.Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login.DisabledState.Parent = this.Login;
            this.Login.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.Login.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Login.HoverState.Parent = this.Login;
            this.Login.Location = new System.Drawing.Point(149, 148);
            this.Login.Name = "Login";
            this.Login.ShadowDecoration.Parent = this.Login;
            this.Login.Size = new System.Drawing.Size(212, 48);
            this.Login.TabIndex = 7;
            this.Login.Text = "Login";
            this.Login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Password.BorderRadius = 22;
            this.Password.BorderThickness = 2;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.Parent = this.Password;
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Password.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.Password.FocusedState.Parent = this.Password;
            this.Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Password.HoverState.Parent = this.Password;
            this.Password.Location = new System.Drawing.Point(59, 93);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.PlaceholderText = "";
            this.Password.SelectedText = "";
            this.Password.ShadowDecoration.Parent = this.Password;
            this.Password.Size = new System.Drawing.Size(388, 46);
            this.Password.TabIndex = 10;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Clock1Timer
            // 
            this.Clock1Timer.Enabled = true;
            this.Clock1Timer.Interval = 1000;
            this.Clock1Timer.Tick += new System.EventHandler(this.Clock1Timer_Tick);
            // 
            // FormSettings
            // 
            this.FormSettings.AnimationInterval = 1000;
            this.FormSettings.BorderRadius = 40;
            this.FormSettings.ContainerControl = this;
            this.FormSettings.DragEndTransparencyValue = 0.9D;
            this.FormSettings.DragStartTransparencyValue = 0.5D;
            this.FormSettings.HasFormShadow = false;
            // 
            // TextBoxElipse
            // 
            this.TextBoxElipse.BorderRadius = 40;
            this.TextBoxElipse.TargetControl = this.Password;
            // 
            // GitHub
            // 
            this.GitHub.BackColor = System.Drawing.Color.Transparent;
            this.GitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHub.Image = global::CSGO_Cheat_Cleaner_Detector.Properties.Resources.github;
            this.GitHub.ImageRotate = 0F;
            this.GitHub.Location = new System.Drawing.Point(81, 192);
            this.GitHub.Name = "GitHub";
            this.GitHub.ShadowDecoration.Parent = this.GitHub;
            this.GitHub.Size = new System.Drawing.Size(30, 30);
            this.GitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GitHub.TabIndex = 28;
            this.GitHub.TabStop = false;
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // Website
            // 
            this.Website.BackColor = System.Drawing.Color.Transparent;
            this.Website.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Website.Image = global::CSGO_Cheat_Cleaner_Detector.Properties.Resources.website;
            this.Website.ImageRotate = 0F;
            this.Website.Location = new System.Drawing.Point(7, 192);
            this.Website.Name = "Website";
            this.Website.ShadowDecoration.Parent = this.Website;
            this.Website.Size = new System.Drawing.Size(30, 30);
            this.Website.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Website.TabIndex = 27;
            this.Website.TabStop = false;
            this.Website.Click += new System.EventHandler(this.Website_Click);
            // 
            // Discord
            // 
            this.Discord.BackColor = System.Drawing.Color.Transparent;
            this.Discord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Discord.Image = global::CSGO_Cheat_Cleaner_Detector.Properties.Resources.discord;
            this.Discord.ImageRotate = 0F;
            this.Discord.Location = new System.Drawing.Point(42, 192);
            this.Discord.Name = "Discord";
            this.Discord.ShadowDecoration.Parent = this.Discord;
            this.Discord.Size = new System.Drawing.Size(30, 30);
            this.Discord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Discord.TabIndex = 26;
            this.Discord.TabStop = false;
            this.Discord.Click += new System.EventHandler(this.Discord_Click);
            // 
            // ClosedEye
            // 
            this.ClosedEye.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClosedEye.Image = global::CSGO_Cheat_Cleaner_Detector.Properties.Resources.Closed;
            this.ClosedEye.ImageRotate = 0F;
            this.ClosedEye.Location = new System.Drawing.Point(407, 103);
            this.ClosedEye.Name = "ClosedEye";
            this.ClosedEye.ShadowDecoration.Parent = this.ClosedEye;
            this.ClosedEye.Size = new System.Drawing.Size(30, 30);
            this.ClosedEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosedEye.TabIndex = 24;
            this.ClosedEye.TabStop = false;
            this.ClosedEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClosedEye_MouseDown);
            // 
            // OpenedEye
            // 
            this.OpenedEye.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenedEye.Image = global::CSGO_Cheat_Cleaner_Detector.Properties.Resources.Opened_Eye;
            this.OpenedEye.ImageRotate = 0F;
            this.OpenedEye.Location = new System.Drawing.Point(407, 109);
            this.OpenedEye.Name = "OpenedEye";
            this.OpenedEye.ShadowDecoration.Parent = this.OpenedEye;
            this.OpenedEye.Size = new System.Drawing.Size(28, 15);
            this.OpenedEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OpenedEye.TabIndex = 25;
            this.OpenedEye.TabStop = false;
            this.OpenedEye.Visible = false;
            this.OpenedEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OpenedEye_MouseDown);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 227);
            this.Controls.Add(this.Background_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login_Form";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Load);
            this.Drag_Panel.ResumeLayout(false);
            this.Drag_Panel.PerformLayout();
            this.Background_Panel.ResumeLayout(false);
            this.Background_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Website)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenedEye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl FormDrag5;
        private System.Windows.Forms.Label Clock1;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag3;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.Timer Rainbow_Text;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Drag_Panel;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Exit;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2GradientPanel Background_Panel;
        private Guna.UI2.WinForms.Guna2GradientButton Login;
        private System.Windows.Forms.Timer Clock1Timer;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2Elipse TextBoxElipse;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2ToggleSwitch RainbowDisableEnable;
        private System.Windows.Forms.Label RainbowText;
        private System.Windows.Forms.Label RainbowText2;
        private Guna.UI2.WinForms.Guna2PictureBox OpenedEye;
        private Guna.UI2.WinForms.Guna2PictureBox ClosedEye;
        private Guna.UI2.WinForms.Guna2PictureBox Discord;
        private Guna.UI2.WinForms.Guna2PictureBox Website;
        private Guna.UI2.WinForms.Guna2PictureBox GitHub;
    }
}