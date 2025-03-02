using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    class Pet
    {
        // Свойства класса
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool IsHealthy { get; set; } // true - здоров, false - нездоров

        
        // Конструктор с параметрами
        public Pet(string name, string animalType, int age, double weight, bool isHealthy)
        {
            Name = name;
            AnimalType = animalType;
            Age = age;
            Weight = weight;
            IsHealthy = isHealthy;
        }
        // Конструктор по умолчанию
        public Pet()
        {
            Name = "Бобик";
            AnimalType = "Собака";
            Age = 3;
            Weight = 10.5;
            IsHealthy = true;
        }

        // Метод для вывода информации о питомце
        public void DisplayInfo()
        {
            string healthStatus = IsHealthy ? "Здоров" : "Нездоров";
            Console.WriteLine($"Имя: {Name}, Вид: {AnimalType}, Возраст: {Age} года, Вес: {Weight} кг, Состояние здоровья: {healthStatus}");
        }

        // Метод для изменения веса животного
        public void ChangeWeight(double newWeight)
        {
            Weight = newWeight;
            Console.WriteLine($"Вес питомца {Name} изменен на {Weight} кг.");
        }

        // Метод для изменения состояния здоровья
        public void ChangeHealthStatus(bool healthStatus)
        {
            IsHealthy = healthStatus;
            Console.WriteLine($"Состояние здоровья питомца {Name} изменено на {(IsHealthy ? "Здоров" : "Нездоров")}");
        }
    }

}

