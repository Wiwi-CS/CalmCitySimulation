using System.IO;
using UnityEngine;

namespace CalmCity
{
    public static class CalmCityConfig
    {
        private static string filePath =
            System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData)
            + "\\Colossal Order\\Cities_Skylines\\CalmCityConfig.txt";

        public static int CitizenMode = 1;
        public static int TouristMode = 1;

        public static int GetCitizenCooldown()
        {
            switch (CitizenMode)
            {
                case 0: return 0;
                case 1: return 25;
                case 2: return 50;
                case 3: return 75;
                case 4: return 110;
                default: return 50;
            }
        }

        public static int GetTouristCooldown()
        {
            switch (TouristMode)
            {
                case 0: return 0;
                case 1: return 20;
                case 2: return 45;
                case 3: return 75;
                case 4: return 95;
                default: return 25;
            }
        }

        public static void Load()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    if (lines.Length >= 2)
                    {
                        int.TryParse(lines[0], out CitizenMode);
                        int.TryParse(lines[1], out TouristMode);
                    }
                }
                else
                {
                    Save();
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError("[CalmCity] Load Fehler: " + e.Message);
            }
        }

        public static void Save()
        {
            try
            {
                string[] lines = new string[]
                {
                    CitizenMode.ToString(),
                    TouristMode.ToString()
                };

                File.WriteAllLines(filePath, lines);
            }
            catch (System.Exception e)
            {
                Debug.LogError("[CalmCity] Save Fehler: " + e.Message);
            }
        }
    }
}