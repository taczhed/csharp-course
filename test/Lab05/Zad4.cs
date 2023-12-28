using System;

class Lab05Zad4
{
    static int[] RowToArray(int[,] board, int rowIndex)
    {
        int[] row = new int[9];
        for (int i = 0; i < 9; i++)
        {
            row[i] = board[rowIndex, i];
        }

        return row;
    }

    static int[] ColumnToArray(int[,] board, int colIndex)
    {
        int[] col = new int[9];
        for (int i = 0; i < 9; i++)
        {
            col[i] = board[i, colIndex];
        }

        return col;
    }

    static int[] SquareToArray(int[,] board, int startRow, int startCol)
    {
        int[] square = new int[9];
        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                square[index] = board[startRow + i, startCol + j];
                index++;
            }
        }

        return square;
    }

    static bool IsValid(int[] set)
    {
        string score = "123456789";
        Array.Sort(set);
        string expresion = string.Join("", set);

        if (score == expresion) return true;
        return false;
    }

    static bool CheckSudoku(int[,] board)
    {
        for (int i = 0; i < 9; i++)
        {
            if (!IsValid(RowToArray(board, i)) || !IsValid(ColumnToArray(board, i)))
            {
                return false;
            }
        }

        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < 9; j += 3)
            {
                if (!IsValid(SquareToArray(board, i, j)))
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void Zad()
    {
        int[,] board = new int[9, 9];

        for (int i = 0; i < 9; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (int j = 0; j < 9; j++)
            {
                board[i, j] = int.Parse(input[j]);
            }
        }

        if (CheckSudoku(board)) Console.WriteLine("yes");
        else Console.WriteLine("no");
    }
}