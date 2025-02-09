namespace Task_10_06
{
    internal class Program
    {
        //Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n,
        //выводит на консоль сгенерированный массив размерности n*n.
        static void Main(string[] args)
        {
            // Пример вызова метода
            ArrayGeneration(5); // Сгенерирует и выведет массив 5x5
        }
        static void ArrayGeneration(int n)
        {
            // Создаем двумерный массив размерности n*n
            int[,] array = new int[n, n];
            Random random = new Random();

            // Заполняем массив случайными числами и выводим его на консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0, 10); // Случайные числа от 0 до 9
                    Console.Write(array[i, j] + " "); // Выводим элемент массива
                }
                Console.WriteLine(); // Переход на новую строку после каждой строки массива
            }
        }
    }
}
