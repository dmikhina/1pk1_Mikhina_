namespace Task_11_03
{
    internal class Program
    {
        /*Выходной параметр (out): Напишите метод, который принимает строку и возвращает через
         выходной параметр количество гласных и согласных букв в этой строке*/
        static void CountLetters(string input, out int vowelCount, out int consonantCount)
        {
            vowelCount = 0;
            consonantCount = 0;

            // Определяем гласные буквы (русские)
            string vowels = "аеёиоуыэюя";

            foreach (char c in input)
            {
                if (char.IsLetter(c)) // Проверяем, является ли символ буквой
                {
                    if (vowels.Contains(c)) // Проверяем, является ли буква гласной
                    {
                        vowelCount++;
                    }
                    else // Если буква не гласная, то она согласная
                    {
                        consonantCount++;
                    }
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string userInput = Console.ReadLine();

            // Объявляем переменные для хранения результатов
            int vowels, consonants;

            // Вызываем метод для подсчета
            CountLetters(userInput, out vowels, out consonants);

            // Выводим результаты
            Console.WriteLine($"Количество гласных: {vowels}");
            Console.WriteLine($"Количество согласных: {consonants}");

        }
    }
}
