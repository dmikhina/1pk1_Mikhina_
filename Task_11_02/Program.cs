using System.Security.Cryptography;

namespace Task_11_02
{
    internal class Program
    {
        /*Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и
          меняет их местами. Проверьте, изменились ли значения переменных вне метода*/
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 5;
            Increment(ref num1,ref num2);
        }
        static void Increment(ref int num1, ref int num2)
        {
            Console.WriteLine($"значение внутри метода {num1} {num2}");

            (num1, num2) = (num2, num1); // обмен

            Console.WriteLine($"значение вне метода {num1} {num2}");
        }
    }
}
