using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectingActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine("--- " + GetRandomPrompt() + " ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.Clear();

        
        int timePerQuestion = (_duration -5 ) / 2;

        for (int i = 0; i < 2; i++)
        {
            Console.Write("> " + GetRandomQuestion() + " ");
            ShowSpinner(timePerQuestion);
        }
        Console.WriteLine(' ');
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int i = random.Next(_questions.Count);
        return _questions[i];
    }
}
