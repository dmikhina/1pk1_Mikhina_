using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01_
{
    public class Journal
    {
        public DateTime PublicationDate { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }

        public Journal(DateTime publicationDate, string subject, string title, int pageCount, decimal price)
        {
            PublicationDate = publicationDate;
            Subject = subject;
            Title = title;
            PageCount = pageCount;
            Price = price;
        }

        // Метод для покупки журнала
        public void Purchase()
        {
            Console.WriteLine($"Журнал '{Title}' куплен за {Price} рублей.");
        }

        // Метод для просмотра содержания журнала
        public void ViewContents()
        {
            Console.WriteLine($"Содержание журнала '{Title}': Тематика - {Subject}, Количество страниц - {PageCount}.");
        }
    }
}
