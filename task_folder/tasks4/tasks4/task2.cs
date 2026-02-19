using System;
using System.Collections.Generic;
using System.Text;

namespace tasks4
{
    internal class task2
    {
        static Dictionary<string, int> AddSpell(Dictionary<string, int> spells)
        {
            Console.Write("Введите название заклинания: ");
            string nameOfSpell = Console.ReadLine();

            Console.Write("Введите урон заклинания: ");
            int damageOfSpell = Convert.ToInt32(Console.ReadLine());

            spells[nameOfSpell] = damageOfSpell;
            return spells;
        }

        static void GetDamage(Dictionary<string, int> spells)
        {
            Console.Write("Введите название заклинания: ");
            string user_spell = Console.ReadLine();
            if (spells.ContainsKey(user_spell))
            {
                Console.WriteLine($"Урон заклинания {user_spell} - {spells[user_spell]}");
            }
            else
            {
                Console.WriteLine("Такого заклинания нет.");
            }
        }

        static Dictionary<string, int> RemoveSpell(Dictionary<string, int> spells)
        {
            Console.Write("Введите название заклинания: ");
            string nameOfSpell = Console.ReadLine();

            if (spells.ContainsKey(nameOfSpell))
            {
                spells.Remove(nameOfSpell);
            }
            else
            {
                Console.WriteLine("Такого заклинания нет.");
            }
            return spells;
        }


        static void Main(string[] args)
        {
            Dictionary<string, int> spells = new Dictionary<string, int>();
            spells.Add("Абракадабра", 100);
            spells.Add("Эспекто патронум", 200);
            spells.Add("Авадакидабра", 300);

            while (true)
            {
            Console.WriteLine("Выберите действие:\n1.Добавить заклинание\n2.Получить урон\n3.Удалить заклинание\nВведите номер действия: ");

            int action = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        spells = AddSpell(spells);
                        break;
                    case 2:
                        GetDamage(spells);
                        break;
                    case 3:
                        spells = RemoveSpell(spells);
                        break;
                    default:
                        Console.WriteLine("Неверный номер действия");
                        break;
                }
            }
        }
    }
}
