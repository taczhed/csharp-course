using System;
using System.Globalization;

class Zad4
{
    static void Zad(string[] args)
    {

        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        var input = (Console.ReadLine()).Split(';');
        double a, b, c;

        if (!double.TryParse(input[0], out a) || !double.TryParse(input[1], out b) || !double.TryParse(input[2], out c))
        {
            Console.WriteLine("Błędne dane. Podane wartości nie są liczbami zmiennoprzecinkowymi.");
            return;
        }

        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
            return;
        }

        if (!(a + b >= c && a + c >= b && b + c >= a))
        {
            Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
            return;
        }

        double[] sides = { a, b, c };
        Array.Sort(sides);

        var circuit = a + b + c;
        var half = circuit / 2;
        var pole = Math.Sqrt(half * (half - a) * (half - b) * (half - c));

        string type;
        if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2)) type = "prostokątny";
        else if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) < Math.Pow(sides[2], 2)) type = "rozwartokątny";
        else type = "ostrokątny";

        Console.WriteLine($"obwód = {circuit:F2}");
        Console.WriteLine($"pole = {pole:F2}");
        Console.WriteLine($"trójkąt jest {type}");

        if (a == b && b == c) Console.WriteLine("trójkąt równoboczny");
        else if (a == b || b == c || c == a) Console.WriteLine("trójkąt równoramienny");
    }
}
