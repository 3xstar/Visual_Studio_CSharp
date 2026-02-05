using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_methods
{
    internal class task2_3
    {
        static int word_count(string sentence)
        {
            int counter = 0;

            foreach (char c in sentence)
            {
                if (char.IsWhiteSpace(c))
                {
                    counter++;
                }
            }
            return counter + 1;
        }

        static int intInput(string text)
        {
            do
            {
                Console.Write(text);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int num))
                {
                    return num;
                }
            } while (true);
        }

        static void Main(string[] args)
        {
            /*Console.Write("Введите предложение: ");
            string inputSentence = Console.ReadLine();

            Console.Write($"Введите предложение: {word_count(inputSentence)}");*/

            Console.WriteLine(intInput("Введите ваше число: "));
        }
    }
}
