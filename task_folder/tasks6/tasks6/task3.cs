using System;
using System.Collections.Generic;
using System.Text;

namespace tasks6
{
    //Храните коллекцию уникальных предметов игрока в `HashSet<string>`.
    //Попытка добавить дубликат должна выводить предупреждение.
    internal class task3
    {
        static void Main3(string[] args)
        {
            HashSet<string> inventory = new HashSet<string>();

            while (true)
            {
                Console.Write("Введите название нового элемента: ");
                string newItem = Console.ReadLine();

                if (inventory.Add(newItem)){
                    Console.WriteLine($"Элемент {newItem} добавлен в инвентарь.");
                }

                else {
                    Console.WriteLine($"Элемент {newItem} уже существует в инвентаре.");
                }

                foreach (string item in inventory)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
