public class Entry
{
    public string _date;
    public string _prompText;
    public string _entryText;
    public string _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Promp: {_prompText}");
        Console.WriteLine($"Mood: {_mood}/10");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }

}
