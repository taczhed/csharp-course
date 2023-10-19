using System;

    class Zad1
    {
    static void Zad(string[] args)
    {

        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var retireAge = int.Parse(Console.ReadLine());

        Console.WriteLine($"Witaj, {name}!");

        if (age < 0 || retireAge < 0) Console.WriteLine("Wiek nie może być ujemny!");
        else if (age < retireAge) Console.WriteLine($"Do emerytury brakuje Ci {retireAge - age} lat!");
        else Console.WriteLine("Jesteś emerytem!");

    }
}
