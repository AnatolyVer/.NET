using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Task_7
{
    public static class SettingsManager
    {
        public static void SaveSettings(string filePath, UserSettings settings)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, settings);
                }
                MessageBox.Show("Збірка збережена!",
                    "Збереження збірки",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні пресету: " + ex.Message, "Збереження пресету", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static UserSettings LoadSettings(string filePath)
        {
            UserSettings settings = new UserSettings();

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    settings = (UserSettings)formatter.Deserialize(fileStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні пресету: " + ex.Message);
            }

            return settings;
        }
    }
}