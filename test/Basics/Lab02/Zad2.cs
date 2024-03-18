using System;

class Lab2Zad2
{
    static void Zad(string[] args)
    {

        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var retireAge = int.Parse(Console.ReadLine());

        Console.WriteLine($"Witaj, {name}!");

        if (age < 0 || retireAge < 0) Console.WriteLine("Wiek nie może być ujemny!");
        else if (age >= retireAge) Console.WriteLine("Jesteś emerytem!");
        else
        {
            var result = retireAge - age;

            if ((result % 10) == 1) Console.WriteLine($"Do emerytury brakuje Ci 1 rok!");
            else if ((result % 10) > 1 && (result % 10) < 5) Console.WriteLine($"Do emerytury brakuje Ci {result} lata!");
            else if ((result % 10) >= 5 || result > 100) Console.WriteLine($"Do emerytury brakuje Ci {result} lat!");
        }


    }
}
