using System.Windows;
using Tetris;

namespace Tetris
{
    public partial class App : Application
    {
        // Глобальні налаштування гри, доступні з будь-якого місця в застосунку
        public static GameSettings GlobalSettings { get; private set; }

        // Прапорець, що вказує, чи активована темна тема
        public static bool IsDarkTheme { get; private set; }

        // Метод, який викликається при запуску застосунку
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Завантаження глобальних налаштувань з файлу або стандартних значень
            GlobalSettings = GameSettings.Load();
            IsDarkTheme = GlobalSettings.IsDarkTheme;

            // Застосування теми (світлої або темної) до всіх вікон, включаючи головне
            ApplyTheme(IsDarkTheme);
        }

        // Метод для застосування вибраної теми до всіх відкритих вікон
        public static void ApplyTheme(bool isDark)
        {
            // Оновлення прапорця теми та збереження налаштувань
            IsDarkTheme = isDark;
            GlobalSettings.IsDarkTheme = isDark;
            GlobalSettings.Save();

            // Проходження по всіх відкритих вікнах програми
            if (Current is App app)
            {
                foreach (Window w in app.Windows)
                {
                    // Якщо вікно підтримує теми (реалізує інтерфейс IThemableWindow), застосовуємо тему
                    if (w is IThemableWindow tw)
                        tw.ApplyTheme(isDark);
                }
            }
        }
    }
}
