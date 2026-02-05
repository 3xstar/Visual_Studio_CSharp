using System;
using System.Linq;

namespace test
{
    internal class task_one
    {

        static void Main(string[] args)
        {
            string[] inventory = new string[10];

            while (true)
            {
                Console.WriteLine("1. Add item\n"
                    + "2. Delete item\n"
                    + "3. Search item\n"
                    + "4. Show all");

                Console.Write("Введите ваш ответ: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name for new item: ");
                        string newItem = Console.ReadLine();

                        bool fillAvalible = false;

                        foreach (string item in inventory)
                        {
                            if (item == null)
                            {
                                fillAvalible = true;
                                break;
                            }
                        }

                        if (fillAvalible)
                        {
                            for (int i = 0; i < inventory.Length; i++)
                            {
                                if (inventory[i] != null)
                                {
                                    inventory[i] = newItem;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            string[] newInventory = new string[inventory.Length + 1];
                            Array.Copy(inventory, newInventory, inventory.Length);
                            newInventory[inventory.Length] = newItem;
                            inventory = newInventory;
                        }
                        int test = Array.IndexOf(inventory, newItem);
                        Console.WriteLine(test);
                        break;


                    case 2:
                        break;

                    case 3:
                        Console.Write("Enter name of item: ");
                        string searchItem = Console.ReadLine();
                        int ind = 1;

                        foreach (string item in inventory)
                        {
                            if (item != null)
                            {
                                ind++;
                                if (searchItem == item)
                                {
                                    Console.WriteLine("Предмет найден");
                                    Console.WriteLine($"{ind}. {item}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Предмет не найден");
                                }
                            }

                        }
                        break;

                    case 4:
                        int index = 1;
                        foreach (string item in inventory)
                        {
                            if (item != null)
                            {
                                Console.WriteLine($"{index}. {item}");
                                index++;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
