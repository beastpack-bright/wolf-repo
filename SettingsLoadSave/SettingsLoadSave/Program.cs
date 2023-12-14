using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Xml;

namespace SettingsLoadSave
{
    // Singleton class for managing player settings
    public sealed class PlayerSettings
    {
        private static readonly PlayerSettings instance = new PlayerSettings();

        // Properties representing player settings
        public string PlayerName { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public List<string> Inventory { get; set; }
        public string LicenseKey { get; set; }

        // Private constructor to ensure only one instance
        private PlayerSettings()
        {
            // Initialize default values
            PlayerName = "DefaultPlayer";
            Level = 1;
            Hp = 100;
            Inventory = new List<string>();
            LicenseKey = "DefaultLicenseKey";
        }

        // Public method to get the instance of the singleton class
        public static PlayerSettings Instance
        {
            get { return instance; }
        }

        // Method to save player settings to a JSON file
        public void SaveSettings(string filePath)
        {
            string json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(filePath, json);
            Console.WriteLine("Settings saved successfully.");
        }

        // Method to load player settings from a JSON file
        public void LoadSettings(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                PlayerSettings loadedSettings = JsonConvert.DeserializeObject<PlayerSettings>(json);

                // Update current instance with loaded settings
                PlayerName = loadedSettings.PlayerName;
                Level = loadedSettings.Level;
                Hp = loadedSettings.Hp;
                Inventory = loadedSettings.Inventory;
                LicenseKey = loadedSettings.LicenseKey;

                Console.WriteLine("Settings loaded successfully.");
            }
            else
            {
                Console.WriteLine("File not found. Using default settings.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Usage example
            string filePath = "playerSettings.json";

            // Save settings
            PlayerSettings.Instance.SaveSettings(filePath);

            // Change some settings
            PlayerSettings.Instance.PlayerName = "dschuh";
            PlayerSettings.Instance.Level = 4;
            PlayerSettings.Instance.Hp = 99;
            PlayerSettings.Instance.Inventory = new List<string>
            {
                "spear", "water bottle", "hammer", "sonic screwdriver", "cannonball",
                "wood", "Scooby snack", "Hydra", "poisonous potato", "dead bush", "repair powder"
            };
            PlayerSettings.Instance.LicenseKey = "DFGU99-1454";

            // Save updated settings
            PlayerSettings.Instance.SaveSettings(filePath);

            // Load settings
            PlayerSettings.Instance.LoadSettings(filePath);

            // Display loaded settings
            Console.WriteLine($"Player Name: {PlayerSettings.Instance.PlayerName}");
            Console.WriteLine($"Level: {PlayerSettings.Instance.Level}");
            Console.WriteLine($"HP: {PlayerSettings.Instance.Hp}");
            Console.WriteLine("Inventory:");
            foreach (var item in PlayerSettings.Instance.Inventory)
            {
                Console.WriteLine($"  - {item}");
            }
            Console.WriteLine($"License Key: {PlayerSettings.Instance.LicenseKey}");
        }
    }
}
