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
            this.components = new System.ComponentModel.Container();
            this.BackToMM = new IkarosControls.IkarosButton();
            this.Restart = new IkarosControls.IkarosButton();
            this.FirstPlayerScore = new System.Windows.Forms.Label();
            this.FirstThink = new System.Windows.Forms.Label();
            this.SecondThink = new System.Windows.Forms.Label();
            this.SecondPlayerScore = new System.Windows.Forms.Label();
            this.ThinkAni = new System.Windows.Forms.Timer(this.components);
            this.Turn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Winner = new System.Windows.Forms.Label();
            this.CPUTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Turn)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.BackToMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
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
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
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
            // FirstPlayerScore
            // 
            this.FirstPlayerScore.AutoSize = true;
            this.FirstPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlayerScore.ForeColor = System.Drawing.Color.White;
            this.FirstPlayerScore.Location = new System.Drawing.Point(19, 426);
            this.FirstPlayerScore.Name = "FirstPlayerScore";
            this.FirstPlayerScore.Size = new System.Drawing.Size(155, 42);
            this.FirstPlayerScore.TabIndex = 4;
            this.FirstPlayerScore.Text = "Player 2";
            // 
            // FirstThink
            // 
            this.FirstThink.AutoSize = true;
            this.FirstThink.BackColor = System.Drawing.Color.Transparent;
            this.FirstThink.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstThink.ForeColor = System.Drawing.Color.White;
            this.FirstThink.Location = new System.Drawing.Point(46, 424);
            this.FirstThink.Name = "FirstThink";
            this.FirstThink.Size = new System.Drawing.Size(0, 76);
            this.FirstThink.TabIndex = 5;
            // 
            // SecondThink
            // 
            this.SecondThink.AutoSize = true;
            this.SecondThink.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondThink.ForeColor = System.Drawing.Color.White;
            this.SecondThink.Location = new System.Drawing.Point(47, 135);
            this.SecondThink.Name = "SecondThink";
            this.SecondThink.Size = new System.Drawing.Size(0, 76);
            this.SecondThink.TabIndex = 6;
            // 
            // SecondPlayerScore
            // 
            this.SecondPlayerScore.AutoSize = true;
            this.SecondPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlayerScore.ForeColor = System.Drawing.Color.White;
            this.SecondPlayerScore.Location = new System.Drawing.Point(19, 140);
            this.SecondPlayerScore.Name = "SecondPlayerScore";
            this.SecondPlayerScore.Size = new System.Drawing.Size(155, 42);
            this.SecondPlayerScore.TabIndex = 7;
            this.SecondPlayerScore.Text = "Player 1";
            // 
            // ThinkAni
            // 
            this.ThinkAni.Interval = 500;
            this.ThinkAni.Tick += new System.EventHandler(this.ThinkAni_Tick);
            // 
            // Turn
            // 
            this.Turn.Image = global::The_Tic_Tac_Toe_Game.Properties.Resources.Arrow_up;
            this.Turn.Location = new System.Drawing.Point(45, 233);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(94, 134);
            this.Turn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Turn.TabIndex = 8;
            this.Turn.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::The_Tic_Tac_Toe_Game.Properties.Resources.Winner_image_default;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Winner);
            this.panel1.Location = new System.Drawing.Point(188, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 319);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // Winner
            // 
            this.Winner.AutoSize = true;
            this.Winner.BackColor = System.Drawing.Color.Transparent;
            this.Winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner.ForeColor = System.Drawing.Color.White;
            this.Winner.Location = new System.Drawing.Point(131, 93);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(348, 108);
            this.Winner.TabIndex = 2;
            this.Winner.Text = "Winner";
            this.Winner.Visible = false;
            // 
            // CPUTime
            // 
            this.CPUTime.Interval = 1500;
            this.CPUTime.Tick += new System.EventHandler(this.CPUTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1065, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.SecondPlayerScore);
            this.Controls.Add(this.FirstPlayerScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.BackToMM);
            this.Controls.Add(this.FirstThink);
            this.Controls.Add(this.SecondThink);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.Name = "Board";
            this.Text = "Board";
            ((System.ComponentModel.ISupportInitialize)(this.Turn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IkarosControls.IkarosButton BackToMM;
        private IkarosControls.IkarosButton Restart;
        private System.Windows.Forms.Label Winner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FirstPlayerScore;
        private System.Windows.Forms.Label FirstThink;
        private System.Windows.Forms.Label SecondThink;
        private System.Windows.Forms.Label SecondPlayerScore;
        private System.Windows.Forms.PictureBox Turn;
        private System.Windows.Forms.Timer ThinkAni;
        private System.Windows.Forms.Timer CPUTime;
        private System.Windows.Forms.Label label1;
    }
}