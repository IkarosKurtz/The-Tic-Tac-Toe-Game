using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Tic_Tac_Toe_Game
{
    public partial class Board : Form
    {
        // Fields
        static IkarosControls.IkarosButton[,] FirstFloor = new IkarosControls.IkarosButton[3, 3];
        static IkarosControls.IkarosButton[,] SecondFloor = new IkarosControls.IkarosButton[3, 3];
        static IkarosControls.IkarosButton[,] ThirdFloor = new IkarosControls.IkarosButton[3, 3];

        public bool firstPlayerStarts = false;
        public int index = -1, x = 322, y = 24, getTurn = 1;
        public int setDraw = 27;
        Color prevBoardColor = Classes.Themes.BoardColor;

        string setTurn => getTurn == 1 ? "X" : "O";

        // Board Controls
        public Board()
        {
            InitializeComponent();
            // Recolor Controls
            this.BackColor = Classes.Themes.BackGroundColor;
            BackToMM.BackColor = Classes.Themes.BoardColor;
            Restart.BackColor = Classes.Themes.BoardColor;

            // First part of the board
            firstPlayerStarts = false;
            FirstFloor[0, 0] = new IkarosControls.IkarosButton();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    FirstFloor[i, j] = new IkarosControls.IkarosButton();
                    this.Controls.Add(FirstFloor[i, j]);
                    FirstFloor[i, j].Width = 65;
                    FirstFloor[i, j].Height = 65;
                    FirstFloor[i, j].Location = new Point(x, y);
                    FirstFloor[i, j].BackgroundColor = Classes.Themes.BoardColor;
                    FirstFloor[i, j].Text = "";
                    FirstFloor[i, j].BorderRadius = 5;
                    y += 67;
                    FirstFloor[i, j].Click += new System.EventHandler(PlayerSelection);
                }
                x += 67;
                y = 24;
            }

            // Second part of the board
            y = 222;
            SecondFloor[0, 0] = new IkarosControls.IkarosButton();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    SecondFloor[i, j] = new IkarosControls.IkarosButton();
                    this.Controls.Add(SecondFloor[i, j]);
                    SecondFloor[i, j].Width = 65;
                    SecondFloor[i, j].Height = 65;
                    SecondFloor[i, j].Location = new Point(x, y);
                    SecondFloor[i, j].BackgroundColor = Classes.Themes.BoardColor;
                    SecondFloor[i, j].Text = "";
                    SecondFloor[i, j].BorderRadius = 5;
                    y += 67;
                    SecondFloor[i, j].Click += new System.EventHandler(PlayerSelection);
                }
                x += 67;
                y = 222;
            }

            // Canceled button
            SecondFloor[1, 1].Enabled = false;
            SecondFloor[1, 1].BackColor = Classes.Themes.ButtonCanceled;

            // Third part of the board
            y = 420;
            ThirdFloor[0, 0] = new IkarosControls.IkarosButton();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ThirdFloor[i, j] = new IkarosControls.IkarosButton();
                    this.Controls.Add(ThirdFloor[i, j]);
                    ThirdFloor[i, j].Width = 65;
                    ThirdFloor[i, j].Height = 65;
                    ThirdFloor[i, j].Location = new Point(x, y);
                    ThirdFloor[i, j].BackgroundColor = Classes.Themes.BoardColor;
                    ThirdFloor[i, j].Text = "";
                    ThirdFloor[i, j].BorderRadius = 5;
                    y += 67;
                    ThirdFloor[i, j].Click += new System.EventHandler(PlayerSelection);
                }
                x += 67;
                y = 420;
            }
        }

        private void PlayerSelection(object sender, EventArgs e)
        {
            IkarosControls.IkarosButton clicked = sender as IkarosControls.IkarosButton;
            String index2;

            if (clicked.BackgroundColor != Classes.Themes.SecondPlayer && clicked.BackgroundColor != Classes.Themes.FirstPlayer)
            {
                if (index % 2 == 0)
                {
                    getTurn--;
                    clicked.Text = setTurn;
                    clicked.BackgroundColor = Classes.Themes.SecondPlayer;
                    index++;
                    index2 = Convert.ToString(index % 2 + 1);
                }
                else
                {
                    getTurn++;
                    clicked.Text = setTurn;
                    clicked.BackgroundColor = Classes.Themes.FirstPlayer;
                    index++;
                    index2 = Convert.ToString(index % 2 + 1);
                }

                setDraw--;

                if (setDraw != 0)
                {
                    if (FirstFloor[0, 0].BackgroundColor == FirstFloor[1, 1].BackgroundColor && FirstFloor[0, 0].BackgroundColor == FirstFloor[2, 2].BackgroundColor && FirstFloor[0, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (FirstFloor[0, 2].BackgroundColor == FirstFloor[1, 1].BackgroundColor && FirstFloor[0, 2].BackgroundColor == FirstFloor[2, 0].BackgroundColor && FirstFloor[0, 2].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (FirstFloor[0, 0].BackgroundColor == FirstFloor[1, 0].BackgroundColor && FirstFloor[0, 0].BackgroundColor == FirstFloor[2, 0].BackgroundColor && FirstFloor[0, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (FirstFloor[0, 0].BackgroundColor == FirstFloor[0, 1].BackgroundColor && FirstFloor[0, 0].BackgroundColor == FirstFloor[0, 2].BackgroundColor && FirstFloor[0, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (FirstFloor[0, 1].BackgroundColor == FirstFloor[1, 1].BackgroundColor && FirstFloor[0, 1].BackgroundColor == FirstFloor[2, 1].BackgroundColor && FirstFloor[0, 1].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (FirstFloor[0, 2].BackgroundColor == FirstFloor[1, 2].BackgroundColor && FirstFloor[0, 2].BackgroundColor == FirstFloor[2, 2].BackgroundColor && FirstFloor[0, 2].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (FirstFloor[1, 0].BackgroundColor == FirstFloor[1, 1].BackgroundColor && FirstFloor[1, 0].BackgroundColor == FirstFloor[1, 2].BackgroundColor && FirstFloor[1, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (FirstFloor[2, 0].BackgroundColor == FirstFloor[2, 1].BackgroundColor && FirstFloor[2, 0].BackgroundColor == FirstFloor[2, 2].BackgroundColor && FirstFloor[2, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);

                    if (SecondFloor[0, 0].BackgroundColor == SecondFloor[1, 1].BackgroundColor && SecondFloor[0, 0].BackgroundColor == SecondFloor[2, 2].BackgroundColor && SecondFloor[0, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (SecondFloor[0, 2].BackgroundColor == SecondFloor[1, 1].BackgroundColor && SecondFloor[0, 2].BackgroundColor == SecondFloor[2, 0].BackgroundColor && SecondFloor[0, 2].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (SecondFloor[0, 0].BackgroundColor == SecondFloor[1, 0].BackgroundColor && SecondFloor[0, 0].BackgroundColor == SecondFloor[2, 0].BackgroundColor && SecondFloor[0, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (SecondFloor[0, 0].BackgroundColor == SecondFloor[0, 1].BackgroundColor && SecondFloor[0, 0].BackgroundColor == SecondFloor[0, 2].BackgroundColor && SecondFloor[0, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (SecondFloor[0, 1].BackgroundColor == SecondFloor[1, 1].BackgroundColor && SecondFloor[0, 1].BackgroundColor == SecondFloor[2, 1].BackgroundColor && SecondFloor[0, 1].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (SecondFloor[0, 2].BackgroundColor == SecondFloor[1, 2].BackgroundColor && SecondFloor[0, 2].BackgroundColor == SecondFloor[2, 2].BackgroundColor && SecondFloor[0, 2].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (SecondFloor[1, 0].BackgroundColor == SecondFloor[1, 1].BackgroundColor && SecondFloor[1, 0].BackgroundColor == SecondFloor[1, 2].BackgroundColor && SecondFloor[1, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (SecondFloor[2, 0].BackgroundColor == SecondFloor[2, 1].BackgroundColor && SecondFloor[2, 0].BackgroundColor == SecondFloor[2, 2].BackgroundColor && SecondFloor[2, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);

                    if (ThirdFloor[0, 0].BackgroundColor == ThirdFloor[1, 1].BackgroundColor && ThirdFloor[0, 0].BackgroundColor == ThirdFloor[2, 2].BackgroundColor && ThirdFloor[0, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (ThirdFloor[0, 2].BackgroundColor == ThirdFloor[1, 1].BackgroundColor && ThirdFloor[0, 2].BackgroundColor == ThirdFloor[2, 0].BackgroundColor && ThirdFloor[0, 2].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (ThirdFloor[0, 0].BackgroundColor == ThirdFloor[1, 0].BackgroundColor && ThirdFloor[0, 0].BackgroundColor == ThirdFloor[2, 0].BackgroundColor && ThirdFloor[0, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (ThirdFloor[0, 0].BackgroundColor == ThirdFloor[0, 1].BackgroundColor && ThirdFloor[0, 0].BackgroundColor == ThirdFloor[0, 2].BackgroundColor && ThirdFloor[0, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (ThirdFloor[0, 1].BackgroundColor == ThirdFloor[1, 1].BackgroundColor && ThirdFloor[0, 1].BackgroundColor == ThirdFloor[2, 1].BackgroundColor && ThirdFloor[0, 1].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (ThirdFloor[0, 2].BackgroundColor == ThirdFloor[1, 2].BackgroundColor && ThirdFloor[0, 2].BackgroundColor == ThirdFloor[2, 2].BackgroundColor && ThirdFloor[0, 2].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (ThirdFloor[1, 0].BackgroundColor == ThirdFloor[1, 1].BackgroundColor && ThirdFloor[1, 0].BackgroundColor == ThirdFloor[1, 2].BackgroundColor && ThirdFloor[1, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (ThirdFloor[2, 0].BackgroundColor == ThirdFloor[2, 1].BackgroundColor && ThirdFloor[2, 0].BackgroundColor == ThirdFloor[2, 2].BackgroundColor && ThirdFloor[2, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);

                    if (FirstFloor[0, 0].BackgroundColor == SecondFloor[1, 0].BackgroundColor && FirstFloor[0, 0].BackgroundColor == ThirdFloor[2, 0].BackgroundColor && FirstFloor[0, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (FirstFloor[0, 0].BackgroundColor == SecondFloor[0, 1].BackgroundColor && FirstFloor[0, 0].BackgroundColor == ThirdFloor[0, 2].BackgroundColor && FirstFloor[0, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (FirstFloor[2, 0].BackgroundColor == SecondFloor[2, 1].BackgroundColor && FirstFloor[2, 0].BackgroundColor == ThirdFloor[2, 2].BackgroundColor && FirstFloor[2, 0].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                    if (FirstFloor[0, 2].BackgroundColor == SecondFloor[1, 2].BackgroundColor && FirstFloor[0, 2].BackgroundColor == ThirdFloor[2, 2].BackgroundColor && FirstFloor[0, 2].BackgroundColor != Classes.Themes.BoardColor)
                        WinnerMessage(index2);
                }
                else
                {
                    MessageBox.Show("Es un empate.", "DRAW", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Winner Message
        private void WinnerMessage(string index2)
        {
            Winner.Text = "Player " + index2 + " Win";
            Winner.Visible = true;

            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    FirstFloor[i, j].Enabled = false;
                    SecondFloor[i, j].Enabled = false;
                    ThirdFloor[i, j].Enabled = false;
                    Classes.Themes.BoardColor = Classes.Themes.ButtonsDisable;


                    // First Floor
                    if (FirstFloor[i, j].BackColor != Classes.Themes.FirstPlayer && FirstFloor[i, j].BackColor != Classes.Themes.SecondPlayer)
                        FirstFloor[i, j].BackColor = Classes.Themes.BoardColor;
                    else
                        if (FirstFloor[i, j].BackColor == Classes.Themes.FirstPlayer)
                            FirstFloor[i, j].BackColor = Classes.Themes.FirstPlayerDisable;
                        else
                            FirstFloor[i, j].BackColor = Classes.Themes.SecondPlayerDisable;

                    // Second Floor
                    if (SecondFloor[i, j].BackColor != Classes.Themes.FirstPlayer && SecondFloor[i, j].BackColor != Classes.Themes.SecondPlayer)
                        SecondFloor[i, j].BackColor = Classes.Themes.BoardColor;
                    else
                        if (SecondFloor[i, j].BackColor == Classes.Themes.FirstPlayer)
                            SecondFloor[i, j].BackColor = Classes.Themes.FirstPlayerDisable;
                        else
                            SecondFloor[i, j].BackColor = Classes.Themes.SecondPlayerDisable;

                    // Third Floor
                    if (ThirdFloor[i, j].BackColor != Classes.Themes.FirstPlayer && ThirdFloor[i, j].BackColor != Classes.Themes.SecondPlayer)
                        ThirdFloor[i, j].BackColor = Classes.Themes.BoardColor;
                    else
                        if (ThirdFloor[i, j].BackColor == Classes.Themes.FirstPlayer)
                            ThirdFloor[i, j].BackColor = Classes.Themes.FirstPlayerDisable;
                        else
                            ThirdFloor[i, j].BackColor = Classes.Themes.SecondPlayerDisable;

                }
            }
            SecondFloor[1, 1].BackColor = Classes.Themes.ButtonCanceled;
        }


        // Buttons
        private void BackToMM_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void Restart_Click(object sender, EventArgs e)
        {
            setDraw = 27;
            Classes.Themes.BoardColor = prevBoardColor;
            Winner.Visible = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    FirstFloor[i, j].Text = "";
                    SecondFloor[i, j].Text = "";
                    ThirdFloor[i, j].Text = "";

                    FirstFloor[i, j].BackColor = Classes.Themes.BoardColor;
                    SecondFloor[i, j].BackColor = Classes.Themes.BoardColor;
                    ThirdFloor[i, j].BackColor = Classes.Themes.BoardColor;

                    FirstFloor[i, j].Enabled = true;
                    SecondFloor[i, j].Enabled = true;
                    ThirdFloor[i, j].Enabled = true;
                }
            }

            SecondFloor[1, 1].BackColor = Classes.Themes.ButtonCanceled;
            SecondFloor[1, 1].Enabled = false;
        }
    }
}
