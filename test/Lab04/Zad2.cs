using System;
using System.Globalization;


class Lab04Zad2
{
    public static double TrianglePerimeter(int a, int b, int c, int precision = 2)
    {
        if (a < 0 || b < 0 || b < 0 || precision < 2 || precision > 8) throw new ArgumentOutOfRangeException("wrong arguments");
        if (a + b < c || a + c < b || b + c < a) throw new ArgumentException("object not exist");

        return a + b + c;
    }


    static void Zad(string[] args)
    {
        Console.Write("a:");
        var a = int.Parse(Console.ReadLine());

        Console.Write("b:");
        var b = int.Parse(Console.ReadLine());

        Console.Write("c:");
        var c = int.Parse(Console.ReadLine());

        Console.Write("precision:");
        var precision = int.Parse(Console.ReadLine());


        Console.WriteLine(TrianglePerimeter(a, b, c, precision));
    }

}