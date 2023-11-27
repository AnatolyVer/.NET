using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Task_1
{
    public static class FileManager
    {
        public static bool CreateUser(User user)
        {
            string folderPath = user.username;
            string fileName = "info.txt";
            string filePath = Path.Combine(folderPath, fileName);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                File.WriteAllText(filePath, user.ToString());
                if (user.image != null)
                {
                    using (Image newImage = new Bitmap(user.image))
                    {
                        newImage.Save(Path.Combine(folderPath, "photo.jpg"), ImageFormat.Jpeg);
                    }
                }
                return true;
            }
            return false;
        }
        
        public static string GetPassword(string username)
        {
            string folderPath = username;
            string fileName = "info.txt";
            string filePath = Path.Combine(folderPath, fileName);
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string password = sr.ReadLine();
                    return password;
                }
            }

            return "";
        }


        public static User GetUser(string username)
        {
            string folderPath = username;
            string fileName = "info.txt";
            string filePath = Path.Combine(folderPath, fileName);
            User user = new User();
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        string line = reader.ReadLine();

                        switch (i)
                        {
                            case 0:
                                user.password = line;
                                break;
                            case 1:
                                user.username = line;
                                break;
                            case 2:
                                user.email = line;
                                break;
                            case 3:
                                user.birthday = line;
                                break;
                        }
                    }
                }

                return user;
            }
            return null;
        }

        public static Image GetImage(string username)
        {
            string folderPath = username;
            string fileName = "photo.jpg";
            string filePath = Path.Combine(folderPath, fileName);
            if (File.Exists(filePath))
            {
                using (Image image = Image.FromFile(filePath))
                {
                    return new Bitmap(image); 
                }
            }
            using (Image image = Image.FromFile("default.jpg"))
            {
                return new Bitmap(image); 
            }
        }

        public static void ChangeUser(string username, User changed)
        {
            File.WriteAllText(username + "\\tmp.txt", changed.ToString());
            File.Copy(username + "\\tmp.txt", username + "\\info.txt", true);

            using (Image newImage = new Bitmap(changed.image))
            {
                newImage.Save(Path.Combine(username, "tmp_photo.jpg"), ImageFormat.Jpeg);
                File.Copy(Path.Combine(username, "tmp_photo.jpg"), Path.Combine(username, "photo.jpg"), true);
            }
            
            File.Delete(Path.Combine(username, "tmp_photo.jpg"));
            File.Delete(Path.Combine(username, "tmp.txt"));

            if (username != changed.username)
            {
                Directory.Move(username, changed.username);
                
            }
        }
    }
}