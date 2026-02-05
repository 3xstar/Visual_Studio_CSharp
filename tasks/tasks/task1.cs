namespace tasks
{
    internal class task1
    {
        static void Main1(string[] args)
        {
            Console.Write("Введите строку: ");
            string word = Console.ReadLine();
            Console.WriteLine(word);

            int max_count = 0;
            char max_char = word[0];

            foreach(char c in word)
            {
                int charCount = 0;
                
                foreach (char c2 in word)
                {
                    if (c == c2)
                    {
                        charCount++;
                    }
                }
                if (charCount > max_char)
                {
                    max_char = c;
                    max_count = charCount;
                }
            }

            Console.WriteLine($"Символ с наибольшим количеством: {max_char} = {max_count}");
        }
    }
}
