using System;

class Lab05Zad22
{
    static int[,] ReadMatrix(int rows, int cols)
    {
        var matrix = new int[rows, cols];
        var values = Console.ReadLine().Split(" ");
        var k = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(values[k]);
                k++;
            }
        }

        return matrix;
    }

    static int[,] Multiply(int[,] matrixA, int[,] matrixB, int n1, int m1, int m2)
    {
        int[,] result = new int[n1, m2];

        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < m2; j++)
            {
                for (int k = 0; k < m1; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Ex2()
    {
        var dimensionsA = Console.ReadLine().Split(" ");
        int n1 = int.Parse(dimensionsA[0]);
        int m1 = int.Parse(dimensionsA[1]);

        var matrixA = ReadMatrix(n1, m1);

        var dimensionsB = Console.ReadLine().Split(" ");
        int n2 = int.Parse(dimensionsB[0]);
        int m2 = int.Parse(dimensionsB[1]);

        var matrixB = ReadMatrix(n2, m2);

        if (m1 != n2)
        {
            Console.WriteLine("impossible");
            return;
        }


        var result = Multiply(matrixA, matrixB, n1, m1, m2);

        PrintMatrix(result, n1, m2);
    }
}