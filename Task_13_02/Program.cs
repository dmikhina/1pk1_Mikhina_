namespace Task_13_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Создание объекта с помощью конструктора с параметрами
            Pet pet2 = new Pet("Бобик", "Собака", 3, 10.5, true);
            pet2.DisplayInfo();

            // Изменение веса и состояния здоровья
            pet2.ChangeWeight(11.0);
            pet2.ChangeHealthStatus(false);
            pet2.DisplayInfo();
        }
    }
}
