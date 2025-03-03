using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04
{
    
    public class User
    {
        // Статическое свойство для хранения текущего пользователя
        public static User CurrentUser { get; private set; }

        // Свойства экземпляра класса User
        public string Name { get; set; }
        public string Email { get; set; }

        // Конструктор класса User
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        // Метод для установки текущего пользователя
        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }
    }
}
