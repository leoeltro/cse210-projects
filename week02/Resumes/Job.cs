public class Job
{
public string _company = "";
public string _jobTitle = "";
public string _startYear = "";
public string _endYear = "";

public void Display()
    {
        Console.WriteLine($"Company: {_company}, Job Title: {_jobTitle}, Start Year: {_startYear}, End Year: {_endYear}");
    }
}