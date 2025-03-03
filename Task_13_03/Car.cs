using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_13_03
{
    class Car
    {
        // Свойства класса
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public double CurrentSpeed { get; private set; } // Текущая скорость, доступная только для чтения

        // Конструктор по умолчанию
        public Car()
        {
            LicensePlate = "A123BC";
            Brand = "Toyota";
            Color = "Красный";
            CurrentSpeed = 0.0;
        }
        // Конструктор с параметрами
        public Car(string licensePlate, string brand, string color)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            CurrentSpeed = 0.0;
        }

        // Метод для симуляции ускорения
        public void Accelerate(double increment)
        {
            CurrentSpeed += increment;
            Console.WriteLine($"Текущая скорость автомобиля {Brand} ({LicensePlate}): {CurrentSpeed} км/ч");
        }

        // Метод для торможения, останавливает автомобиль при превышении скорости
        public void Brake(double maxSpeed)
        {
            if (CurrentSpeed > maxSpeed)
            {
                Console.WriteLine($"Скорость превышает допустимую ({maxSpeed} км/ч). Автомобиль остановлен.");
                CurrentSpeed = 0;
            }
            else
            {
                Console.WriteLine($"Автомобиль {Brand} ({LicensePlate}) тормозит. Текущая скорость: {CurrentSpeed} км/ч.");
            }
        }

        // Метод для вывода информации об автомобиле
        public void DisplayInfo()
        {
            Console.WriteLine($"Номер авто: {LicensePlate}, Марка: {Brand}, Цвет: {Color}, Текущая скорость: {CurrentSpeed} км/ч");
        }
    }

}

