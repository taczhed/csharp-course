using System;

class Lab05Bonus1
{
    static char[,] InsertNumber(char letter)
    {
        if (letter == '1')
        {
            char[,] template = {
                { ' ', ' ', ' ' },
                { ' ', ' ', '|' },
                { ' ', ' ', '|' }
            };
            return template;
        }
        if (letter == '2')
        {
            char[,] template = {
                { ' ', '_', ' ' },
                { ' ', '_', '|' },
                { '|', '_', ' ' }
            };
            return template;
        }
        if (letter == '3')
        {
            char[,] template = {
                { ' ', '_', ' ' },
                { ' ', '_', '|' },
                { ' ', '_', '|' }
            };
            return template;
        }
        if (letter == '4')
        {
            char[,] template = {
                { ' ', ' ', ' ' },
                { '|', '_', '|' },
                { ' ', ' ', '|' }
            };
            return template;
        }
        if (letter == '5')
        {
            char[,] template = {
                { ' ', '_', ' ' },
                { '|', '_', ' ' },
                { ' ', '_', '|' }
            };
            return template;
        }
        if (letter == '6')
        {
            char[,] template = {
                { ' ', '_', ' ' },
                { '|', '_', ' ' },
                { '|', '_', '|' }
            };
            return template;
        }
        if (letter == '7')
        {
            char[,] template = {
                { ' ', '_', ' ' },
                { ' ', ' ', '|' },
                { ' ', ' ', '|' }
            };
            return template;

        }
        if (letter == '8')
        {
            char[,] template = {
                { ' ', '_', ' ' },
                { '|', '_', '|' },
                { '|', '_', '|' }
            };
            return template;

        }
        if (letter == '9')
        {
            char[,] template = {
                { ' ', '_', ' ' },
                { '|', '_', '|' },
                { ' ', ' ', '|' }
            };
            return template;

        }

        char[,] tt = {
                { ' ', '_', ' ' },
                { '|', ' ', '|' },
                { '|', '_', '|' }
            };
        return tt;
    }

    static void Zad(string[] args)
    {

        var input = Console.ReadLine();

        char[,] board = new char[3, 3 * input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char[,] template = InsertNumber(input[i]);

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    board[y, (i * 3) + x] = template[y, x];
                }
            }
        }

        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3 * input.Length; x++)
            {
                Console.Write(board[y, x]);
            }
            Console.Write('\n');
        }
    }
}