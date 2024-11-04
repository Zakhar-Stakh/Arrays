using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть елементи масиву через пробіл:");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.WriteLine("Парні числа у масиві:");
        PrintEvenNumbers(numbers);
    }

    static void PrintEvenNumbers(int[] array)
    {
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
}