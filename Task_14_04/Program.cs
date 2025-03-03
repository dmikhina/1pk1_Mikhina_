namespace Task_14_04
{
    public class Program
    {
        /*Определите класс User, который будет иметь статическое свойство CurrentUser, 
         * представляющее текущего пользователя, и метод для его установки*/
        public static void Main(string[] args)
        {
            // Создание нового пользователя
            User user1 = new User("Иван Иванов", "ivan@example.com");

            // Установить текущего пользователя
            User.SetCurrentUser(user1);

            // Вывод информации о текущем пользователе
            Console.WriteLine($"Текущий пользователь: {User.CurrentUser.Name}, Email: {User.CurrentUser.Email}");

        }
    }
}
