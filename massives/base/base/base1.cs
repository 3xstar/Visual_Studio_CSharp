namespace massives_base
{
    internal class base1
    {
        static void Main2(string[] args)
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

        }
    }
}
