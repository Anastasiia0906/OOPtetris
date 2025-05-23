using System.Windows;

namespace Tetris
{
    public partial class SettingsWindow : Window
    {
        public GameSettings Settings { get; private set; }
        private MainWindow mainWindow;

        public SettingsWindow(GameSettings settings, MainWindow mainWindow)
        {
            InitializeComponent();
            this.Settings = settings;
            this.mainWindow = mainWindow;
            LoadSettings();
        }

        private void LoadSettings()
        {
            DifficultyComboBox.SelectedIndex = Settings.Difficulty;
            GameSpeedSlider.Value = Settings.GameSpeed;
            SoundToggleButton.Content = Settings.SoundEnabled ? "Звук: Увімкнено" : "Звук: Вимкнено";
            VolumeSlider.Value = Settings.Volume;
            ThemeToggleButton.Content = App.IsDarkTheme ? "Темна тема" : "Світла тема";
            VolumeSlider.IsEnabled = Settings.SoundEnabled;
        }

        private void SoundToggleButton_Click(object sender, RoutedEventArgs e)
        {
            Settings.SoundEnabled = !Settings.SoundEnabled;
            SoundToggleButton.Content = Settings.SoundEnabled ? "Звук: Увімкнено" : "Звук: Вимкнено";
            VolumeSlider.IsEnabled = Settings.SoundEnabled;
        }

        private void ThemeToggleButton_Click(object sender, RoutedEventArgs e)
        {
            App.IsDarkTheme = !App.IsDarkTheme;
            ThemeToggleButton.Content = App.IsDarkTheme ? "Темна тема" : "Світла тема";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Settings.Difficulty = DifficultyComboBox.SelectedIndex;
            Settings.GameSpeed = (int)GameSpeedSlider.Value;
            Settings.Volume = (int)VolumeSlider.Value;
            DialogResult = true;
            Close();
            mainWindow.ApplyTheme(App.IsDarkTheme);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
