public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    //Constructor for PromtGenerator
    public PromptGenerator getAPrompt = new PromptGenerator();

    public void AddEntry (){
        Entry newEntry = new Entry();


        newEntry._promptText = getAPrompt.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);

        Console.WriteLine(">");
        newEntry._entryText = Console.ReadLine();
        //Function to get the Datetime
        newEntry._date = DateTime.Now.ToString("dd/MM/yyyy");

        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        //If there is a entries, we can show them

        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;

        }
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Entry: {entry._entryText}");
            Console.WriteLine(new string('-', 20));
        }
    }

    public void SaveToFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
        Console.WriteLine(" ");

    }
    public void LoadFromFile (string file){
         _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry loadedEntry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            _entries.Add(loadedEntry);
        }
        Console.WriteLine("Journal loaded successfully.");

         foreach (Entry entry in _entries)
        {
            Console.Write($"Date: {entry._date} — ");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Entry: {entry._entryText}");
            Console.WriteLine(new string('-', 30)); 
        }
        

    }

}