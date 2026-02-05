using System;
using System.Collections.Generic;
using System.Text;

// вывести таблюцу умножения в диапазоне указаным пользователем

namespace first_code
{
    internal class task_two
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt16(Console.ReadLine()); // Конвертирует в число
            Console.WriteLine("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num1; i++)
            {
                for (int j = 1; j <= num2; j++)
                {
                    Console.WriteLine($" {j} * {i} = {j * i} ");
                }                
                Console.WriteLine();
            }
        }
    }
}