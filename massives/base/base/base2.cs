namespace massives_base
{
    internal class base2
{
    static void Main3(string[] args)
    {
        int[,] nums = new int[3, 3]
        {
        {1,2,3 },
        {4,5,6 },
        {7,8,9 }
        };

        foreach (int item in nums)
        {
            Console.WriteLine(item);
        }

            string[][] names = new string[2][];
            names[0] = new string[] { "John", "Jane" };
            names[1] = new string[] { "Doe", "Snith" };

            foreach (string[] name1 in names)
            {
                Console.WriteLine(name1[0]);
            }
        }
    }
}

