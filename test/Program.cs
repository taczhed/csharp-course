using test.Object.Lab01;
using System;
 
// 4.7.2 .net
 
 
namespace lab1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            var n1 = new Fraction(2, 4);
            var n2 = new Fraction(2, 5);
            var add = n1 + n2;
            var minus = n1 - n2;
            var multiply = n1 * n2;
            var divide = n1 / n2;

            Console.WriteLine(add);
            Console.WriteLine(minus);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);

            var n3 = new Fraction(1, 2);
            var equal = n1 == n3;
            var notEqual = n1 != n3;
            var equals = Equals(n1, n3);
            var comapre = n1.CompareTo(n3);
            var inverse = n1.Inverse();

            Console.WriteLine(equal);
            Console.WriteLine(notEqual);
            Console.WriteLine(equals);
            Console.WriteLine(comapre);
            Console.WriteLine(inverse);

        }

    }

}
