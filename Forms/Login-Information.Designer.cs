
namespace CSGO_Cheat_Cleaner_Detector
{
    partial class Login_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Information));
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormSettings = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.GIF = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Successful = new System.Windows.Forms.Label();
            this.FormDrag2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).BeginInit();
            this.SuspendLayout();
            // 
            // FormDrag
            // 
            this.FormDrag.DragEndTransparencyValue = 0.9D;
            this.FormDrag.DragStartTransparencyValue = 0.5D;
            this.FormDrag.TargetControl = this.GIF;
            this.FormDrag.TransparentWhileDrag = true;
            this.FormDrag.UseTransparentDrag = true;
            // 
            // FormSettings
            // 
            this.FormSettings.AnimationInterval = 1000;
            this.FormSettings.BorderRadius = 200;
            this.FormSettings.ContainerControl = this;
            this.FormSettings.DragStartTransparencyValue = 0.1D;
            this.FormSettings.HasFormShadow = false;
            this.FormSettings.ResizeForm = false;
            // 
            // GIF
            // 
            this.GIF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GIF.FillColor = System.Drawing.Color.Transparent;
            this.GIF.Image = ((System.Drawing.Image)(resources.GetObject("GIF.Image")));
            this.GIF.ImageRotate = 0F;
            this.GIF.Location = new System.Drawing.Point(0, 0);
            this.GIF.Name = "GIF";
            this.GIF.ShadowDecoration.Parent = this.GIF;
            this.GIF.Size = new System.Drawing.Size(187, 195);
            this.GIF.TabIndex = 9;
            this.GIF.TabStop = false;
            this.GIF.UseWaitCursor = true;
            // 
            // Successful
            // 
            this.Successful.AutoSize = true;
            this.Successful.BackColor = System.Drawing.Color.Transparent;
            this.Successful.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Successful.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Successful.ForeColor = System.Drawing.Color.White;
            this.Successful.Location = new System.Drawing.Point(5, 86);
            this.Successful.Name = "Successful";
            this.Successful.Size = new System.Drawing.Size(176, 22);
            this.Successful.TabIndex = 11;
            this.Successful.Text = "Login Successful!";
            this.Successful.UseWaitCursor = true;
            // 
            // FormDrag2
            // 
            this.FormDrag2.DragEndTransparencyValue = 0.9D;
            this.FormDrag2.DragStartTransparencyValue = 0.5D;
            this.FormDrag2.TargetControl = this.Successful;
            this.FormDrag2.TransparentWhileDrag = true;
            this.FormDrag2.UseTransparentDrag = true;
            // 
            // Login_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 195);
            this.Controls.Add(this.Successful);
            this.Controls.Add(this.GIF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login_Information";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Information";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormSettings;
        private Guna.UI2.WinForms.Guna2PictureBox GIF;
        private System.Windows.Forms.Label Successful;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag2;
    }
}