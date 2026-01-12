using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

         Console.Write("Enter the student's grade percentage: ");
         string grade = Console.ReadLine();
         int grade_number= int.Parse(grade);

         string grade_letter = "";

         if(grade_number >= 90)
                grade_letter= "A";

         else if(grade_number >= 80)
                grade_letter= "B";

         else if(grade_number >= 70)
                grade_letter= "C";                

         else if(grade_number >= 60)
                grade_letter= "D";

         else if(grade_number <= 60)
                grade_letter= "f";  

        else
                Console.WriteLine("The number entered is outside the allowed range!");


        string grade_symbol= "";
        int rest = grade_number % 10;

        if (rest < 3 && grade_number >= 60)
            grade_symbol= "-";

        if (rest >= 7 && grade_number >= 60 && grade_number < 90)
            grade_symbol= "+";           


        Console.Write($"The letter grade used for grading was: {grade_letter}{grade_symbol}");

    }
}
