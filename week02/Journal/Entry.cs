public class Entry
{
public string _date = "";
public string _promptText = "";
public string _entryText = "";

public void Display()
    {
        Console.WriteLine($"Date: {_date}, Job Title: {_promptText}, Start Year: {_entryText}");
    }
}

