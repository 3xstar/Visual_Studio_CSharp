namespace tasks6
{
    //Игрок собирает ресурсы (`Stack<Resource>`),
    //но может использовать только последний собранный
    //(например, "срубил дерево → получил древесину").
    internal class task1
    {
        static void Main1(string[] args)
        {
            Stack<string> resources = new Stack<string>();

            List<string> allResources = new List<string>() { "Древесина", "Железо", "Вода", "Пшеница", "Золото" };

            while (true)
            {
                Console.WriteLine("\n1. Получить ресурс\n2. Продать ресурс\n3. Показать все ресурсы\n");
                Console.Write("Выберите действие: ");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    Random random = new Random();
                    string randomResource = allResources[random.Next(allResources.Count - 1)];
                    resources.Push(randomResource); // добавить элемент в стек
                    Console.Write($"В стек добавили {randomResource}");
                }
                else if (action == "2")
                {
                    if (resources.TryPop(out string removeResource))
                    {
                        Console.WriteLine($"Удален {removeResource}");
                    }
                    else
                    {
                        Console.WriteLine("Этого элемента нет");
                    }
                }
                else if (action == "3")
                {
                    List<string> res = resources.ToList();
                    foreach (string resource in allResources)
                    {
                        Console.WriteLine(resource);
                    }
                }
            }
        }
    }
}
