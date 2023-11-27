using System;
using System.Drawing;

namespace Task_1
{
    [Serializable]
    public class User
    {
        public string username, email, birthday, password;
        public Image image;

        public User(){}
        
        public User(User user)
        {
            this.birthday = user.birthday;
            this.username = user.username;
            this.email = user.email;
            this.password = user.password;
            this.image = user.image;
        }
        
        public User(string username, string password, string birthday, string email)
        {
            this.birthday = birthday;
            this.username = username;
            this.email = email;
            this.password = password;
        }
        
        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}", password, username, email, birthday);
        }
    }
}