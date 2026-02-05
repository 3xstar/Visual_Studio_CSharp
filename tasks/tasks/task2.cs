using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class task2
    {
        static void Main2(string[] args)
        {
            Console.Write("Введите предложение: ");
            string word = Console.ReadLine();
            Console.WriteLine(word);

            string[] wordsArray = word.Split();

            Console.WriteLine($"Количество слов в предложении: {wordsArray.Length}");
        }
    }
}
