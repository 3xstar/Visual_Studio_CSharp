using System.Globalization;

namespace tasks2
{
    internal class Program
    {
        static int find_max(int[] numbers)
        {
            int max = numbers[0];
            foreach (int i in numbers)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            return max;
        }

        static void sum_range(int[] numbers)
        {
            while (true)
            {
                try
                {
                    int start;
                    int end;
                    Console.Write("Введите цифру старта: ");
                    string IntInput = Console.ReadLine();
                    start = int.Parse(IntInput);

                    Console.Write("Введите цифру конца: ");
                    string IntInput2 = Console.ReadLine();
                    end = int.Parse(IntInput2);

                    int sum = 0;

                    for (int i = start; i < end; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine("Сумма данного промежутка: " + sum);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error. Please try again");

                }
            }
        }

        static void merge_sorted_lists(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            foreach (int i in list1) {result.Add(i);};
            foreach (int i in list2) {result.Add(i);};

            int temp;

            for(int i = 0; i < result.Count - 1; i++)
            {
                for (int j = 0; j < result.Count - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Результат сортировки обоих списков:");
            foreach (int i in result) Console.Write(i + " ");
            Console.WriteLine(" ");
        }

        static List<int> find_unique_elements(List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach(int i in numbers) 
            {
                if(numbers.Count(x => x == i) == 1)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] nums = {1, 2, 3, 4, 5};
            Console.WriteLine("Максимальное число из nums: " + find_max(nums));

            sum_range(nums);

            List<int> listone = [53, 48, 91, 13, 87, 75];
            List<int> listtwo = [46, 71, 20, 85, 34, 89];

            merge_sorted_lists(listone, listtwo);

            List<int> count_list = [1, 1, 2, 3, 3, 4, 5, 5, 6];
            Console.WriteLine("Числа встречающиеся один раз в count_list: ");
            foreach(int i in find_unique_elements(count_list))
            {
                Console.Write(i + " ");
            }
        }
    }
}
