namespace Task_11_04
{
    internal class Program
    {
        /*Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает
         их среднее значение. Используйте ключевое слово params*/
        // Метод для вычисления среднего значения
        static double CalculateAverage(params int[] numbers)
        {
            if (numbers.Length == 0) // Проверка на пустой массив
            {
                throw new ArgumentException("Массив не должен быть пустым.");
            }

            int sum = 0;

            // Суммируем все числа
            foreach (int number in numbers)
            {
                sum += number;
            }

            // Вычисляем и возвращаем среднее значение
            return (double)sum / numbers.Length;
        }

        static void Main()
        {
            // Пример использования метода
            try
            {
                double average = CalculateAverage(1, 2, 3, 4, 5);
                Console.WriteLine($"Среднее значение: {average}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
