using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02_
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Breed { get; set; }

        public Dog(string name, int age, string color, string breed)
        {
            Name = name;
            Age = age;
            Color = color;
            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} говорит: Гав!");
        }

        public void Sit()
        {
            Console.WriteLine($"{Name} садится по команде!");
        }
    }
}
