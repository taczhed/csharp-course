using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestExam
{
    public static void Wzorek(int n)
    {
        // tu wpisz kod
        int len = n % 2 == 0 ? n - 1 : n;

        while (len > 0)
        {
            for (int i = 0; i < (n - len) / 2; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < (n - len) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("\n");
            len = len - 2;
        }
    }

    public static double TriangleArea(int a, int b, int c, int precision = 2)
    {
        if (a <= 0 || b <= 0 || c <= 0 || precision < 2 || precision > 8)
        {
            throw new ArgumentOutOfRangeException("wrong arguments");
        }

        if (a + b < c || a + c < b || b + c < a)
        {
            throw new ArgumentException("object not exist");
        }

        double p = (a + b + c) / 2.0;
        double pole = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        return Math.Round(pole, precision);
    }

    void Fn()
    {
        try
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a + b + c) < 0)
            {
                throw new OverflowException();
            }

            Console.WriteLine(a + b + c);
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("non supported exception, exit");
        }
        catch (FormatException)
        {
            Console.WriteLine("format exception, exit");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("argument exception, exit");
        }
        catch (OverflowException)
        {
            Console.WriteLine("overflow exception, exit");
        }
    }

    public static double Srednia(int[,] tab)
    {
        if (tab.Length == 0)
        {
            return 0.00;
        }

        double sum = 0.00;
        double counter = 0.00;

        foreach (double item in tab)
        {
            if (item > 0)
            {
                sum += item;
                counter++;
            }
        }

        return Math.Round(sum / counter, 2);

    }
    internal class ExamTest
    {
    }
}
