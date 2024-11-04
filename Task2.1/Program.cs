using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть розмір матриці (n x n):");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        Console.WriteLine("Введіть елементи матриці:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"matrix[{i},{j}] = ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int diagonalSum = SumMainDiagonal(matrix, n);

        Console.WriteLine("Сума елементів по головній діагоналі: " + diagonalSum);
    }

    static int SumMainDiagonal(int[,] matrix, int size)
    {
        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }
}