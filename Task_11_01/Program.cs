namespace Task_11_01
{
    internal class Program
    {
        /*Передача по значению: Напишите метод, который принимает два целых числа и меняет их
        местами. Проверьте, изменились ли значения переменных вне метода*/
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 15;

            Console.WriteLine($"{a} {b}");

            (a, b) = (b, a); // обмен

            Console.WriteLine($"Значение вне метода {a} {b}");

        }
    }
}
