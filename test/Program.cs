using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string wejscie = Console.ReadLine();
        short[] dane = Array.ConvertAll<string, short>(wejscie.Split(" "), short.Parse);
        short a = dane[0], b = dane[1], c = dane[2];

        if (dane[1] > dane[0])
        {
            a = dane[0];
            b = dane[1];
        }
        else
        {
            a = dane[1];
            b = dane[0];
        }

        string str = "";
        for (int i = a + 1; i < b; i++)
        {
            if (i % c == 0)
            {
                str += $"{i}";
                str += "_";
            }
        }

        if (a - b == 0 || str == "")
        {
            Console.WriteLine("empty");
            return;
        }

        str = str.Remove(str.Length - 1);

        string[] listOfShorts = str.Split("_");

        if (listOfShorts.Length <= 10)
        {
            Console.Write(String.Join(", ", listOfShorts));
            return;
        }

        string[] result = { listOfShorts[0].ToString(), listOfShorts[1].ToString(), listOfShorts[2].ToString(), "...", listOfShorts[listOfShorts.Length - 2].ToString(), listOfShorts[listOfShorts.Length - 1].ToString() };

        Console.Write(String.Join(", ", result));
    }

}