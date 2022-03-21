namespace The_Tic_Tac_Toe_Game
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.PvP = new IkarosControls.IkarosButton();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.BackToMM = new IkarosControls.IkarosButton();
            this.Language = new IkarosControls.IkarosButton();
            this.SelectTheme = new IkarosControls.IkarosButton();
            this.label3 = new System.Windows.Forms.Label();
            this.BackToSettings = new IkarosControls.IkarosButton();
            this.ToggleDefault = new IkarosControls.IkarosButton();
            this.ToggleDark = new IkarosControls.IkarosButton();
            this.GitHub = new System.Windows.Forms.PictureBox();
            this.VsCPU = new IkarosControls.IkarosButton();
            this.ExitToDesktop = new IkarosControls.IkarosButton();
            this.Confi = new IkarosControls.IkarosButton();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.ExitApp = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).BeginInit();
            this.MovePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(402, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Tic-Tac-Toe Game";
            // 
            // PvP
            // 
            this.PvP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.PvP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.PvP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.PvP.BorderRadius = 0;
            this.PvP.BorderSize = 0;
            this.PvP.FlatAppearance.BorderSize = 0;
            this.PvP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PvP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PvP.ForeColor = System.Drawing.Color.White;
            this.PvP.Location = new System.Drawing.Point(510, 183);
            this.PvP.Margin = new System.Windows.Forms.Padding(6);
            this.PvP.Name = "PvP";
            this.PvP.Size = new System.Drawing.Size(202, 48);
            this.PvP.TabIndex = 1;
            this.PvP.Text = "1v1";
            this.PvP.TextColor = System.Drawing.Color.White;
            this.PvP.UseVisualStyleBackColor = false;
            this.PvP.Click += new System.EventHandler(this.PvP_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(202)))), ((int)(((byte)(165)))));
            this.MenuPanel.Controls.Add(this.SettingsPanel);
            this.MenuPanel.Controls.Add(this.GitHub);
            this.MenuPanel.Controls.Add(this.VsCPU);
            this.MenuPanel.Controls.Add(this.ExitToDesktop);
            this.MenuPanel.Controls.Add(this.Confi);
            this.MenuPanel.Controls.Add(this.PvP);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Location = new System.Drawing.Point(0, 33);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1264, 648);
            this.MenuPanel.TabIndex = 2;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsPanel.Controls.Add(this.BackToMM);
            this.SettingsPanel.Controls.Add(this.Language);
            this.SettingsPanel.Controls.Add(this.SelectTheme);
            this.SettingsPanel.Controls.Add(this.label3);
            this.SettingsPanel.Controls.Add(this.BackToSettings);
            this.SettingsPanel.Controls.Add(this.ToggleDefault);
            this.SettingsPanel.Controls.Add(this.ToggleDark);
            this.SettingsPanel.Location = new System.Drawing.Point(1135, 172);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(45, 88);
            this.SettingsPanel.TabIndex = 7;
            this.SettingsPanel.Visible = false;
            // 
            // BackToMM
            // 
            this.BackToMM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.BackToMM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.BackToMM.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BackToMM.BorderRadius = 0;
            this.BackToMM.BorderSize = 0;
            this.BackToMM.FlatAppearance.BorderSize = 0;
            this.BackToMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BackToMM.ForeColor = System.Drawing.Color.White;
            this.BackToMM.Location = new System.Drawing.Point(511, 364);
            this.BackToMM.Name = "BackToMM";
            this.BackToMM.Size = new System.Drawing.Size(202, 48);
            this.BackToMM.TabIndex = 3;
            this.BackToMM.Text = "Back";
            this.BackToMM.TextColor = System.Drawing.Color.White;
            this.BackToMM.UseVisualStyleBackColor = false;
            this.BackToMM.Click += new System.EventHandler(this.BackToMM_Click);
            // 
            // Language
            // 
            this.Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.Language.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.Language.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Language.BorderRadius = 0;
            this.Language.BorderSize = 0;
            this.Language.FlatAppearance.BorderSize = 0;
            this.Language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Language.ForeColor = System.Drawing.Color.White;
            this.Language.Location = new System.Drawing.Point(510, 175);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(202, 48);
            this.Language.TabIndex = 2;
            this.Language.Text = "Language";
            this.Language.TextColor = System.Drawing.Color.White;
            this.Language.UseVisualStyleBackColor = false;
            // 
            // SelectTheme
            // 
            this.SelectTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.SelectTheme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.SelectTheme.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SelectTheme.BorderRadius = 0;
            this.SelectTheme.BorderSize = 0;
            this.SelectTheme.FlatAppearance.BorderSize = 0;
            this.SelectTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SelectTheme.ForeColor = System.Drawing.Color.White;
            this.SelectTheme.Location = new System.Drawing.Point(510, 104);
            this.SelectTheme.Name = "SelectTheme";
            this.SelectTheme.Size = new System.Drawing.Size(202, 48);
            this.SelectTheme.TabIndex = 1;
            this.SelectTheme.Text = "Theme";
            this.SelectTheme.TextColor = System.Drawing.Color.White;
            this.SelectTheme.UseVisualStyleBackColor = false;
            this.SelectTheme.Click += new System.EventHandler(this.SelectTheme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(538, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Settings";
            // 
            // BackToSettings
            // 
            this.BackToSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.BackToSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.BackToSettings.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BackToSettings.BorderRadius = 0;
            this.BackToSettings.BorderSize = 0;
            this.BackToSettings.FlatAppearance.BorderSize = 0;
            this.BackToSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BackToSettings.ForeColor = System.Drawing.Color.White;
            this.BackToSettings.Location = new System.Drawing.Point(511, 364);
            this.BackToSettings.Name = "BackToSettings";
            this.BackToSettings.Size = new System.Drawing.Size(202, 48);
            this.BackToSettings.TabIndex = 6;
            this.BackToSettings.Text = "Back";
            this.BackToSettings.TextColor = System.Drawing.Color.White;
            this.BackToSettings.UseVisualStyleBackColor = false;
            this.BackToSettings.Visible = false;
            this.BackToSettings.Click += new System.EventHandler(this.BackToSettings_Click);
            // 
            // ToggleDefault
            // 
            this.ToggleDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ToggleDefault.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ToggleDefault.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ToggleDefault.BorderRadius = 0;
            this.ToggleDefault.BorderSize = 0;
            this.ToggleDefault.FlatAppearance.BorderSize = 0;
            this.ToggleDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ToggleDefault.ForeColor = System.Drawing.Color.White;
            this.ToggleDefault.Location = new System.Drawing.Point(511, 103);
            this.ToggleDefault.Name = "ToggleDefault";
            this.ToggleDefault.Size = new System.Drawing.Size(202, 48);
            this.ToggleDefault.TabIndex = 5;
            this.ToggleDefault.Text = "Default";
            this.ToggleDefault.TextColor = System.Drawing.Color.White;
            this.ToggleDefault.UseVisualStyleBackColor = false;
            this.ToggleDefault.Visible = false;
            this.ToggleDefault.Click += new System.EventHandler(this.ToggleDefault_Click);
            // 
            // ToggleDark
            // 
            this.ToggleDark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ToggleDark.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ToggleDark.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ToggleDark.BorderRadius = 0;
            this.ToggleDark.BorderSize = 0;
            this.ToggleDark.FlatAppearance.BorderSize = 0;
            this.ToggleDark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleDark.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ToggleDark.ForeColor = System.Drawing.Color.White;
            this.ToggleDark.Location = new System.Drawing.Point(511, 175);
            this.ToggleDark.Name = "ToggleDark";
            this.ToggleDark.Size = new System.Drawing.Size(202, 48);
            this.ToggleDark.TabIndex = 4;
            this.ToggleDark.Text = "Dark";
            this.ToggleDark.TextColor = System.Drawing.Color.White;
            this.ToggleDark.UseVisualStyleBackColor = false;
            this.ToggleDark.Visible = false;
            this.ToggleDark.Click += new System.EventHandler(this.ToggleDark_Click);
            // 
            // GitHub
            // 
            this.GitHub.Image = global::The_Tic_Tac_Toe_Game.Properties.Resources.Github;
            this.GitHub.Location = new System.Drawing.Point(22, 571);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(69, 56);
            this.GitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GitHub.TabIndex = 6;
            this.GitHub.TabStop = false;
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            this.GitHub.MouseEnter += new System.EventHandler(this.GitHub_MouseEnter);
            this.GitHub.MouseLeave += new System.EventHandler(this.GitHub_MouseLeave);
            // 
            // VsCPU
            // 
            this.VsCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.VsCPU.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.VsCPU.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.VsCPU.BorderRadius = 0;
            this.VsCPU.BorderSize = 0;
            this.VsCPU.FlatAppearance.BorderSize = 0;
            this.VsCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VsCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VsCPU.ForeColor = System.Drawing.Color.White;
            this.VsCPU.Location = new System.Drawing.Point(510, 259);
            this.VsCPU.Margin = new System.Windows.Forms.Padding(6);
            this.VsCPU.Name = "VsCPU";
            this.VsCPU.Size = new System.Drawing.Size(202, 48);
            this.VsCPU.TabIndex = 5;
            this.VsCPU.Text = "Vs CPU";
            this.VsCPU.TextColor = System.Drawing.Color.White;
            this.VsCPU.UseVisualStyleBackColor = false;
            this.VsCPU.Click += new System.EventHandler(this.VsCPU_Click);
            // 
            // ExitToDesktop
            // 
            this.ExitToDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ExitToDesktop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ExitToDesktop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ExitToDesktop.BorderRadius = 0;
            this.ExitToDesktop.BorderSize = 0;
            this.ExitToDesktop.FlatAppearance.BorderSize = 0;
            this.ExitToDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitToDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToDesktop.ForeColor = System.Drawing.Color.White;
            this.ExitToDesktop.Location = new System.Drawing.Point(510, 389);
            this.ExitToDesktop.Margin = new System.Windows.Forms.Padding(6);
            this.ExitToDesktop.Name = "ExitToDesktop";
            this.ExitToDesktop.Size = new System.Drawing.Size(202, 48);
            this.ExitToDesktop.TabIndex = 4;
            this.ExitToDesktop.Text = "Exit";
            this.ExitToDesktop.TextColor = System.Drawing.Color.White;
            this.ExitToDesktop.UseVisualStyleBackColor = false;
            this.ExitToDesktop.Click += new System.EventHandler(this.ExitToDesktop_Click);
            // 
            // Confi
            // 
            this.Confi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.Confi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.Confi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Confi.BorderRadius = 0;
            this.Confi.BorderSize = 0;
            this.Confi.FlatAppearance.BorderSize = 0;
            this.Confi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.Confi.ForeColor = System.Drawing.Color.White;
            this.Confi.Location = new System.Drawing.Point(510, 104);
            this.Confi.Margin = new System.Windows.Forms.Padding(6);
            this.Confi.Name = "Confi";
            this.Confi.Size = new System.Drawing.Size(202, 48);
            this.Confi.TabIndex = 2;
            this.Confi.Text = "Settings";
            this.Confi.TextColor = System.Drawing.Color.White;
            this.Confi.UseVisualStyleBackColor = false;
            this.Confi.Click += new System.EventHandler(this.Settings_Click);
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.MovePanel.Controls.Add(this.ExitApp);
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(1264, 35);
            this.MovePanel.TabIndex = 3;
            this.MovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseDown);
            // 
            // ExitApp
            // 
            this.ExitApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitApp.Image = global::The_Tic_Tac_Toe_Game.Properties.Resources.Exit_Icon;
            this.ExitApp.Location = new System.Drawing.Point(1227, 5);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(25, 25);
            this.ExitApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitApp.TabIndex = 0;
            this.ExitApp.TabStop = false;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            this.ExitApp.MouseEnter += new System.EventHandler(this.ExitApp_MouseEnter);
            this.ExitApp.MouseLeave += new System.EventHandler(this.ExitApp_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).EndInit();
            this.MovePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private IkarosControls.IkarosButton PvP;
        private System.Windows.Forms.Panel MenuPanel;
        private IkarosControls.IkarosButton Confi;
        private System.Windows.Forms.PictureBox ExitApp;
        public System.Windows.Forms.Panel MovePanel;
        private IkarosControls.IkarosButton ExitToDesktop;
        private System.Windows.Forms.PictureBox GitHub;
        private IkarosControls.IkarosButton VsCPU;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label label3;
        private IkarosControls.IkarosButton SelectTheme;
        private IkarosControls.IkarosButton BackToMM;
        private IkarosControls.IkarosButton Language;
        private IkarosControls.IkarosButton ToggleDefault;
        private IkarosControls.IkarosButton ToggleDark;
        private IkarosControls.IkarosButton BackToSettings;
    }
}

