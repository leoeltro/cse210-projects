using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string response = "";
        int number_entered = 0;
        do
        {
                Random randomGenerator = new Random();
                int number = randomGenerator.Next(1, 101);
                Console.WriteLine("Try to guess a number between 1 and 100");
                while (number_entered != number)
                {
                        Console.Write("Enter the number: ");
                        //string attempt = Console.ReadLine();
                        number_entered= int.Parse(Console.ReadLine());
                        if (number_entered < number)
                        {
                                Console.WriteLine();
                                Console.WriteLine("Try a higher number!");                                
                        }
                        else if (number_entered > number)
                        {
                                Console.WriteLine();
                                Console.WriteLine("Try a smaller number! ");
                        } 
                }
                Console.WriteLine();
                Console.WriteLine("You guessed the number correctly! ");              
                Console.WriteLine("Do you want to continue? Type YES or NO: ");
                response = Console.ReadLine();

        } while (response == "yes" || response == "YES");
    }
}
