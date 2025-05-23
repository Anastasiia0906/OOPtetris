using System.Windows;
using System.Windows.Input;

namespace Tetris
{
    public partial class ControlSettingsWindow : Window
    {
        public GameSettings Settings { get; private set; }
        private Key currentKey;
        private string currentAction;

        public ControlSettingsWindow(GameSettings settings)
        {
            InitializeComponent();
            Settings = settings;
            LoadCurrentKeys();
        }

        private void LoadCurrentKeys()
        {
            LeftKeyButton.Content = Settings.LeftKey.ToString();
            RightKeyButton.Content = Settings.RightKey.ToString();
            RotateKeyButton.Content = Settings.RotateKey.ToString();
            DownKeyButton.Content = Settings.DownKey.ToString();
            DropKeyButton.Content = Settings.DropKey.ToString();
        }

        private void KeyButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (System.Windows.Controls.Button)sender;
            currentAction = (string)button.Tag;
            button.Content = "Натисніть клавішу...";
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (currentAction != null)
            {
                currentKey = e.Key;
                UpdateButtonContent();
                currentAction = null;
                e.Handled = true;
            }
            base.OnKeyDown(e);
        }

        private void UpdateButtonContent()
        {
            switch (currentAction)
            {
                case "Left":
                    LeftKeyButton.Content = currentKey.ToString();
                    Settings.LeftKey = currentKey;
                    break;
                case "Right":
                    RightKeyButton.Content = currentKey.ToString();
                    Settings.RightKey = currentKey;
                    break;
                case "Rotate":
                    RotateKeyButton.Content = currentKey.ToString();
                    Settings.RotateKey = currentKey;
                    break;
                case "Down":
                    DownKeyButton.Content = currentKey.ToString();
                    Settings.DownKey = currentKey;
                    break;
                case "Drop":
                    DropKeyButton.Content = currentKey.ToString();
                    Settings.DropKey = currentKey;
                    break;
            }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
