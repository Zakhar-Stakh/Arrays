using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть елементи масиву через пробіл:");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int positiveSum = SumPositiveElements(numbers);

        Console.WriteLine("Сума всіх додатних елементів: " + positiveSum);
    }

    static int SumPositiveElements(int[] array)
    {
        int sum = 0;

        foreach (int number in array)
        {
            if (number > 0)
            {
                sum += number;
            }
        }

        return sum;
    }
}