namespace Task_11_05
{
    internal class Program
    {
        /*Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и
         возвращает их сумму и произведение через выходные параметры (out)*/
        
        // Метод, который принимает два числа по ссылке и возвращает сумму и произведение через out параметры
        static void Calculate(ref int a, ref int b, out int sum, out int product)
        {
            // Рассчитываем сумму и произведение
            sum = a + b;
            product = a * b;
        }
        static void Main()
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"Исходные значения: x = {x}, y = {y}");

            // Вызываем метод Calculate
            Calculate(ref x, ref y, out int sum, out int product);

            // Выводим результаты
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
        }
    }
}
