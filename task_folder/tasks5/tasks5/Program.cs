namespace task5
{
    internal class Program
    {
        static Queue<Dictionary<string, string>> AddTaks(Queue<Dictionary<string, string>> tasks)
        {
            Dictionary<string, string> task = new Dictionary<string, string>();
            Console.Write("Введите название квеста: ");
            string name = Console.ReadLine();
            task["Name"] = name;

            Console.Write("Введите награду за квест: ");
            string reward = Console.ReadLine();
            task["Reward"] = reward;

            task["IsCompleted"] = "Не выполнено";
            tasks.Enqueue(task);
            return tasks;
        }

        static Queue<Dictionary<string, string>> CompleteTaks(Queue<Dictionary<string, string>> tasks)
        {
            string name = tasks.Peek()["Name"];
            string reward = tasks.Peek()["Reward"];
            Console.WriteLine($"Задание {name} выполнено и получена награза {reward} золотых");
            tasks.Dequeue();
            return tasks;
        }

        static void ShowAllTasks(Queue<Dictionary<string, string>> tasks)
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Название {task["Name"]} | Награда {task["Reward"]}");
            }
        }


        static void Main(string[] args)
        {
            Dictionary<string, string> task1 = new Dictionary<string, string>()
           {
               {"Name", "Убить чудище"},
               {"Reward", "1000"},
               {"IsCompleted", "не выполнено"}
           };
            Dictionary<string, string> task2 = new Dictionary<string, string>()
           {
               {"Name", "Убить вампира"},
               {"Reward", "1800"},
               {"IsCompleted", "не выполнено"}
           };

            Queue<Dictionary<string, string>> tasks = new Queue<Dictionary<string, string>>();
            tasks.Enqueue(task1);

            List<Dictionary<string, string>> tasksList = tasks.ToList();
            tasksList.Insert(0, task2);
            tasks = new Queue<Dictionary<string, string>>(tasksList);

            while (true)
            {
                Console.Write("Меню: \n" +
                    "1. Добавить задание \n" +
                    "2. Выполнить задание \n" +
                    "3. Посмотреть все задания\n" +
                    "Введите номер действия: ");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        tasks = AddTaks(tasks);
                        break;
                    case "2":
                        tasks = CompleteTaks(tasks);
                        break;
                    case "3":
                        ShowAllTasks(tasks);
                        break;
                    default:
                        Console.WriteLine("Не корректное значение");
                        break;
                }
            }
        }
    }
}