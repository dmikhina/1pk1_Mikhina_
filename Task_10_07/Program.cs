namespace Task_10_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] charArray = GenerateCharArray(5, 5); // Генерируем массив 5x5
            PrintCharArray(charArray); // Выводим массив на консоль
        }
        static char[,] GenerateCharArray(int rows, int cols)
        {
            char[,] array = new char[rows, cols];
            Random random = new Random();

            // Символы русского алфавита (от 'А' до 'я')
            char[] russianAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Генерируем случайный индекс для выбора символа из русского алфавита
                    int index = random.Next(russianAlphabet.Length);
                    array[i, j] = russianAlphabet[index];
                }
            }

            return array;
        }

        static void PrintCharArray(char[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(); // Переход на новую строку после завершения строки
            }
        }
    }
}
