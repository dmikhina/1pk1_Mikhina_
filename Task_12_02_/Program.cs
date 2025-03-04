namespace Task_12_02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляры класса Cat
            Cat myCat = new Cat("Мурка", 3, "Чёрный", "Сиамская");
            myCat.Meow(); // Мурка говорит: Мяу!
            myCat.Play(); // Мурка играет с игрушкой!

            // Создаем экземпляры класса Dog
            Dog myDog = new Dog("Шарик", 5, "Рыжий", "Лабрадор");
            myDog.Bark(); // Шарик говорит: Гав!
            myDog.Sit(); // Шарик садится по команде!
        }
    }
    
}
