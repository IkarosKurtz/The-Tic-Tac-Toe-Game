using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Tic_Tac_Toe_Game.Classes.Theme;
using IkarosControls;

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
            ExitApp.BackColor = Themes.TopPanelIconsFalse;
        }

        private void ExitApp_MouseEnter(object sender, EventArgs e)
        {
            ExitApp.BackColor = Themes.TopPanelIconsTrue;
        }
        #endregion

        // Open the selected mode
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
            Board.boardType = 0;
            OpenBoard(new Board());
        }

        private void VsCPU_Click(object sender, EventArgs e)
        {
            Board.boardType = 1;
            OpenBoard(new Board());
        }

        // Settings
        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsPanel.Dock = DockStyle.Fill;
            SettingsPanel.Visible = true;
        }

        // Close
        private void ExitToDesktop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Render
        private void Rerender()
        {
            IkarosButton[] buttons = {
            PvP, 
            Confi,
            ExitToDesktop,
            VsCPU,
            SelectTheme,
            ToggleDefault,
            ToggleDark,
            BackToSettings,
            BackToMM,
            Language

            };
            MenuPanel.BackColor = Themes.MenuColor;
            MovePanel.BackColor = Themes.TopPanel;
            SettingsPanel.BackColor = Themes.MenuColor;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = Themes.ButtonsColor;
            }
        }

        // GitHub Icon
        private void GitHub_MouseEnter(object sender, EventArgs e)
        {
            GitHub.Image = new Bitmap(Application.StartupPath + @"\Resources\Github focus.png");
            
        }

        private void GitHub_MouseLeave(object sender, EventArgs e)
        {
            GitHub.Image = new Bitmap(Application.StartupPath + @"\Resources\Github.png");
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IkarosKurtz/The-Tic-Tac-Toe-Game");
        }

        // Settings
        private void BackToMM_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
        }

        private void SelectTheme_Click(object sender, EventArgs e)
        {
            ToggleDark.Visible = true;
            ToggleDefault.Visible = true;
            BackToSettings.Visible = true;

            SelectTheme.Visible = false;
            Language.Visible = false;
            BackToMM.Visible = false;
        }

        private void BackToSettings_Click(object sender, EventArgs e)
        {
            ToggleDark.Visible = false;
            ToggleDefault.Visible = false;
            BackToSettings.Visible = false;

            SelectTheme.Visible = true;
            Language.Visible = true;
            BackToMM.Visible = true;
        }

        private void ToggleDefault_Click(object sender, EventArgs e)
        {
            Themes.ToggleTheme(0);
            Rerender();
            ExitApp_MouseLeave(sender, e);
        }

        private void ToggleDark_Click(object sender, EventArgs e)
        {
            Themes.ToggleTheme(1);
            Rerender();
            ExitApp_MouseLeave(sender, e);
        }
    }
}
