using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть елементи масиву через пробіл:");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.WriteLine("Введіть елемент, для якого потрібно знайти найменший індекс:");
        int target = int.Parse(Console.ReadLine());

        int index = FindFirstIndex(numbers, target);

        if (index != -1)
        {
            Console.WriteLine("Найменший індекс елемента " + target + ": " + index);
        }
        else
        {
            Console.WriteLine("Елемент " + target + " не знайдено у масиві.");
        }
    }

    static int FindFirstIndex(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i; 
            }
        }

        return -1;
    }
}