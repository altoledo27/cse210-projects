using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal ();
        bool startJournal = true;


        while (startJournal)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    myJournal.AddEntry();
                    break;
                case 2:
                    myJournal.DisplayAll();
                    break;
                case 3:
                    string saveFile = "journal.txt";
                    myJournal.SaveToFile(saveFile);
                    break;
                case 4:
                    string loadFile = "journal.txt";
                    myJournal.LoadFromFile(loadFile);
                    break;
                case 5:
                    startJournal = false;
                    Console.WriteLine("See you tomorrow!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        }
    }
}