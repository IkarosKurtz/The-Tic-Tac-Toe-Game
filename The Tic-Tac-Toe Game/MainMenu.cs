using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Tic_Tac_Toe_Game
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        

        #region Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void MovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitApp_MouseLeave(object sender, EventArgs e)
        {
            ExitApp.BackColor = Classes.Themes.TopPanelIconsFalse;
        }

        private void ExitApp_MouseEnter(object sender, EventArgs e)
        {
            ExitApp.BackColor = Classes.Themes.TopPanelIconsTrue;
        }
        #endregion

        // Open the different sections
        private Form currentBoard = null;
        private void OpenBoard(Form Board)
        {
            if (currentBoard != null)
                currentBoard.Close();
            currentBoard = Board;
            Board.TopLevel = false;
            Board.FormBorderStyle = FormBorderStyle.None;
            Board.Dock = DockStyle.Fill;
            MenuPanel.Controls.Add(Board);
            MenuPanel.Tag = Board;
            Board.BringToFront();
            Board.Show();
        }

        // Gamemodes
        private void PvP_Click(object sender, EventArgs e)
        {
            OpenBoard(new Board());
            RenderColor.Stop();
        }

       
        // Settings
        private void Settings_Click(object sender, EventArgs e)
        {
            
            OpenBoard(new Config());
            RenderColor.Start();
        }


        // Render
        private void Rerender()
        {
            IkarosControls.IkarosButton[] buttons = {
            PvP, Confi
            };
            MenuPanel.BackColor = Classes.Themes.MenuColor;
            MovePanel.BackColor = Classes.Themes.TopPanel;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = Classes.Themes.ButtonsColor;
            }
        }
        int asd = 0;
        private void RenderColor_Tick(object sender, EventArgs e)
        {
            Rerender();
            label2.Text = asd.ToString();
            asd++;
        }
    }
}
