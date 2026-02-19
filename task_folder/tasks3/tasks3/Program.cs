namespace tasks3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Character = new Dictionary<string, int>() { { "Захар", 100 }, { "Лера", 70 }, { "Никита", 90 } }

            for (int i = 0; i < Character.Count; i++)
            {
                foreach (var element in Character)
                {
                    var item = element;
                }
                foreach (var item in Character)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
