using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string fileName ="myFile.txt";
        List<int> numbers = new List<int>();
        List <string> promts = new List<string>();
        promts.Add("Who was the most interesting person I interacted with today? ");
        promts.Add("What was the best part of my day? ");
        promts.Add("How did I see the hand of the Lord in my life today? ");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("This will be the first line in the file");

            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
            outputFile.WriteLine("Who was the most interesting person I interacted with today? ");
            Console.WriteLine("Who was the most interesting person I interacted with today?");
            string response = Console.ReadLine();
            outputFile.WriteLine($"{response}");
        }
    }
}