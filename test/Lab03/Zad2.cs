using System;
using System.Globalization;

class Lab3Zad2
{
    static void Zad(string[] args)
    {
        var input = (Console.ReadLine()).Split(' ');
        int x = int.Parse(input[0]), y = int.Parse(input[1]), z = int.Parse(input[2]);

    beforeX:

        if (x > 0)
        {
            if (y > 0)
            {
                x--;
                y--;
                Console.Write("C");
                goto beforeX;
            }
            else
            {
                Console.Write("D");

                if (z > 0)
                {
                    goto writeLine;
                }

            }
        }
        else
        {
            Console.Write("E");
        }

        Console.Write("G");

    writeLine:

        Console.WriteLine();
    }

}