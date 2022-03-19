using System.Drawing;

namespace The_Tic_Tac_Toe_Game.Classes
{
    public static class Themes
    {
        // Fields
        public static Color MenuColor = Color.FromArgb(227, 202, 165);
        public static Color LabelsColor;
        public static Color BoardColor = Color.FromArgb(227, 202, 165);
        public static Color BackGroundColor = Color.FromArgb(173, 139, 116);
        public static Color ButtonsColor = Color.FromArgb(173, 139, 116);

        public static Color TopPanel;
        public static Color TopPanelIconsTrue = Color.FromArgb(238, 230, 220);
        public static Color TopPanelIconsFalse = Color.FromArgb(255, 251, 233);

        public static Color ButtonsDisable = Color.FromArgb(196, 168, 130);
        public static Color FirstPlayer = Color.FromArgb(255, 100, 100);
        public static Color SecondPlayer = Color.FromArgb(102, 193, 140);
        public static Color FirstPlayerDisable = Color.FromArgb(210, 100, 100);
        public static Color SecondPlayerDisable = Color.FromArgb(102, 178, 140);

        public static Color ButtonCanceled = Color.FromArgb(46, 45, 46);

        public static string FirstPlayerBanner = @"\Resources\Winner_image_FirstPlayerD.png";
        public static string SecondPlayerBanner = @"\Resources\Winner_image_SecondPlayerD.png";
        public static string DrawBanner = @"\Resources\Winner_image_DefaultD.png";

        // Default Theme

        #region Default

        private static readonly Color menuColor = Color.FromArgb(227, 202, 165);
        private static readonly Color buttonsColor = Color.FromArgb(173, 139, 116);
        private static readonly Color labelsColor = Color.FromArgb(255, 255, 255);
        private static readonly Color boardColor = Color.FromArgb(227, 202, 165);
        private static readonly Color backgroundColor = Color.FromArgb(173, 139, 116);

        private static readonly Color toppanel = Color.FromArgb(255, 251, 233);
        private static readonly Color iconstrue = Color.FromArgb(238, 230, 220);
        private static readonly Color iconsfalse = Color.FromArgb(255, 251, 233);

        private static readonly Color buttonsdisable = Color.FromArgb(196, 168, 130);
        private static readonly Color firstplayer = Color.FromArgb(255, 100, 100);
        private static readonly Color secondplayer = Color.FromArgb(102, 193, 140);
        private static readonly Color firstplayerdisable = Color.FromArgb(210, 100, 100);
        private static readonly Color secondplayerdisable = Color.FromArgb(102, 178, 140);

        private static readonly Color buttoncanceled = Color.FromArgb(46, 45, 46);

        private static readonly string firstplayerbanner = @"\Resources\Winner_image_FirstPlayerD.png";
        private static readonly string secondplayerbanner = @"\Resources\Winner_image_SecondPlayerD.png";
        private static readonly string drawbanner = @"\Resources\Winner_image_DefaultD.png";

        #endregion Default

        // Dark Theme

        #region Dark

        private static readonly Color menuColorD = Color.FromArgb(54, 34, 34);
        private static readonly Color buttonsColorD = Color.FromArgb(24, 17, 17);
        private static readonly Color labelsColorD = Color.FromArgb(255, 255, 255);
        private static readonly Color boardColorD = Color.FromArgb(54, 34, 34);
        private static readonly Color backgroundColorD = Color.FromArgb(24, 17, 17);

        private static readonly Color toppanelD = Color.FromArgb(67, 64, 63);
        private static readonly Color iconstrueD = Color.FromArgb(95, 93, 89);
        private static readonly Color iconsfalseD = Color.FromArgb(67, 64, 63);

        private static readonly Color buttonsdisableD = Color.FromArgb(28, 25, 28);
        private static readonly Color firstplayerD = Color.FromArgb(88, 162, 125);
        private static readonly Color secondplayerD = Color.FromArgb(185, 82, 84);
        private static readonly Color firstplayerdisableD = Color.FromArgb(76, 144, 125);
        private static readonly Color secondplayerdisableD = Color.FromArgb(167, 68, 69);

        private static readonly string firstplayerbannerD = @"\Resources\Winner_image_FirstPlayerD.png";
        private static readonly string secondplayerbannerD = @"\Resources\Winner_image_SecondPlayerD.png";
        private static readonly string drawbannerD = @"\Resources\Winner_image_DefaultD.png";

        #endregion Dark

        // Change theme
        public static void ToggleTheme(int setTheme)
        {
            switch (setTheme)
            {
                case 0:
                    MenuColor = menuColor;
                    ButtonsColor = buttonsColor;
                    LabelsColor = labelsColor;
                    BoardColor = boardColor;
                    BackGroundColor = backgroundColor;
                    TopPanel = toppanel;
                    TopPanelIconsTrue = iconstrue;
                    TopPanelIconsFalse = iconsfalse;
                    ButtonsDisable = buttonsdisable;
                    FirstPlayer = firstplayer;
                    SecondPlayer = secondplayer;
                    FirstPlayerDisable = firstplayerdisable;
                    SecondPlayerDisable = secondplayerdisable;
                    ButtonCanceled = buttoncanceled;

                    FirstPlayerBanner = firstplayerbanner;
                    SecondPlayerBanner = secondplayerbanner;
                    DrawBanner = drawbanner;

                    break;

                case 1:
                    MenuColor = menuColorD;
                    ButtonsColor = buttonsColorD;
                    LabelsColor = labelsColorD;
                    BoardColor = boardColorD;
                    BackGroundColor = backgroundColorD;
                    TopPanel = toppanelD;
                    TopPanelIconsTrue = iconstrueD;
                    TopPanelIconsFalse = iconsfalseD;
                    ButtonsDisable = buttonsdisableD;
                    FirstPlayer = firstplayerD;
                    SecondPlayer = secondplayerD;
                    FirstPlayerDisable = firstplayerdisableD;
                    SecondPlayerDisable = secondplayerdisableD;
                    ButtonCanceled = buttoncanceled;

                    FirstPlayerBanner = firstplayerbannerD;
                    SecondPlayerBanner = secondplayerbannerD;
                    DrawBanner = drawbannerD;

                    break;
            }
        }
    }
}