namespace The_Tic_Tac_Toe_Game
{
    partial class Board
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
            this.BackToMM = new IkarosControls.IkarosButton();
            this.Restart = new IkarosControls.IkarosButton();
            this.Winner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToMM
            // 
            this.BackToMM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(202)))), ((int)(((byte)(165)))));
            this.BackToMM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(202)))), ((int)(((byte)(165)))));
            this.BackToMM.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BackToMM.BorderRadius = 0;
            this.BackToMM.BorderSize = 0;
            this.BackToMM.FlatAppearance.BorderSize = 0;
            this.BackToMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMM.Font = new System.Drawing.Font("Gabato", 19F);
            this.BackToMM.ForeColor = System.Drawing.Color.White;
            this.BackToMM.Location = new System.Drawing.Point(1027, 22);
            this.BackToMM.Name = "BackToMM";
            this.BackToMM.Size = new System.Drawing.Size(202, 48);
            this.BackToMM.TabIndex = 0;
            this.BackToMM.Text = "Main Menu";
            this.BackToMM.TextColor = System.Drawing.Color.White;
            this.BackToMM.UseVisualStyleBackColor = false;
            this.BackToMM.Click += new System.EventHandler(this.BackToMM_Click);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(202)))), ((int)(((byte)(165)))));
            this.Restart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(202)))), ((int)(((byte)(165)))));
            this.Restart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Restart.BorderRadius = 0;
            this.Restart.BorderSize = 0;
            this.Restart.FlatAppearance.BorderSize = 0;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Gabato", 19F);
            this.Restart.ForeColor = System.Drawing.Color.White;
            this.Restart.Location = new System.Drawing.Point(1027, 111);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(202, 48);
            this.Restart.TabIndex = 1;
            this.Restart.Text = "Restart";
            this.Restart.TextColor = System.Drawing.Color.White;
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Winner
            // 
            this.Winner.AutoSize = true;
            this.Winner.BackColor = System.Drawing.Color.Transparent;
            this.Winner.Font = new System.Drawing.Font("Gabato", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner.ForeColor = System.Drawing.Color.White;
            this.Winner.Location = new System.Drawing.Point(240, 256);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(397, 100);
            this.Winner.TabIndex = 2;
            this.Winner.Text = "Winner";
            this.Winner.Visible = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.BackToMM);
            this.Font = new System.Drawing.Font("Gabato", 24F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.Name = "Board";
            this.Text = "Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IkarosControls.IkarosButton BackToMM;
        private IkarosControls.IkarosButton Restart;
        private System.Windows.Forms.Label Winner;
    }
}