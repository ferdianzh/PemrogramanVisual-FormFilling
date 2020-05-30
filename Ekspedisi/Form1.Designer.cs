namespace Ekspedisi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserControl = new MetroFramework.Controls.MetroUserControl();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.keluarButton = new MetroFramework.Controls.MetroButton();
            this.pengirimanButton = new MetroFramework.Controls.MetroButton();
            this.profilButton = new MetroFramework.Controls.MetroButton();
            this.homeButton = new MetroFramework.Controls.MetroButton();
            this.ucProfil1 = new Ekspedisi.ucProfil();
            this.ucHome1 = new Ekspedisi.ucHome();
            this.ucPengiriman1 = new Ekspedisi.ucPengiriman();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserControl
            // 
            this.UserControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserControl.Location = new System.Drawing.Point(181, 60);
            this.UserControl.Name = "UserControl";
            this.UserControl.Size = new System.Drawing.Size(699, 436);
            this.UserControl.TabIndex = 1;
            this.UserControl.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Brown;
            this.metroPanel1.Controls.Add(this.keluarButton);
            this.metroPanel1.Controls.Add(this.pengirimanButton);
            this.metroPanel1.Controls.Add(this.profilButton);
            this.metroPanel1.Controls.Add(this.homeButton);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(155, 436);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // keluarButton
            // 
            this.keluarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.keluarButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.keluarButton.ForeColor = System.Drawing.Color.Brown;
            this.keluarButton.Location = new System.Drawing.Point(-1, 332);
            this.keluarButton.Name = "keluarButton";
            this.keluarButton.Size = new System.Drawing.Size(146, 45);
            this.keluarButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.keluarButton.TabIndex = 5;
            this.keluarButton.Text = "Keluar";
            this.keluarButton.UseCustomBackColor = true;
            this.keluarButton.UseCustomForeColor = true;
            this.keluarButton.UseSelectable = true;
            this.keluarButton.UseStyleColors = true;
            this.keluarButton.Click += new System.EventHandler(this.keluarButton_Click);
            // 
            // pengirimanButton
            // 
            this.pengirimanButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.pengirimanButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pengirimanButton.Location = new System.Drawing.Point(-1, 205);
            this.pengirimanButton.Name = "pengirimanButton";
            this.pengirimanButton.Size = new System.Drawing.Size(146, 45);
            this.pengirimanButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.pengirimanButton.TabIndex = 4;
            this.pengirimanButton.Text = "Pengiriman";
            this.pengirimanButton.UseCustomBackColor = true;
            this.pengirimanButton.UseCustomForeColor = true;
            this.pengirimanButton.UseSelectable = true;
            this.pengirimanButton.UseStyleColors = true;
            this.pengirimanButton.Click += new System.EventHandler(this.pengirimanButton_Click);
            // 
            // profilButton
            // 
            this.profilButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.profilButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.profilButton.Location = new System.Drawing.Point(-1, 145);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(146, 45);
            this.profilButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.profilButton.TabIndex = 3;
            this.profilButton.Text = "Profil";
            this.profilButton.UseCustomBackColor = true;
            this.profilButton.UseCustomForeColor = true;
            this.profilButton.UseSelectable = true;
            this.profilButton.UseStyleColors = true;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeButton.Location = new System.Drawing.Point(-1, 85);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(146, 45);
            this.homeButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Home";
            this.homeButton.UseCustomBackColor = true;
            this.homeButton.UseCustomForeColor = true;
            this.homeButton.UseSelectable = true;
            this.homeButton.UseStyleColors = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // ucProfil1
            // 
            this.ucProfil1.Location = new System.Drawing.Point(181, 60);
            this.ucProfil1.Name = "ucProfil1";
            this.ucProfil1.Size = new System.Drawing.Size(699, 436);
            this.ucProfil1.TabIndex = 3;
            // 
            // ucHome1
            // 
            this.ucHome1.Location = new System.Drawing.Point(181, 60);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(699, 436);
            this.ucHome1.TabIndex = 2;
            // 
            // ucPengiriman1
            // 
            this.ucPengiriman1.Location = new System.Drawing.Point(181, 60);
            this.ucPengiriman1.Name = "ucPengiriman1";
            this.ucPengiriman1.Size = new System.Drawing.Size(699, 436);
            this.ucPengiriman1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Ekspedisi.Properties.Resources.icon;
            this.BackImagePadding = new System.Windows.Forms.Padding(150, 17, 0, 0);
            this.BackMaxSize = 31;
            this.ClientSize = new System.Drawing.Size(900, 516);
            this.Controls.Add(this.ucPengiriman1);
            this.Controls.Add(this.ucProfil1);
            this.Controls.Add(this.ucHome1);
            this.Controls.Add(this.UserControl);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Kat Express";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl UserControl;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton homeButton;
        private MetroFramework.Controls.MetroButton pengirimanButton;
        private MetroFramework.Controls.MetroButton profilButton;
        private MetroFramework.Controls.MetroButton keluarButton;
        private ucHome ucHome1;
        private ucProfil ucProfil1;
        private ucPengiriman ucPengiriman1;
    }
}

