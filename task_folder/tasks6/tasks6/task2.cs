using System;
using System.Collections.Generic;
using System.Text;

namespace tasks6
{
    //Сообщения от игроков (`Queue<string>`)
    //выводятся по очереди. Если очередь > 10,
    //старые сообщения удаляются.
    internal class task2
    {
        static void Main2(string[] args)
        {
            Queue<string> messages = new Queue<string>();

            while (true)
            {
                Console.Write("Введите сообщение: ");
                string message = Console.ReadLine();
                messages.Enqueue(message);

                foreach (string m in messages)
                {
                    Console.WriteLine(m);
                }

                if (messages.Count > 10)
                {
                    messages.Dequeue();
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
        
    }
}
