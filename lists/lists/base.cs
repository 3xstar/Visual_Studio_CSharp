using System.Collections.Concurrent;
using System.Runtime.Intrinsics.Arm;

namespace lists
{
    internal class @base
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(12);
            numbers.AddRange([121, 34123, 2323]);
            numbers.Remove(12);
            bool isNum = numbers.Contains(121);
            Console.WriteLine(isNum);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(numbers[1]);

            Console.WriteLine();
            List<int> numNew = numbers[1..3];
            List<int> numEnd = numbers[1..];
            List<int> numNStart = numbers[..2];

            foreach (int i in numbers)
            {
                Console.WriteLine(i); 
            }
        }
    }
}
