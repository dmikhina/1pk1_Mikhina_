namespace Task_10_08
{
    internal class Program
    {
        /*Создайте метод, который на вход принимает одномерный массив и число для поиска, 
         * верните индекс искомого элемента в массиве. Если элемента нет – верните индекс = -1*/
        static void Main()
        {
            // Пример массива и искомого числа
            int[] array = { 10, 20, 30, 40, 50 };
            int target = 30;

            // Вызов метода поиска
            int index = FindIndex(array, target);

            // Вывод результата
            if (index != -1)
            {
                Console.WriteLine($"Элемент {target} найден по индексу: {index}");
            }
            else
            {
                Console.WriteLine($"Элемент {target} не найден в массиве.");
            }
        }

        // Метод для поиска индекса элемента в массиве
        static int FindIndex(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; // Возвращаем индекс найденного элемента
                }
            }
            return -1; // Если элемент не найден, возвращаем -1

        }
    }
}
