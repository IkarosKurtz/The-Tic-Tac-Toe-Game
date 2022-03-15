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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            Rerender();
            
        }


        // Buttons from Settings
        private void ChooseTheme_Click(object sender, EventArgs e)
        {
            Tittle1.Visible = false;
            Tittle2.Visible = true;

            ChooseTheme.Visible = false;
            Language.Visible = false;
            MyGitHub.Visible = false;
            BackMainMenu.Visible = false;

            ToggleDefault.Visible = true;
            ToggleDark.Visible = true;
            BackSettings.Visible = true;
        }

        private void MyGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IkarosKurtz/Tic-Tac-Toe");
        }

        private void BackMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackSettings_Click(object sender, EventArgs e)
        {
            Tittle1.Visible = true;
            Tittle2.Visible = false;

            ChooseTheme.Visible = true;
            Language.Visible = true;
            MyGitHub.Visible = true;
            BackMainMenu.Visible = true;

            ToggleDefault.Visible = false;
            ToggleDark.Visible = false;
            BackSettings.Visible = false;
        }

        public static void ToggleTheme()
        {
            
        }
        
        // Change Theme
        private void ToggleDefault_Click(object sender, EventArgs e)
        {
            Classes.Themes.ToggleTheme(0);
            Rerender();
        }

        private void ToggleDark_Click(object sender, EventArgs e)
        {
            Classes.Themes.ToggleTheme(1);
            Rerender();
        }

        private void Rerender()
        {
            IkarosControls.IkarosButton[] buttons = {
            ChooseTheme, BackMainMenu, BackSettings, Language, MyGitHub,ToggleDark, ToggleDefault
            };
            this.BackColor = Classes.Themes.MenuColor;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = Classes.Themes.ButtonsColor;
            }
        }

        
    }
}
