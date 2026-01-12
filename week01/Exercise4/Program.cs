using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 4 Project.");
        List<int> numbers = new List<int>();
        int number = 1;

        while(number != 0)
        {
        Console.Write("Enter a number: ");
        number= int.Parse(Console.ReadLine());
        if (number != 0)            
                numbers.Add(number);          
        }

        int sum = 0;
        Console.WriteLine();
        Console.WriteLine("The list of numbers entered was: ");
        foreach (int number_ in numbers)
        {
        Console.WriteLine(number_);
        sum += number_;
        }

        Console.WriteLine();
        Console.WriteLine($"The sum of numbers entered was: {sum}");

        Console.WriteLine();
        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average of numbers entered was: {average}");

        int largest_number = numbers.Max();
        Console.WriteLine();
        Console.WriteLine($"The largest number entered was: {largest_number}");

        int smallest_number = numbers.Min();
        Console.WriteLine();
        Console.WriteLine($"The smallest number entered was: {smallest_number}");

        numbers.Sort();
        Console.WriteLine();
        Console.WriteLine("The ordered numbers in the list are: ");
        foreach (int number_ in numbers)
        {
        Console.WriteLine(number_);
        }

    }
}
