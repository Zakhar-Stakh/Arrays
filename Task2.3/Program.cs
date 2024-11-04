using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть розмір квадратної матриці (n x n):");
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

        Console.WriteLine("Оригінальна матриця:");
        PrintMatrix(matrix, n);

        RotateMatrixClockwise(matrix, n);

        Console.WriteLine("Матриця після обертання на 90 градусів за годинниковою стрілкою:");
        PrintMatrix(matrix, n);
    }

    static void RotateMatrixClockwise(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size / 2; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, size - 1 - j];
                matrix[i, size - 1 - j] = temp;
            }
        }
    }

    static void PrintMatrix(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
} //Воно повертає за, я не знаю як його правильно зробити, навіть інтернет не дуже поміг