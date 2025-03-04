using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02_
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Breed { get; set; }

        public Cat(string name, int age, string color, string breed)
        {
            Name = name;
            Age = age;
            Color = color;
            Breed = breed;
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} говорит: Мяу!");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} играет с игрушкой!");
        }
    }
}
