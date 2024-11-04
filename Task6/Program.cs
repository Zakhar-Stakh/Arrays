using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть елементи масиву через пробіл:");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int negativeProduct = ProductNegativeElements(numbers);

        Console.WriteLine("Добуток всіх від'ємних елементів: " + negativeProduct);
    }

    static int ProductNegativeElements(int[] array)
    {
        int product = 1;

        foreach (int number in array)
        {
            if (number < 0)
            {
                product *= number;
            }
        }

        return product;
    }
}