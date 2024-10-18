using System;

class Program
{
    static void Main(string[] args)
    {
        bool startMindfulness = true;
        //Exceeding requirements: Keep a log of how many activities were performed.
        int count = 0;


        while (startMindfulness)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    count++;
                    break;
                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    count++;
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    count++;
                    break;
                case 4:
                    startMindfulness = false;
                    if (count != 0)
                    {
                        Console.WriteLine($"Congratulations! You made {count} activities! See you next time!");

                    }
                    else{
                        Console.WriteLine("We hope you have more time next time! See you soon!");
                    }
                    
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}