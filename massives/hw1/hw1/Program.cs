namespace hw1
{
    internal class Program
    {
        static double IMT_func(double weight, double height)
        {
            return weight / (height * height);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("_____КАЛЬКУЛЯТОР МАССЫ ТЕЛА (ИМТ)___");
                    Console.WriteLine("Введите ваш вес в килограммах (пример: 80): ");
                    double weight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите ваш рост в метрах (пример: 1,67): ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"При весе в {weight} кг и росте {height} м ваш ИМТ составляет: {IMT_func(weight, height)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка, попробуйте снова");
                }
            }
        }
    }
}
