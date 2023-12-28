using System;

class Lab04Zad3
{

    static void Zad(string[] args)
    {
        try
        {
            string[] input = Console.ReadLine().Split();
            int R = int.Parse(input[0]);
            int L = int.Parse(input[1]);

            if (R < 0 || L < 0 || (L * L - R * R) < 0)
            {
                throw new ArgumentException();
            }



            double H = Math.Sqrt(L * L - R * R);
            double V = Math.PI * R * R * H / 3;
            int a = (int)Math.Floor(V);
            int b = (int)Math.Ceiling(V);

            if (a < 0 || b < 0)
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }

            Console.WriteLine($"{Math.Max(0, a)} {Math.Max(0, b)}");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("ujemny argument");
        }
    }
}