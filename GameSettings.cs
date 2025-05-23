using System.IO;
using System.Windows.Input;
using System.Xml.Serialization;

namespace Tetris
{
    public class GameSettings
    {
        public int Difficulty { get; set; } = 1;
        public int GameSpeed { get; set; } = 5;
        public bool SoundEnabled { get; set; } = true;
        public int Volume { get; set; } = 70;
        public bool IsDarkTheme { get; set; } = false;

        public Key LeftKey { get; set; } = Key.Left;
        public Key RightKey { get; set; } = Key.Right;
        public Key RotateKey { get; set; } = Key.Up;
        public Key DownKey { get; set; } = Key.Down;
        public Key DropKey { get; set; } = Key.Space;

        private const string SettingsFile = "settings.xml";

        public static GameSettings Load()
        {
            if (File.Exists(SettingsFile))
            {
                using var reader = new StreamReader(SettingsFile);
                var serializer = new XmlSerializer(typeof(GameSettings));
                return (GameSettings)serializer.Deserialize(reader);
            }
            return new GameSettings();
        }

        public void Save()
        {
            using var writer = new StreamWriter(SettingsFile);
            var serializer = new XmlSerializer(typeof(GameSettings));
            serializer.Serialize(writer, this);
        }
    }
}
