using System;
using System.Globalization;

class Lab3Zad1
{
    static void Zad(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var i = 2;

        while (i < n)
        {
            if (n % i == 0)
            {
                Console.WriteLine("NIE");
                return;
            }
            i++;
        }

        Console.WriteLine("TAK");
    }

}