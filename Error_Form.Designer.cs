
namespace CSGO_Cheat_Cleaner_Detector
{
    partial class Error_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error_Form));
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Wrong_Pass_Label = new System.Windows.Forms.Label();
            this.Try_Again = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Background_Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Clock1 = new System.Windows.Forms.Label();
            this.Drag_Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.RainbowDisableEnable = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.RainbowText = new System.Windows.Forms.Label();
            this.RainbowText2 = new System.Windows.Forms.Label();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Clock1Timer = new System.Windows.Forms.Timer(this.components);
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormDrag2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Rainbow_Text = new System.Windows.Forms.Timer(this.components);
            this.FormDrag3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormDrag5 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Background_Panel.SuspendLayout();
            this.Drag_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormSettings
            // 
            this.FormSettings.AnimationInterval = 1000;
            this.FormSettings.BorderRadius = 40;
            this.FormSettings.ContainerControl = this;
            this.FormSettings.DragStartTransparencyValue = 0.1D;
            this.FormSettings.HasFormShadow = false;
            // 
            // Wrong_Pass_Label
            // 
            this.Wrong_Pass_Label.AutoSize = true;
            this.Wrong_Pass_Label.BackColor = System.Drawing.Color.Transparent;
            this.Wrong_Pass_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wrong_Pass_Label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wrong_Pass_Label.ForeColor = System.Drawing.Color.White;
            this.Wrong_Pass_Label.Location = new System.Drawing.Point(63, 72);
            this.Wrong_Pass_Label.Name = "Wrong_Pass_Label";
            this.Wrong_Pass_Label.Size = new System.Drawing.Size(228, 24);
            this.Wrong_Pass_Label.TabIndex = 6;
            this.Wrong_Pass_Label.Text = "Password is incorrect";
            // 
            // Try_Again
            // 
            this.Try_Again.AutoRoundedCorners = true;
            this.Try_Again.BackColor = System.Drawing.Color.Transparent;
            this.Try_Again.BorderRadius = 23;
            this.Try_Again.CheckedState.Parent = this.Try_Again;
            this.Try_Again.CustomImages.Parent = this.Try_Again;
            this.Try_Again.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Try_Again.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Try_Again.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Try_Again.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Try_Again.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Try_Again.DisabledState.Parent = this.Try_Again;
            this.Try_Again.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.Try_Again.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Try_Again.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Try_Again.ForeColor = System.Drawing.Color.White;
            this.Try_Again.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Try_Again.HoverState.Parent = this.Try_Again;
            this.Try_Again.Location = new System.Drawing.Point(78, 110);
            this.Try_Again.Name = "Try_Again";
            this.Try_Again.ShadowDecoration.Parent = this.Try_Again;
            this.Try_Again.Size = new System.Drawing.Size(193, 48);
            this.Try_Again.TabIndex = 5;
            this.Try_Again.Text = "Try Again";
            this.Try_Again.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Try_Again_MouseDown);
            // 
            // Background_Panel
            // 
            this.Background_Panel.Controls.Add(this.Clock1);
            this.Background_Panel.Controls.Add(this.Wrong_Pass_Label);
            this.Background_Panel.Controls.Add(this.Try_Again);
            this.Background_Panel.Controls.Add(this.Drag_Panel);
            this.Background_Panel.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.Background_Panel.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Background_Panel.Location = new System.Drawing.Point(0, 0);
            this.Background_Panel.Name = "Background_Panel";
            this.Background_Panel.ShadowDecoration.Parent = this.Background_Panel;
            this.Background_Panel.Size = new System.Drawing.Size(353, 184);
            this.Background_Panel.TabIndex = 3;
            // 
            // Clock1
            // 
            this.Clock1.BackColor = System.Drawing.Color.Transparent;
            this.Clock1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Clock1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clock1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock1.ForeColor = System.Drawing.Color.White;
            this.Clock1.Location = new System.Drawing.Point(0, 160);
            this.Clock1.Name = "Clock1";
            this.Clock1.Size = new System.Drawing.Size(353, 24);
            this.Clock1.TabIndex = 7;
            this.Clock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Drag_Panel
            // 
            this.Drag_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Drag_Panel.BorderRadius = 20;
            this.Drag_Panel.Controls.Add(this.RainbowDisableEnable);
            this.Drag_Panel.Controls.Add(this.RainbowText);
            this.Drag_Panel.Controls.Add(this.RainbowText2);
            this.Drag_Panel.Controls.Add(this.FormNameLabel);
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
            this.Drag_Panel.Size = new System.Drawing.Size(353, 58);
            this.Drag_Panel.TabIndex = 0;
            // 
            // RainbowDisableEnable
            // 
            this.RainbowDisableEnable.BackColor = System.Drawing.Color.Transparent;
            this.RainbowDisableEnable.CheckedState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.RainbowDisableEnable.CheckedState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.RainbowDisableEnable.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RainbowDisableEnable.CheckedState.InnerColor = System.Drawing.Color.MediumSlateBlue;
            this.RainbowDisableEnable.CheckedState.Parent = this.RainbowDisableEnable;
            this.RainbowDisableEnable.Location = new System.Drawing.Point(159, 20);
            this.RainbowDisableEnable.Name = "RainbowDisableEnable";
            this.RainbowDisableEnable.ShadowDecoration.Parent = this.RainbowDisableEnable;
            this.RainbowDisableEnable.Size = new System.Drawing.Size(35, 20);
            this.RainbowDisableEnable.TabIndex = 22;
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
            // RainbowText
            // 
            this.RainbowText.AutoSize = true;
            this.RainbowText.BackColor = System.Drawing.Color.Transparent;
            this.RainbowText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RainbowText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RainbowText.ForeColor = System.Drawing.Color.White;
            this.RainbowText.Location = new System.Drawing.Point(132, 3);
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
            this.RainbowText2.Location = new System.Drawing.Point(133, 42);
            this.RainbowText2.Name = "RainbowText2";
            this.RainbowText2.Size = new System.Drawing.Size(87, 14);
            this.RainbowText2.TabIndex = 21;
            this.RainbowText2.Text = "Rainbow Texts";
            this.RainbowText2.Visible = false;
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNameLabel.ForeColor = System.Drawing.Color.White;
            this.FormNameLabel.Location = new System.Drawing.Point(9, 17);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(61, 24);
            this.FormNameLabel.TabIndex = 2;
            this.FormNameLabel.Text = "Error";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(309, 14);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(34, 34);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseDown);
            // 
            // Clock1Timer
            // 
            this.Clock1Timer.Interval = 1000;
            this.Clock1Timer.Tick += new System.EventHandler(this.Clock1Timer_Tick);
            // 
            // FormDrag
            // 
            this.FormDrag.DragEndTransparencyValue = 0.9D;
            this.FormDrag.DragStartTransparencyValue = 0.5D;
            this.FormDrag.TargetControl = this.Background_Panel;
            this.FormDrag.TransparentWhileDrag = true;
            this.FormDrag.UseTransparentDrag = true;
            // 
            // FormDrag2
            // 
            this.FormDrag2.DragEndTransparencyValue = 0.9D;
            this.FormDrag2.DragStartTransparencyValue = 0.5D;
            this.FormDrag2.TargetControl = this.Drag_Panel;
            this.FormDrag2.TransparentWhileDrag = true;
            this.FormDrag2.UseTransparentDrag = true;
            // 
            // Rainbow_Text
            // 
            this.Rainbow_Text.Interval = 2;
            this.Rainbow_Text.Tick += new System.EventHandler(this.Rainbow_Text_Tick);
            // 
            // FormDrag3
            // 
            this.FormDrag3.DragEndTransparencyValue = 0.9D;
            this.FormDrag3.DragStartTransparencyValue = 0.5D;
            this.FormDrag3.TargetControl = this.FormNameLabel;
            this.FormDrag3.TransparentWhileDrag = true;
            this.FormDrag3.UseTransparentDrag = true;
            // 
            // FormDrag5
            // 
            this.FormDrag5.DragEndTransparencyValue = 0.9D;
            this.FormDrag5.DragStartTransparencyValue = 0.5D;
            this.FormDrag5.TargetControl = this.Clock1;
            this.FormDrag5.TransparentWhileDrag = true;
            this.FormDrag5.UseTransparentDrag = true;
            // 
            // Error_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 184);
            this.Controls.Add(this.Background_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Error_Form";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error_Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Load);
            this.Background_Panel.ResumeLayout(false);
            this.Background_Panel.PerformLayout();
            this.Drag_Panel.ResumeLayout(false);
            this.Drag_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2GradientPanel Background_Panel;
        private System.Windows.Forms.Label Clock1;
        private System.Windows.Forms.Label Wrong_Pass_Label;
        private Guna.UI2.WinForms.Guna2GradientButton Try_Again;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Drag_Panel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Timer Clock1Timer;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag2;
        private System.Windows.Forms.Timer Rainbow_Text;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag3;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag5;
        private System.Windows.Forms.Label RainbowText;
        private System.Windows.Forms.Label RainbowText2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch RainbowDisableEnable;
    }
}