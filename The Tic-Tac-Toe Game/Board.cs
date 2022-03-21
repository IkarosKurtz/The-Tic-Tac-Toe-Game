using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Tic_Tac_Toe_Game.Classes.Theme;
using IkarosControls;
using System.Threading;

namespace The_Tic_Tac_Toe_Game
{
    public partial class Board : Form
    {
        // Fields
        static IkarosButton[,] FirstFloor = new IkarosButton[3, 3];
        static IkarosButton[,] SecondFloor = new IkarosButton[3, 3];
        static IkarosButton[,] ThirdFloor = new IkarosButton[3, 3];

        public bool firstPlayerStarts = false;
        public int index = 1, x = 322, y = 24, getTurn = 1;
        public int setDraw = 27;
        Color prevBoardColor = Themes.BoardColor;

        string setTurn => getTurn == 1 ? "X" : "O";

        public static int boardType = 0;

        // Board Controls
        public Board()
        {
            InitializeComponent();
            this.BackColor = Themes.BackGroundColor;
            Restart.BackColor = Themes.BoardColor;
            BackToMM.BackColor = Themes.BoardColor;

            if(boardType == 0)
                PlayerVsPlayer();
            else
                PlayerVsCpu();
            
            ThinkAni.Start();
        }


        // Player vs player board
        private void PlayerVsPlayer()
        {
            // First part of the board
            firstPlayerStarts = false;
            FirstFloor[0, 0] = new IkarosButton();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    FirstFloor[i, j] = new IkarosButton();
                    this.Controls.Add(FirstFloor[i, j]);
                    FirstFloor[i, j].Width = 65;
                    FirstFloor[i, j].Height = 65;
                    FirstFloor[i, j].Location = new Point(x, y);
                    FirstFloor[i, j].BackgroundColor = Themes.BoardColor;
                    FirstFloor[i, j].Text = "";
                    FirstFloor[i, j].BorderRadius = 5;
                    y += 67;
                    FirstFloor[i, j].Click += new EventHandler(PlayerSelection);
                }
                x += 67;
                y = 24;
            }

