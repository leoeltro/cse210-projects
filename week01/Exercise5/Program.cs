using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 5 Project.");
        DisplayWelcome();
        string name= PromptUserName();
        int number= PromptUserNumber();
        int square_number= SquareNumber(number);
        DisplayResult (name, square_number);
    }



    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");                  
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name= Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number= int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square_number= number*number;
        return square_number;
    }

    static void DisplayResult(string name, int square_number)
    {
        Console.WriteLine($"{name}, the square of your number is: {square_number}");
    }

}
