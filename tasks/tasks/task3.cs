using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class task3
    {
        static void Main(string[] args)
        {
            char[] chars = {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й',
              'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф',
              'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'
            };

            int shiftStep = 3;

            Console.Write("Введите строку: ");
            string? word = Console.ReadLine().ToLower();

            string secretWord = string.Empty;

            foreach(char с in word)
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == с)
                    {
                        int newIndex = i + shiftStep;
                        if (newIndex > chars.Length - 1)
                        {
                            newIndex -= chars.Length;
                        }
                        secretWord = string.Concat(secretWord, chars[newIndex]);
                        break;
                    }
                }
            }
            Console.WriteLine($"Слово под шифром цезаря: {secretWord}");

        }
    }
}
