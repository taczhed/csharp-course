using System;

class Lab05Zad3
{
    static char[][] ReadJaggedArrayFromStdInput()
    {
        var n = int.Parse(Console.ReadLine());
        char[][] tab = new char[n][];

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(" ");
            tab[i] = new char[input.Length];
            for (int k = 0; k < input.Length; k++)
            {
                tab[i][k] = char.Parse(input[k]);
            }
        }

        return tab;
    }

    static void PrintJaggedArrayToStdOutput(char[][] tab)
    {
        for (int y = 0; y < tab.Length; y++)
        {
            string s = "";
            for (int x = 0; x < tab[y].Length; x++)
            {
                s += $"{tab[y][x]} ";
            }
            Console.WriteLine(s.Substring(0, s.Length - 1));
        }
    }

    static char[][] TransposeJaggedArray(char[][] tab)
    {

        var max = 0;

        for (int y = 0; y < tab.Length; y++)
        {
            if (max < tab[y].Length) max = tab[y].Length;
        }

        char[][] tran = new char[max][];

        for (int y = 0; y < max; y++)
        {
            tran[y] = new char[tab.Length];
            for (int x = 0; x < tab.Length; x++)
            {
                if (x < tab.Length && y < tab[x].Length)
                {
                    tran[y][x] = tab[x][y];
                }
                else
                {
                    tran[y][x] = ' ';
                }

            }
        }

        return tran;
    }


    static void Zad(string[] args)
    {
        char[][] jagged = ReadJaggedArrayFromStdInput();
        PrintJaggedArrayToStdOutput(jagged);
        jagged = TransposeJaggedArray(jagged);
        Console.WriteLine();
        PrintJaggedArrayToStdOutput(jagged);
    }
}