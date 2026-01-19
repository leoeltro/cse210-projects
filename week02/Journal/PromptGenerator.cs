public class PromptGenerator
{
public  List<string> _prompts = new List<string>();
string  phrase = "";

public string GetRandomPrompt()
    {
        Random random = new Random();// Create a Random object
        int randomNumber = random.Next(1, 6);
        switch (randomNumber)
        {
            case 1:
                phrase = "Who was the most interesting person I interacted with today?";
                break;
            case 2:
                phrase = "What was the best part of my day?";
                break;
            case 3:
                phrase = "How did I see the hand of the Lord in my life today?";
                break;
            case 4:
                phrase = "What was the strongest emotion I felt today?";
                break;
            case 5:
                phrase = "If I had one thing I could do over today, what would it be?";
                break;
            default:
                break;
        }
        //Console.WriteLine($"The prompt for now is: {phrase}");  
        //_prompts.Add(phrase);// Add the date to the list
        return phrase;
    }
    
     
}



