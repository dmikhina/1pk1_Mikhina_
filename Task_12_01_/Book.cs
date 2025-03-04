using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01_
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; private set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsAvailable = true; // Книга доступна по умолчанию
        }

        // Метод для возврата книги
        public void ReturnBook()
        {
            IsAvailable = true; // Устанавливаем статус книги в "свободен"
            Console.WriteLine($"Книга '{Title}' возвращена. Статус: свободна.");
        }

        // Метод для выдачи книги
        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false; // Устанавливаем статус книги в "занята"
                Console.WriteLine($"Книга '{Title}' выдана.");
            }
            else
            {
                Console.WriteLine($"Книга '{Title}' недоступна.");
            }
        }
    }
}
