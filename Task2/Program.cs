using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть елементи масиву через пробіл:");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        bool isPalindrome = IsPalindrome(numbers);

        if (isPalindrome)
        {
            Console.WriteLine("Масив є паліндромом.");
        }
        else
        {
            Console.WriteLine("Масив не є паліндромом.");
        }
    }

    static bool IsPalindrome(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            if (array[left] != array[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}