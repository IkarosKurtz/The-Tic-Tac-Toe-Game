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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.PvP = new IkarosControls.IkarosButton();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Confi = new IkarosControls.IkarosButton();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.ExitApp = new System.Windows.Forms.PictureBox();
            this.RenderColor = new System.Windows.Forms.Timer(this.components);
            this.MenuPanel.SuspendLayout();
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
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Controls.Add(this.Confi);
            this.MenuPanel.Controls.Add(this.PvP);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Location = new System.Drawing.Point(0, 33);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1264, 648);
            this.MenuPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
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
            this.ExitApp.Image = global::The_Tic_Tac_Toe_Game.Properties.Resources.exit_icon_icons_com_70975;
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
            // RenderColor
            // 
            this.RenderColor.Tick += new System.EventHandler(this.RenderColor_Tick);
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
            this.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
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
        public System.Windows.Forms.Timer RenderColor;
        private System.Windows.Forms.Label label2;
    }
}

