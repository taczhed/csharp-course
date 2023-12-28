using System;

class Lab05Zad21
{
    static void Ex1(string[] args)
    {
        {
            var size = (Console.ReadLine()).Split(" ");
            var y = int.Parse(size[0]);
            var x = int.Parse(size[1]);
            var data = new int[y, x];

            for (int i = 0; i < y; i++)
            {
                var input = (Console.ReadLine()).Split(" ");
                for (int j = 0; j < x; j++)
                {
                    int val = int.Parse(input[j]);
                    data[i, j] = val;
                }
            }

            for (int i = 0; i < x; i++)
            {
                var row = "";
                for (int j = 0; j < y; j++)
                {

                    row += $"{data[j, i]} ";
                }
                Console.WriteLine(row.Substring(0, row.Length - 1));
            }

        }
    }
}