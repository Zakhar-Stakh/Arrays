using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        double average = CalculateAverage(numbers);

        Console.WriteLine("Середнє арифметичне: " + average);
    }

    static double CalculateAverage(int[] array)
    {
        int sum = 0;

        foreach (int number in array)
        {
            sum += number;
        }

        return (double)sum / array.Length;
    }
}