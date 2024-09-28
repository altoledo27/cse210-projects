public class PromptGenerator
{
    public List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?", 
                                        "What was the best part of my day?", 
                                        "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", 
                                        "If I had one thing I could do over today, what would it be?", "What are three things I am grateful for today?", 
                                        "What challenge did I face today, and how did I handle it?", "What progress have I made toward my goals this week?",
                                        "Who makes me feel happiest in life and why?"};
    
    public string GetRandomPrompt()
    {
        //Generate a random number to select in the index from _prompts
        Random rnd = new Random();
        int n = rnd.Next(0,_prompts.Count);
        return _prompts[n];
    }
}