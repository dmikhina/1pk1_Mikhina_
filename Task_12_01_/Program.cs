namespace Task_12_01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Создаем экземпляр книги
        Book myBook = new Book("1984", "Джордж Оруэлл");

        // Выдаем книгу
        myBook.BorrowBook(); // Книга '1984' выдана.

        // Пытаемся вернуть книгу
        myBook.ReturnBook(); // Книга '1984' возвращена. Статус: свободна.

        // Проверяем статус книги
        Console.WriteLine($"Статус книги '{myBook.Title}': {(myBook.IsAvailable ? "доступна" : "занята")}");
            // Создаем экземпляр журнала
            Journal myJournal = new Journal(DateTime.Now, "Наука", "Мир животных", 50, 300);
            myJournal.Purchase(); // Журнал 'Мир животных' куплен за 300 рублей.
            myJournal.ViewContents(); // Содержание журнала 'Научный обзор': Тематика - Наука, Количество страниц - 50.

            // Создаем экземпляр газеты
            Newspaper myNewspaper = new Newspaper(DateTime.Now, "Зори", "Главные события дня", 20, 50);
            myNewspaper.Purchase(); // Газета 'Зори' куплена за 50 рублей.
        }
    }
}
