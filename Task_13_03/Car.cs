using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_13_03
{
    public class Car
    {
        // Свойства автомобиля
        public string LicensePlate { get; set; } // Номер авто
        public string Brand { get; set; }         // Марка
        public string Color { get; set; }         // Цвет
        public double CurrentSpeed { get; private set; } // Текущая скорость

        private const double MaxSpeed = 150.0; // Максимально допустимая скорость

        // Конструкторы
        public Car(string licensePlate, string brand, string color)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            CurrentSpeed = 0; // Изначально скорость 0
        }

        public Car(string licensePlate, string brand) : this(licensePlate, brand, "Неопределённый") { }

        public Car() : this("Неизвестно", "Неизвестно", "Неопределённый") { }

        // Метод для имитации ускорения
        public void Accelerate(double increment)
        {
            CurrentSpeed += increment;
            if (CurrentSpeed > MaxSpeed)
            {
                CurrentSpeed = MaxSpeed; // Ограничиваем скорость максимальным значением
                
            }
            Console.WriteLine($"Автомобиль {Brand} ускоряется. Текущая скорость: {CurrentSpeed} км/ч.");
        }

        // Метод для торможения
        public void Brake()
        {
            CurrentSpeed = 0; // Останавливаем автомобиль
            Console.WriteLine($"Автомобиль {Brand} остановлен.");

        }
    }

}

