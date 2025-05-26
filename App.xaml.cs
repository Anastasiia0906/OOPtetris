using System.Windows;
using Tetris;

namespace Tetris
{
    public partial class App : Application
    {
        public static GameSettings GlobalSettings { get; private set; }
        public static bool IsDarkTheme { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Загружаем глобальные настройки
            GlobalSettings = GameSettings.Load();
            IsDarkTheme = GlobalSettings.IsDarkTheme;
            // Применяем тему ко всем окнам (включая только-только загружаемое)
            ApplyTheme(IsDarkTheme);
        }

        public static void ApplyTheme(bool isDark)
        {
            IsDarkTheme = isDark;
            GlobalSettings.IsDarkTheme = isDark;
            GlobalSettings.Save();

            // Обновляем все открытые окна
            if (Current is App app)
            {
                foreach (Window w in app.Windows)
                {
                    if (w is IThemableWindow tw)
                        tw.ApplyTheme(isDark);
                }
            }
        }
    }
}
