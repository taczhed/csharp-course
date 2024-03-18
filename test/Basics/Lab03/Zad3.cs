using System;
using System.Globalization;

class Lab3Zad3
{
    static void Zad(string[] args)
    {
        var input = (Console.ReadLine()).Split(' ');
        int x = int.Parse(input[0]), y = int.Parse(input[1]), z = int.Parse(input[2]);

        while (x > 0)
        {
            if (y > 0)
            {
                x = x - 1;
                y = y - 1;
                Console.Write("C");
                continue;
            }
            else
            {
                Console.Write("D");

                if (z > 0)
                {
                    Console.WriteLine();
                    return;
                }

                Console.Write("G");
                Console.WriteLine();
                return;
            }
        }

        Console.Write("E");
        Console.Write("G");

        Console.WriteLine();
    }

}