
// W02 Project: Journal Program

// Author: Leonardo Barbosa Lima Gouvea
/*
The program performs the following tasks:

1) Typing 1 provides the date and a random prompt (there are 5 in total), and the user must enter an answer.

After typing the answer, the user is asked if they want to continue, and the main menu is displayed again. With each iteration, typing y continues the program, but typing n stops the prompt and exits the program.

If you are in the main menu and type option 5, you also exit the program.



2) Option 2 oShows the complete history for each date, and prompts and answers you typed previously.
It is displayed line by line. 



3) Option 3 loads a file that you previously saved. You must enter the file name.  
All the content of the file is displayed on the screen when the file is loaded.

4) Menu number 4 saves a file, You must enter the file name.


5) Option 5 exits the program.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net;
//public static string global_text;

public class Program
{
    static List<Entry> _entries = new List<Entry>();

    static void Main(string[] args)
    {
        //Console.Clear();
        
        PromptGenerator _PromptGenerator = new PromptGenerator();
        string response;
        
        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Please select one to about Your diary: ");
            string choice = Console.ReadLine();
            int numberChoice = int.Parse(choice);
            Console.WriteLine();
            //Console.WriteLine($"You selected: {numberChoice}.");



            switch (numberChoice)
            {
                case 1:
                    Console.Write("Date: "); //  date
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToString("yyyy-MM-dd HH:mm:ss");
                    Console.WriteLine(dateText);


                    string _prompt;
                    _prompt = _PromptGenerator.GetRandomPrompt(); //Console.WriteLine();
                    Console.WriteLine($"The prompt for now is: {_prompt}");
                    

                    Console.Write("Type about your personal responde: ");// Prompt user to type the text
                    string _response = Console.ReadLine();
                    Console.WriteLine();

                    Entry entry_class_instance = new Entry();
                    entry_class_instance._date = dateText;
                    entry_class_instance._promptText = _prompt;
                    entry_class_instance._entryText = _response;

                    _entries.Add(entry_class_instance);
                    entry_class_instance = null;
                    break;


                case 2:
                    Console.WriteLine($"All prompts and answers will now be shown: ");
                    Console.WriteLine();
                    for (int i = 0; i < _entries.Count; i++) // Display all prompts in the list
                    {
                        Console.WriteLine(_entries[i]._date);
                        Console.WriteLine(_entries[i]._promptText);
                        Console.WriteLine(_entries[i]._entryText);
                        Console.WriteLine();
                    }
                    break;


                case 3:
                    Console.Write("Enter the name of the txt file to be UPLOADED for example xxxxxxx.txt: ");
                    string filename = Console.ReadLine();
                    

                    List<string> lines = new List<string>();
                    if (File.Exists(filename))
                    {
                        lines.AddRange(File.ReadAllLines(filename));
                    }
                    Console.WriteLine($"The file {filename} was loaded: ");


                    Console.WriteLine($"The contents of the file {filename} will be displayed : ");
                    Console.WriteLine();

                    for (int i = 0; i < lines.Count; i++) // Display all prompts in the list
                    {
                        Console.WriteLine(lines[i]);
                    }
                    break;


                case 4:
                    Console.Write("Enter the name of the txt file to be SAVED for example xxxxxxx.txt: ");
                    filename = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        for (int i = 0; i < _entries.Count; i++)
                        {
                            outputFile.WriteLine(_entries[i]._date);
                            outputFile.WriteLine(_entries[i]._promptText);
                            outputFile.WriteLine(_entries[i]._entryText);
                            outputFile.WriteLine();
                        }
                    }
                    break;


                case 5:
                    Environment.Exit(0);
                    // Quit
                    break;

                default:
                    break;



            }
            Console.Write("Type y to continue or n to end? y or n:  ");
            response = Console.ReadLine();
        } while (response.ToLower() == "y");
        Console.WriteLine();


    }


}





