﻿namespace Task_11_07
{
    internal class Program
    {
        /*Передача массива по ссылке (ref): Напишите метод, который принимает массив целых чисел по
         ссылке и изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли
         оригинальный массив вне метода*/

        // Метод, который принимает массив по ссылке и увеличивает каждый его элемент на 1
        static void IncrementArray(ref int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += 1; // Увеличиваем каждый элемент на 1
            }
        }
        static void Main()
        {
            // Инициализация массива
            int[] originalArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Оригинальный массив:");
            Console.WriteLine(string.Join(", ", originalArray));

            // Вызываем метод для изменения массива
            IncrementArray(ref originalArray);

            // Выводим измененный массив
            Console.WriteLine("Значение вне метода:");
            Console.WriteLine(string.Join(", ", originalArray));
        }
    }
}
