using System;

class Lab04Zad2
{
    static int ConvertToInt(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) throw new ArgumentException();
        if (input.Length > 10) throw new OverflowException();
        if (!int.TryParse(input, out int result)) throw new FormatException();
        return result;
    }

    static int MultiplyNumbers(int num1, int num2, int num3)
    {
        checked
        {
            return num1 * num2 * num3;
        }
    }


    static void Zad(string[] args)
    {
        try
        {
            string input1 = Console.ReadLine();
            int number1 = ConvertToInt(input1);

            string input2 = Console.ReadLine();
            int number2 = ConvertToInt(input2);

            string input3 = Console.ReadLine();
            int number3 = ConvertToInt(input3);

            int result = MultiplyNumbers(number1, number2, number3);
            Console.WriteLine($"{result}");
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
        catch (Exception)
        {
            Console.WriteLine("non supported exception, exit");
        }
    }
}