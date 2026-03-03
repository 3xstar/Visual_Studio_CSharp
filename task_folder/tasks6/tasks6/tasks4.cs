using System;
using System.Collections.Generic;
using System.Text;

namespace tasks6
{
    //Каждая волна — очередь врагов (`Queue<Enemy>`).
    //Когда враги заканчиваются, начинается следующая волна.
    internal class tasks4
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int waveCount = 3;
            int humanCount = 100;
            int bulletsCount = 1000;

            List<Queue<string>> waves = new List<Queue<string>>();

            for (int i = 0; i < waveCount; i++)
            {
                Queue<string> wave = new Queue<string>();
                for (int j = 0; j < random.Next(100); j++)
                {
                    int zombieChance = random.Next(0, 5);
                    if(zombieChance == 0)
                    {
                        wave.Enqueue("Зомби Танк");
                    }
                    else if (zombieChance == 1)
                    {
                        wave.Enqueue("Зомби Скелет");
                    }
                    else
                    {
                        wave.Enqueue("Зомби");
                    }
                }
                waves.Add(wave);
            }

            foreach(Queue<string> wave in waves)
            {
                Console.WriteLine($"Волна {wave.Count}");
                foreach(string enemy in wave)
                {
                    Console.WriteLine(enemy);
                }
            }
        }
    }
}
