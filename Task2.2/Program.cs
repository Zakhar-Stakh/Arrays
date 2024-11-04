using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть розмір матриці (n x m):");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];
        Console.WriteLine("Введіть елементи матриці:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"matrix[{i},{j}] = ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Введіть номер стовпця для обчислення добутку:");
        int columnIndex = int.Parse(Console.ReadLine());

        if (columnIndex < 0 || columnIndex >= m)
        {
            Console.WriteLine("Невірний номер стовпця.");
        }
        else
        {
            int columnProduct = ProductOfColumn(matrix, n, columnIndex);
            Console.WriteLine("Добуток елементів у стовпці " + columnIndex + ": " + columnProduct);
        }
    }

    static int ProductOfColumn(int[,] matrix, int rows, int columnIndex)
    {
        int product = 1;

        for (int i = 0; i < rows; i++)
        {
            product *= matrix[i, columnIndex];
        }

        return product;
    }
}
