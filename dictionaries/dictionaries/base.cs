namespace dictionaries
{
    internal class @base
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Character = new Dictionary<string, int>() { { "Лера", 100 }, { "Захар", 1 }, { "Vova", 2 } };
            Character["Никита"] = 150;
            Character["Лера"] = 50;
            Character.Add("Влад", 300000 * 3600);

            /*Console.WriteLine(Character.Capacity);
            Console.WriteLine(Character.Count);

            Character.Remove("Влад");

            foreach (var item in Character)
            {
                Console.WriteLine($"имя: {item.Key} значение: {item.Value}");
            }*/

            Dictionary<string, int> SortCharacter = new Dictionary<string, int>();

            int repeatCount = Character.Count;

            for (int i = 0; i < repeatCount; i++)
            {
                List<string> keys = new List<string>(Character.Keys);
                KeyValuePair<string, int> maxItem = new KeyValuePair<string, int>(keys[0], Character[keys[0]]);

                foreach (var element in Character)
                {
                    if (maxItem.Value < element.Value)
                    {
                        maxItem = element;
                    }
                }

                SortCharacter.Add(maxItem.Key, maxItem.Value);
                Character.Remove(maxItem.Key);
            }

            foreach (var item in SortCharacter)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
