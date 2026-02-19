using System;
using System.Collections.Generic;
using System.Text;

namespace tasks4
{
    internal class task1
    {
        static void Main2(string[] args)
        {
            List<int> scores = new List<int>();

            while (true)
            {
                Console.Write("Введите ваш результат: ");
                int newScore = Convert.ToInt32(Console.ReadLine());
                scores.Add(newScore);
                scores.Sort();

                if (scores.Count > 5)
                {
                    scores.RemoveAt(0);
                }

                Console.WriteLine("Список рекордов: ");
                foreach (int score in scores)
                {
                    Console.WriteLine(score);
                }
            }
        }
    }
}