            // Second part of the board
            y = 222;
            SecondFloor[0, 0] = new IkarosButton();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    SecondFloor[i, j] = new IkarosButton();
                    this.Controls.Add(SecondFloor[i, j]);
                    SecondFloor[i, j].Width = 65;
                    SecondFloor[i, j].Height = 65;
                    SecondFloor[i, j].Location = new Point(x, y);
                    SecondFloor[i, j].BackgroundColor = Themes.BoardColor;
                    SecondFloor[i, j].Text = "";
                    SecondFloor[i, j].BorderRadius = 5;
                    y += 67;
                    SecondFloor[i, j].Click += new EventHandler(PlayerSelection);
                }
                x += 67;
                y = 222;
            }

            // Canceled button
            SecondFloor[1, 1].Enabled = false;
            SecondFloor[1, 1].BackColor = Themes.ButtonCanceled;

            // Third part of the board
            y = 420;
            ThirdFloor[0, 0] = new IkarosButton();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ThirdFloor[i, j] = new IkarosButton();
                    this.Controls.Add(ThirdFloor[i, j]);
                    ThirdFloor[i, j].Width = 65;
                    ThirdFloor[i, j].Height = 65;
                    ThirdFloor[i, j].Location = new Point(x, y);
                    ThirdFloor[i, j].BackgroundColor = Themes.BoardColor;
                    ThirdFloor[i, j].Text = "";
                    ThirdFloor[i, j].BorderRadius = 5;
                    y += 67;
                    ThirdFloor[i, j].Click += new EventHandler(PlayerSelection);
                }
                x += 67;
                y = 420;
            }
        }
        private void PlayerSelection(object sender, EventArgs e)
        {
            IkarosButton clicked = sender as IkarosButton;
            String index2;

            if (clicked.BackgroundColor != Themes.SecondPlayer && clicked.BackgroundColor != Themes.FirstPlayer)
            {
                if (index == 1)
                {
                    getTurn--;
                    clicked.Text = setTurn;
                    clicked.BackgroundColor = Themes.FirstPlayer;
                    index--;
                    SecondThink.Text = "";
                    Turn.Image = new Bitmap(Application.StartupPath + @"\Resources\Arrow_down.png");
                    index2 = "1";

                    
                }
                else
                {
                    getTurn++;
                    clicked.Text = setTurn;
                    clicked.BackgroundColor = Themes.SecondPlayer;
                    index++;
                    FirstThink.Text = "";
                    Turn.Image = new Bitmap(Application.StartupPath + @"\Resources\Arrow_up.png");
                    index2 = "2";
                }

                setDraw--;
                
                if (setDraw != 0)
                {
                    ValidateWinner(index2);
                }
                else // Draw
                {
                    Winner.Text = "Draw";
                    panel1.BackgroundImage = new Bitmap(Application.StartupPath + @"\Resources\Winner_image_default.png");
                }
            }
        }

        private void ValidateWinner(String index2)
        {
            if (FirstFloor[0, 0].BackgroundColor == FirstFloor[1, 1].BackgroundColor && FirstFloor[0, 0].BackgroundColor == FirstFloor[2, 2].BackgroundColor && FirstFloor[0, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (FirstFloor[0, 2].BackgroundColor == FirstFloor[1, 1].BackgroundColor && FirstFloor[0, 2].BackgroundColor == FirstFloor[2, 0].BackgroundColor && FirstFloor[0, 2].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (FirstFloor[0, 0].BackgroundColor == FirstFloor[1, 0].BackgroundColor && FirstFloor[0, 0].BackgroundColor == FirstFloor[2, 0].BackgroundColor && FirstFloor[0, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (FirstFloor[0, 0].BackgroundColor == FirstFloor[0, 1].BackgroundColor && FirstFloor[0, 0].BackgroundColor == FirstFloor[0, 2].BackgroundColor && FirstFloor[0, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (FirstFloor[0, 1].BackgroundColor == FirstFloor[1, 1].BackgroundColor && FirstFloor[0, 1].BackgroundColor == FirstFloor[2, 1].BackgroundColor && FirstFloor[0, 1].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (FirstFloor[0, 2].BackgroundColor == FirstFloor[1, 2].BackgroundColor && FirstFloor[0, 2].BackgroundColor == FirstFloor[2, 2].BackgroundColor && FirstFloor[0, 2].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (FirstFloor[1, 0].BackgroundColor == FirstFloor[1, 1].BackgroundColor && FirstFloor[1, 0].BackgroundColor == FirstFloor[1, 2].BackgroundColor && FirstFloor[1, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (FirstFloor[2, 0].BackgroundColor == FirstFloor[2, 1].BackgroundColor && FirstFloor[2, 0].BackgroundColor == FirstFloor[2, 2].BackgroundColor && FirstFloor[2, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);

            if (SecondFloor[0, 0].BackgroundColor == SecondFloor[1, 1].BackgroundColor && SecondFloor[0, 0].BackgroundColor == SecondFloor[2, 2].BackgroundColor && SecondFloor[0, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (SecondFloor[0, 2].BackgroundColor == SecondFloor[1, 1].BackgroundColor && SecondFloor[0, 2].BackgroundColor == SecondFloor[2, 0].BackgroundColor && SecondFloor[0, 2].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (SecondFloor[0, 0].BackgroundColor == SecondFloor[1, 0].BackgroundColor && SecondFloor[0, 0].BackgroundColor == SecondFloor[2, 0].BackgroundColor && SecondFloor[0, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (SecondFloor[0, 0].BackgroundColor == SecondFloor[0, 1].BackgroundColor && SecondFloor[0, 0].BackgroundColor == SecondFloor[0, 2].BackgroundColor && SecondFloor[0, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (SecondFloor[0, 1].BackgroundColor == SecondFloor[1, 1].BackgroundColor && SecondFloor[0, 1].BackgroundColor == SecondFloor[2, 1].BackgroundColor && SecondFloor[0, 1].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (SecondFloor[0, 2].BackgroundColor == SecondFloor[1, 2].BackgroundColor && SecondFloor[0, 2].BackgroundColor == SecondFloor[2, 2].BackgroundColor && SecondFloor[0, 2].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (SecondFloor[1, 0].BackgroundColor == SecondFloor[1, 1].BackgroundColor && SecondFloor[1, 0].BackgroundColor == SecondFloor[1, 2].BackgroundColor && SecondFloor[1, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (SecondFloor[2, 0].BackgroundColor == SecondFloor[2, 1].BackgroundColor && SecondFloor[2, 0].BackgroundColor == SecondFloor[2, 2].BackgroundColor && SecondFloor[2, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);

            if (ThirdFloor[0, 0].BackgroundColor == ThirdFloor[1, 1].BackgroundColor && ThirdFloor[0, 0].BackgroundColor == ThirdFloor[2, 2].BackgroundColor && ThirdFloor[0, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (ThirdFloor[0, 2].BackgroundColor == ThirdFloor[1, 1].BackgroundColor && ThirdFloor[0, 2].BackgroundColor == ThirdFloor[2, 0].BackgroundColor && ThirdFloor[0, 2].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (ThirdFloor[0, 0].BackgroundColor == ThirdFloor[1, 0].BackgroundColor && ThirdFloor[0, 0].BackgroundColor == ThirdFloor[2, 0].BackgroundColor && ThirdFloor[0, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (ThirdFloor[0, 0].BackgroundColor == ThirdFloor[0, 1].BackgroundColor && ThirdFloor[0, 0].BackgroundColor == ThirdFloor[0, 2].BackgroundColor && ThirdFloor[0, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (ThirdFloor[0, 1].BackgroundColor == ThirdFloor[1, 1].BackgroundColor && ThirdFloor[0, 1].BackgroundColor == ThirdFloor[2, 1].BackgroundColor && ThirdFloor[0, 1].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (ThirdFloor[0, 2].BackgroundColor == ThirdFloor[1, 2].BackgroundColor && ThirdFloor[0, 2].BackgroundColor == ThirdFloor[2, 2].BackgroundColor && ThirdFloor[0, 2].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (ThirdFloor[1, 0].BackgroundColor == ThirdFloor[1, 1].BackgroundColor && ThirdFloor[1, 0].BackgroundColor == ThirdFloor[1, 2].BackgroundColor && ThirdFloor[1, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (ThirdFloor[2, 0].BackgroundColor == ThirdFloor[2, 1].BackgroundColor && ThirdFloor[2, 0].BackgroundColor == ThirdFloor[2, 2].BackgroundColor && ThirdFloor[2, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);

            if (FirstFloor[0, 0].BackgroundColor == SecondFloor[1, 0].BackgroundColor && FirstFloor[0, 0].BackgroundColor == ThirdFloor[2, 0].BackgroundColor && FirstFloor[0, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (FirstFloor[0, 0].BackgroundColor == SecondFloor[0, 1].BackgroundColor && FirstFloor[0, 0].BackgroundColor == ThirdFloor[0, 2].BackgroundColor && FirstFloor[0, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (FirstFloor[2, 0].BackgroundColor == SecondFloor[2, 1].BackgroundColor && FirstFloor[2, 0].BackgroundColor == ThirdFloor[2, 2].BackgroundColor && FirstFloor[2, 0].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
            if (FirstFloor[0, 2].BackgroundColor == SecondFloor[1, 2].BackgroundColor && FirstFloor[0, 2].BackgroundColor == ThirdFloor[2, 2].BackgroundColor && FirstFloor[0, 2].BackgroundColor != Themes.BoardColor)
                WinnerMessage(index2);
        }


        // Player vs CPU board
        private void PlayerVsCpu()
        {
            // Recolor Controls
            this.BackColor = Themes.BackGroundColor;
            BackToMM.BackColor = Themes.BoardColor;
            Restart.BackColor = Themes.BoardColor;

            // First part of the board
            firstPlayerStarts = false;
            FirstFloor[0, 0] = new IkarosButton();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    FirstFloor[i, j] = new IkarosButton();
                    this.Controls.Add(FirstFloor[i, j]);
                    FirstFloor[i, j].Width = 65;
                    FirstFloor[i, j].Height = 65;
                    FirstFloor[i, j].Location = new Point(x, y);
                    FirstFloor[i, j].BackgroundColor = Themes.BoardColor;
                    FirstFloor[i, j].Text = "";
                    FirstFloor[i, j].BorderRadius = 5;
                    y += 67;
                    FirstFloor[i, j].Click += new EventHandler(CpuTurn);
                }
                x += 67;
                y = 24;
            }

            // Second part of the board
            y = 222;
            SecondFloor[0, 0] = new IkarosButton();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    SecondFloor[i, j] = new IkarosButton();
                    this.Controls.Add(SecondFloor[i, j]);
                    SecondFloor[i, j].Width = 65;
                    SecondFloor[i, j].Height = 65;
                    SecondFloor[i, j].Location = new Point(x, y);
                    SecondFloor[i, j].BackgroundColor = Themes.BoardColor;
                    SecondFloor[i, j].Text = "";
                    SecondFloor[i, j].BorderRadius = 5;
                    y += 67;
                    SecondFloor[i, j].Click += new EventHandler(CpuTurn);
                }
                x += 67;
                y = 222;
            }

            // Canceled button
            SecondFloor[1, 1].Enabled = false;
            SecondFloor[1, 1].BackColor = Themes.ButtonCanceled;

            // Third part of the board
            y = 420;
            ThirdFloor[0, 0] = new IkarosButton();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ThirdFloor[i, j] = new IkarosButton();
                    this.Controls.Add(ThirdFloor[i, j]);
                    ThirdFloor[i, j].Width = 65;
                    ThirdFloor[i, j].Height = 65;
                    ThirdFloor[i, j].Location = new Point(x, y);
                    ThirdFloor[i, j].BackgroundColor = Themes.BoardColor;
                    ThirdFloor[i, j].Text = "";
                    ThirdFloor[i, j].BorderRadius = 5;
                    y += 67;
                    ThirdFloor[i, j].Click += new EventHandler(CpuTurn);
                }
                x += 67;
                y = 420;
            }
        }

        bool hisTurn = false;
        private void CpuTurn(object sender, EventArgs e)
        {
            IkarosButton clicked = sender as IkarosButton;
            String index2 = null;

            if (clicked.BackgroundColor != Themes.SecondPlayer && clicked.BackgroundColor != Themes.FirstPlayer && index == 1)
            {
                getTurn--;
                clicked.Text = setTurn;
                clicked.BackgroundColor = Themes.FirstPlayer;
                index--;
                hisTurn = true;
                SecondThink.Text = "";
                Turn.Image = new Bitmap(Application.StartupPath + @"\Resources\Arrow_down.png");
                index2 = "1";
                CPUTime.Start();

            }
            setDraw--;

            if (setDraw != 0)
            {
                ValidateWinner(index2);
            }
            else // Draw
            {
                Winner.Text = "Draw";
                panel1.BackgroundImage = new Bitmap(Application.StartupPath + @"\Resources\Winner_image_default.png");
            }

            
        }

        // Cpu
        private void AI(int x, int y)
        {
            FirstFloor[x, y].BackColor = Themes.SecondPlayer;
            FirstFloor[x, y].Text = "5";
            getTurn--;
            FirstThink.Text = "";
            Turn.Image = new Bitmap(Application.StartupPath + @"\Resources\Arrow_up.png");
            hisTurn = false;
        }

        // Dynamic Difficulty
        int DynamicDifficulty = 5;

        private void Hard()
        {
            if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[1, 2].BackColor && hisTurn == true)
            {
                if (FirstFloor[1, 0].BackColor == Themes.BoardColor)
                    AI(1, 0);
            }

            if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[0, 1].BackColor && hisTurn == true)
            {
                if (FirstFloor[2, 1].BackColor == Themes.BoardColor)
                    AI(2, 1);
            }

            if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[2, 1].BackColor && hisTurn == true)
            {
                if (FirstFloor[0, 1].BackColor == Themes.BoardColor)
                    AI(0, 1);
            }
        }

        // Other stuff
        private void ThinkAni_Tick(object sender, EventArgs e)
        {
            if(index == 1)
            {
                SecondThink.Text += ".";
                if (SecondThink.Text == "....")
                    SecondThink.Text = "";
            }
            else
            {
                FirstThink.Text += ".";
                if (FirstThink.Text == "....")
                    FirstThink.Text = "";
            }
        }

        private void CPUTime_Tick(object sender, EventArgs e)
        {
            String index2 = null;
            index++;

            // Columns
            if (FirstFloor[0, 1].BackColor == Themes.FirstPlayer && FirstFloor[0, 1].BackColor == FirstFloor[0, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[0, 2].BackColor == Themes.BoardColor)
                    AI(0, 2);
            }

                if (FirstFloor[0, 1].BackColor == Themes.FirstPlayer && FirstFloor[0, 1].BackColor == FirstFloor[0, 2].BackColor && hisTurn == true)
                {
                    if (FirstFloor[0, 0].BackColor == Themes.BoardColor)
                        AI(0, 0);
                }

            if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[1, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[1, 2].BackColor == Themes.BoardColor)
                    AI(1, 2);
            }

                

            if (FirstFloor[2, 1].BackColor == Themes.FirstPlayer && FirstFloor[2, 1].BackColor == FirstFloor[2, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[2, 2].BackColor == Themes.BoardColor)
                    AI(2, 2);
            }

                if (FirstFloor[2, 1].BackColor == Themes.FirstPlayer && FirstFloor[2, 1].BackColor == FirstFloor[2, 2].BackColor && hisTurn == true)
                {
                    if (FirstFloor[2, 0].BackColor == Themes.BoardColor)
                        AI(2, 0);
                }

            // Rows
            if (FirstFloor[1, 0].BackColor == Themes.FirstPlayer && FirstFloor[1, 0].BackColor == FirstFloor[0, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[2, 0].BackColor == Themes.BoardColor)
                    AI(2, 0);
            }

                if (FirstFloor[1, 0].BackColor == Themes.FirstPlayer && FirstFloor[1, 0].BackColor == FirstFloor[2, 0].BackColor && hisTurn == true)
                {
                    if (FirstFloor[0, 0].BackColor == Themes.BoardColor)
                        AI(0, 0);
                }

            

            if (FirstFloor[1, 2].BackColor == Themes.FirstPlayer && FirstFloor[1, 2].BackColor == FirstFloor[0, 2].BackColor && hisTurn == true)
            {
                if (FirstFloor[2, 2].BackColor == Themes.BoardColor)
                    AI(2, 2);
            }

                if (FirstFloor[1, 2].BackColor == Themes.FirstPlayer && FirstFloor[1, 2].BackColor == FirstFloor[2, 2].BackColor && hisTurn == true)
                {
                    if (FirstFloor[0, 2].BackColor == Themes.BoardColor)
                        AI(0, 2);
                }

            // Diagonal
            if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[0, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[2, 2].BackColor == Themes.BoardColor)
                    AI(2, 2);
            }

                if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[2, 2].BackColor && hisTurn == true)
                {
                    if (FirstFloor[0, 0].BackColor == Themes.BoardColor)
                        AI(0, 0);
                }

            if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[2, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[0, 2].BackColor == Themes.BoardColor)
                    AI(0, 2);
            }

                if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[0, 2].BackColor && hisTurn == true)
                {
                    if (FirstFloor[2, 0].BackColor == Themes.BoardColor)
                        AI(2, 0);
                }

            if (hisTurn == true)
            {
                int I, K, stop = 0;
                Random random = new Random();
                do
                {
                    I = random.Next(0, 2);
                    K = random.Next(0, 2);
                    stop++;
                } while (FirstFloor[I, K].BackColor != Themes.BoardColor && stop != 25);
                if(stop != 25)
                    AI(I, K);
                index2 = "2";
            }

            setDraw--;

            if (setDraw != 0)
            {
                ValidateWinner(index2);
            }
            else // Draw
            {
                Winner.Text = "Draw";
                panel1.BackgroundImage = new Bitmap(Application.StartupPath + @"\Resources\Winner_image_default.png");
            }

            CPUTime.Stop();
        }

        // Winner Message
        private void WinnerMessage(string index2)
        {
            Winner.Text = "Player " + index2 + " Win";
            if (index == 1)
                panel1.BackgroundImage = new Bitmap(Application.StartupPath + Themes.SecondPlayerBanner);
            else
                panel1.BackgroundImage = new Bitmap(Application.StartupPath + Themes.FirstPlayerBanner);

            panel1.Visible = true;
            Winner.Visible = true;
            hisTurn = false;


            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    FirstFloor[i, j].Enabled = false;
                    SecondFloor[i, j].Enabled = false;
                    ThirdFloor[i, j].Enabled = false;
                    Themes.BoardColor = Themes.ButtonsDisable;


                    // First Floor
                    if (FirstFloor[i, j].BackColor != Themes.FirstPlayer && FirstFloor[i, j].BackColor != Themes.SecondPlayer)
                        FirstFloor[i, j].BackColor = Themes.BoardColor;
                    else
                        if (FirstFloor[i, j].BackColor == Themes.FirstPlayer)
                            FirstFloor[i, j].BackColor = Themes.FirstPlayerDisable;
                        else
                            FirstFloor[i, j].BackColor = Themes.SecondPlayerDisable;

                    // Second Floor
                    if (SecondFloor[i, j].BackColor != Themes.FirstPlayer && SecondFloor[i, j].BackColor != Themes.SecondPlayer)
                        SecondFloor[i, j].BackColor = Themes.BoardColor;
                    else
                        if (SecondFloor[i, j].BackColor == Themes.FirstPlayer)
                            SecondFloor[i, j].BackColor = Themes.FirstPlayerDisable;
                        else
                            SecondFloor[i, j].BackColor = Themes.SecondPlayerDisable;

                    // Third Floor
                    if (ThirdFloor[i, j].BackColor != Themes.FirstPlayer && ThirdFloor[i, j].BackColor != Themes.SecondPlayer)
                        ThirdFloor[i, j].BackColor = Themes.BoardColor;
                    else
                        if (ThirdFloor[i, j].BackColor == Themes.FirstPlayer)
                            ThirdFloor[i, j].BackColor = Themes.FirstPlayerDisable;
                        else
                            ThirdFloor[i, j].BackColor = Themes.SecondPlayerDisable;

                }
            }
            SecondFloor[1, 1].BackColor = Themes.ButtonCanceled;
        }

        // Buttons
        private void BackToMM_Click(object sender, EventArgs e)
        {
            Restart_Click(sender, e);
            this.Close();
            ThinkAni.Stop();
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            setDraw = 27;
            getTurn = 1;
            index = 1;

            Themes.BoardColor = prevBoardColor;
            panel1.Visible = false;
            Winner.Visible = false;
            FirstThink.Text = "";
            SecondThink.Text = "";
            Turn.Image = new Bitmap(Application.StartupPath + @"\Resources\Arrow_up.png");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    FirstFloor[i, j].Text = "";
                    SecondFloor[i, j].Text = "";
                    ThirdFloor[i, j].Text = "";

                    FirstFloor[i, j].BackColor = Themes.BoardColor;
                    SecondFloor[i, j].BackColor = Themes.BoardColor;
                    ThirdFloor[i, j].BackColor = Themes.BoardColor;

                    FirstFloor[i, j].Enabled = true;
                    SecondFloor[i, j].Enabled = true;
                    ThirdFloor[i, j].Enabled = true;
                }
            }

            SecondFloor[1, 1].BackColor = Themes.ButtonCanceled;
            SecondFloor[1, 1].Enabled = false;
        }
    }
}
