using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Enter a number: ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}.");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}.");

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}.");
    }
}