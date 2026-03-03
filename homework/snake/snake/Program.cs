using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPO24
{
    internal class snake
    {
        static void DrawField(List<List<char>> field)
        {
            Console.Clear();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (field[i][j] == '#')
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else if (field[i][j] == '*')
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (field[i][j] == ' ')
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();
            }
        }

        static List<List<char>> CreateField()
        {
            List<List<char>> field = new List<List<char>>();

            for (int i = 0; i < 20; i++)
            {
                field.Add(new List<char>());
                for (int j = 0; j < 20; j++)
                {
                    if (i == 0 || i == 19)
                    {
                        field[i].Add('#');
                    }
                    else if (j == 0 || j == 19)
                    {
                        field[i].Add('#');
                    }
                    else
                    {
                        field[i].Add(' ');
                    }
                }
            }
            return field;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=====SNAKE THE GAME=====");

            List<List<char>> filed = CreateField();
            int snakePosX = 1;
            int snakePosY = 1;
            int previousPosX = 1;
            int previousPosY = 1;

            while (true)
            {
                filed[snakePosY][snakePosX] = 'x';
                DrawField(filed);

                Console.Write("w - вперед, s - вниз, d - вправо, a - назад");
                char direction = Console.ReadKey().KeyChar;
                direction = char.ToLower(direction);

                filed[snakePosY][snakePosX] = ' ';
                previousPosX = snakePosX;
                previousPosY = snakePosY;

                if (direction == 'w')
                {
                    snakePosY--;
                }
                else if (direction == 's')
                {
                    snakePosY++;
                }
                else if (direction == 'd')
                {
                    snakePosX++;
                }
                else if (direction == 'a')
                {
                    snakePosX--;
                }
                if (filed[snakePosX][snakePosY] == '#' || filed[snakePosY][snakePosX] == '*')
                {
                    snakePosX = previousPosX;
                    snakePosY = previousPosY;
                }
            }
        }
    }
}