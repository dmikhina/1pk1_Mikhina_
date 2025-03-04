using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01_
{
    public class Newspaper
    {
        public DateTime PublicationDate { get; set; }
        public string Title { get; set; }
        public string MainHeadline { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }

        public Newspaper(DateTime publicationDate, string title, string mainHeadline, int pageCount, decimal price)
        {
            PublicationDate = publicationDate;
            Title = title;
            MainHeadline = mainHeadline;
            PageCount = pageCount;
            Price = price;
        }

        // Метод для покупки газеты
        public void Purchase()
        {
            Console.WriteLine($"Газета '{Title}' куплена за {Price} рублей.");
        }
    }
}
