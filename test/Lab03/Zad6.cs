using System;
using System.Globalization;
using System.Reflection;

class Lab3Zad6
{
    public static void Wzorek(int n)
    {
        if (n < 3) return;

        var size = n % 2 == 0 ? n - 1 : n;
        for (var y = 0; y < n; y++)
        {
            for (var x = 0; x < size; x++)
            {
                if (x == y || x == size - y - 1) Console.Write('*');
                else Console.Write(' ');
            }
            Console.Write('\n');
        }
    }

    static void Zad(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Wzorek(n);
    }

}