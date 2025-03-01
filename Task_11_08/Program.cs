namespace Task_11_08
{
    internal class Program
    {
        /*Использование params и out: Напишите метод, который принимает переменное количество
         чисел и возвращает их сумму и максимальное значение через выходные параметры (out).*/
        // Метод, который принимает переменное количество чисел и возвращает сумму и максимальное значение
        static void CalculateSumAndMax(out int sum, out int max, params int[] numbers)
        {
            sum = 0;
            max = int.MinValue; // Инициализируем max минимально возможным значением

            // Проверяем, есть ли переданные числа
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Необходимо передать хотя бы одно число.");
            }

            // Подсчитываем сумму и находим максимальное значение
            foreach (int number in numbers)
            {
                sum += number; // Суммируем числа
                if (number > max) // Находим максимум
                {
                    max = number;
                }
            }
        }

        static void Main()
        {
            // Пример использования метода
            try
            {
                CalculateSumAndMax(out int sum, out int max, 5, 10, 3, 8, 1);
                Console.WriteLine($"Сумма: {sum}");
                Console.WriteLine($"Максимальное значение: {max}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
