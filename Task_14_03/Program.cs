namespace Task_14_03
{
    internal class Program
    {
        /*Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал. 
         * Сделайте так, чтобы метод работал только для неотрицательных чисел. */
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите неотрицательное число:");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                long result = Factorial(number);
                Console.WriteLine($"Факториал {number} равен {result}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("n", "Факториал не определен для отрицательных чисел.");
            }

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
