using System.Windows;

namespace Tetris
{
    public partial class App : Application
    {
        public static bool IsDarkTheme { get; set; } = false;
        public static GameSettings GlobalSettings { get; private set; } = new GameSettings();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            GlobalSettings = GameSettings.Load();
            IsDarkTheme = GlobalSettings.IsDarkTheme;
            ApplyTheme(IsDarkTheme);
        }

        public static void ApplyTheme(bool isDarkTheme)
        {
            IsDarkTheme = isDarkTheme;
            GlobalSettings.IsDarkTheme = isDarkTheme;
            GlobalSettings.Save();

            var app = Current as App;
            if (app != null)
            {
                foreach (Window window in app.Windows)
                {
                    if (window is IThemableWindow themableWindow)
                    {
                        themableWindow.ApplyTheme(isDarkTheme);
                    }
                }
            }
        }
    }
}
