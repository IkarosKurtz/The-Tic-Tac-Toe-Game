namespace The_Tic_Tac_Toe_Game.Classes.Langugae
{
    public static class Languages
    {
        // Fields
        public static string Settings = "Settings";
        public static string Exit = "Exit";
        public static string Language = "Languages";
        public static string Back = "Back";
        public static string English = "English";
        public static string Spanish = "Spanish";
        public static string Restart = "Restart";
        public static string MainMenu = "MainMenu";
        public static string Dark = "Dark";
        public static string Default = "Default";
        public static string Theme = "Theme";
        public static string Player2 = "Player 2";


        // Spanish

        private static readonly string settings_S = "Opciónes";
        private static readonly string exit_S = "Salir";
        private static readonly string language_S = "Idiomas";
        private static readonly string back_S = "Atras";
        private static readonly string english_S = "Ingles";
        private static readonly string spanish_S = "Español";
        private static readonly string restart_S = "Reiniciar";
        private static readonly string mainMenu_S = "Menu Principal";
        private static readonly string dark_S = "Oscuro";
        private static readonly string default_S = "Predeterminado";
        private static readonly string theme_S = "Tema";
        private static readonly string player2_S = "Jugador 2";

        // English

        private static readonly string settings_E = "Settings";
        private static readonly string exit_E = "Exit";
        private static readonly string language_E = "Languages";
        private static readonly string back_E = "Back";
        private static readonly string english_E = "English";
        private static readonly string spanish_E = "Spanish";
        private static readonly string restart_E = "Restart";
        private static readonly string mainMenu_E = "MainMenu";
        private static readonly string dark_E = "Dark";
        private static readonly string default_E = "Default";
        private static readonly string theme_E = "Theme";
        private static readonly string player2_E = "Player 2";



        public static void ChangeLangugae(int setLanguage)
        {
            switch (setLanguage)
            {
                case 1:
                    Settings = settings_E;
                    Exit = exit_E;
                    Language = language_E;
                    Back = back_E;
                    English = english_E;
                    Spanish = spanish_E;
                    Restart = restart_E;
                    MainMenu = mainMenu_E;
                    Dark = dark_E;
                    Default = default_E;
                    Theme = theme_E;
                    Player2 = player2_E;

                    break;

                case 2:
                    Settings = settings_S;
                    Exit = exit_S;
                    Language = language_S;
                    Back = back_S;
                    English = english_S;
                    Spanish = spanish_S;
                    Restart = restart_S;
                    MainMenu = mainMenu_S;
                    Dark = dark_S;
                    Default = default_S;
                    Theme = theme_S;
                    Player2 = player2_S;

                    break;


            }
        }
    }
}
