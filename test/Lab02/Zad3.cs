using System;

class Lab2Zad3
{
    static void Zad(string[] args)
    {

        var input = (Console.ReadLine()).Split(' ');

        var name = input[0];
        var age = int.Parse(input[1]);
        var retireAge = int.Parse(input[2]);


        if (age < 0 || retireAge < 0)
        {
            Console.Write("Wiek nie może być ujemny!");
            return;
        }

        else if (age >= retireAge)
        {
            Console.Write($"Witaj emerycie {name}!");
            return;
        }

        else
        {
            Console.Write($"Witaj {name}! ");

            var result = retireAge - age;

            if ((result % 10) == 1) Console.Write($"Do emerytury brakuje Ci 1 rok!");
            else if ((result % 10) > 1 && (result % 10) < 5) Console.Write($"Do emerytury brakuje Ci {result} lata!");
            else if ((result % 10) >= 5 || result > 100) Console.Write($"Do emerytury brakuje Ci {result} lat!");
        }
    }
}
