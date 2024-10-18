class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine("--- " + GetRandomPrompt() + " ---");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine(" ");

        List<string> items = GetListFromUser();

        Console.WriteLine($"You listed {items.Count} items.\n");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        var startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            items.Add(userInput);
        }

        return items;
    }
}