﻿
namespace CSGO_Cheat_Cleaner_Detector
{
    partial class Cleaner_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cleaner_Form));
            this.CleanLog = new System.Windows.Forms.ListBox();
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Background_Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Clean = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Drag_Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormDrag2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Rainbow_Text = new System.Windows.Forms.Timer(this.components);
            this.FormDrag3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.CheatLogElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FormDrag4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Clock1 = new System.Windows.Forms.Label();
            this.Clock1Timer = new System.Windows.Forms.Timer(this.components);
            this.Background_Panel.SuspendLayout();
            this.Drag_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CleanLog
            // 
            this.CleanLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CleanLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CleanLog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanLog.ForeColor = System.Drawing.Color.White;
            this.CleanLog.FormattingEnabled = true;
            this.CleanLog.HorizontalScrollbar = true;
            this.CleanLog.ItemHeight = 19;
            this.CleanLog.Location = new System.Drawing.Point(45, 112);
            this.CleanLog.Name = "CleanLog";
            this.CleanLog.Size = new System.Drawing.Size(700, 285);
            this.CleanLog.TabIndex = 2;
            // 
            // FormSettings
            // 
            this.FormSettings.AnimationInterval = 1000;
            this.FormSettings.BorderRadius = 40;
            this.FormSettings.ContainerControl = this;
            this.FormSettings.DragStartTransparencyValue = 0.1D;
            this.FormSettings.HasFormShadow = false;
            // 
            // Background_Panel
            // 
            this.Background_Panel.Controls.Add(this.Clock1);
            this.Background_Panel.Controls.Add(this.Clean);
            this.Background_Panel.Controls.Add(this.CleanLog);
            this.Background_Panel.Controls.Add(this.Drag_Panel);
            this.Background_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background_Panel.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.Background_Panel.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Background_Panel.Location = new System.Drawing.Point(0, 0);
            this.Background_Panel.Name = "Background_Panel";
            this.Background_Panel.ShadowDecoration.Parent = this.Background_Panel;
            this.Background_Panel.Size = new System.Drawing.Size(800, 450);
            this.Background_Panel.TabIndex = 1;
            // 
            // Clean
            // 
            this.Clean.AutoRoundedCorners = true;
            this.Clean.BackColor = System.Drawing.Color.Transparent;
            this.Clean.BorderRadius = 23;
            this.Clean.CheckedState.Parent = this.Clean;
            this.Clean.CustomImages.Parent = this.Clean;
            this.Clean.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Clean.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Clean.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clean.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clean.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Clean.DisabledState.Parent = this.Clean;
            this.Clean.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.Clean.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Clean.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clean.ForeColor = System.Drawing.Color.White;
            this.Clean.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Clean.HoverState.Parent = this.Clean;
            this.Clean.Location = new System.Drawing.Point(299, 61);
            this.Clean.Name = "Clean";
            this.Clean.ShadowDecoration.Parent = this.Clean;
            this.Clean.Size = new System.Drawing.Size(212, 48);
            this.Clean.TabIndex = 4;
            this.Clean.Text = "Clean";
            this.Clean.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clean_MouseDown);
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
            this.Drag_Panel.Size = new System.Drawing.Size(800, 58);
            this.Drag_Panel.TabIndex = 0;
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNameLabel.ForeColor = System.Drawing.Color.White;
            this.FormNameLabel.Location = new System.Drawing.Point(9, 17);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(255, 24);
            this.FormNameLabel.TabIndex = 2;
            this.FormNameLabel.Text = "Gorkido\'s Cheat Cleaner";
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(693, 14);
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
            this.Exit.Location = new System.Drawing.Point(755, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(34, 34);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseDown);
            // 
            // FormDrag
            // 
            this.FormDrag.TargetControl = this.Background_Panel;
            // 
            // FormDrag2
            // 
            this.FormDrag2.TargetControl = this.Drag_Panel;
            // 
            // Rainbow_Text
            // 
            this.Rainbow_Text.Enabled = true;
            this.Rainbow_Text.Interval = 2;
            this.Rainbow_Text.Tick += new System.EventHandler(this.Rainbow_Text_Tick);
            // 
            // FormDrag3
            // 
            this.FormDrag3.TargetControl = this.FormNameLabel;
            // 
            // CheatLogElipse
            // 
            this.CheatLogElipse.BorderRadius = 40;
            this.CheatLogElipse.TargetControl = this.CleanLog;
            // 
            // FormDrag4
            // 
            this.FormDrag4.TargetControl = this.CleanLog;
            // 
            // Clock1
            // 
            this.Clock1.BackColor = System.Drawing.Color.Transparent;
            this.Clock1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Clock1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clock1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock1.ForeColor = System.Drawing.Color.White;
            this.Clock1.Location = new System.Drawing.Point(0, 398);
            this.Clock1.Name = "Clock1";
            this.Clock1.Size = new System.Drawing.Size(800, 52);
            this.Clock1.TabIndex = 5;
            this.Clock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clock1Timer
            // 
            this.Clock1Timer.Interval = 1000;
            this.Clock1Timer.Tick += new System.EventHandler(this.Clock1Timer_Tick);
            // 
            // Cleaner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Background_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cleaner_Form";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cleaner_Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Background_Panel.ResumeLayout(false);
            this.Drag_Panel.ResumeLayout(false);
            this.Drag_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CleanLog;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2GradientPanel Background_Panel;
        private Guna.UI2.WinForms.Guna2GradientButton Clean;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Drag_Panel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Exit;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag2;
        private System.Windows.Forms.Timer Rainbow_Text;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag3;
        private Guna.UI2.WinForms.Guna2Elipse CheatLogElipse;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag4;
        private System.Windows.Forms.Label Clock1;
        private System.Windows.Forms.Timer Clock1Timer;
    }
}