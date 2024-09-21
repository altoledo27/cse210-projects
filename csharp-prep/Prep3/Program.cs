using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Steps 1 and 2
        //Console.Write("What is the magic number?: ");
        //int magicNumber = int.Parse(Console.ReadLine());
        int guessNumber;
        string response = " ";
        //int count = 0;
        do{
            //Generate Random numbers
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int count = 0;
            do
            {
                //Get the count of tries
                count += 1; 
                Console.WriteLine("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber > magicNumber){
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber){
                    Console.WriteLine("Higher");
                }
                else{
                    Console.WriteLine("You guessed it!");
                }
            

            }while (guessNumber != magicNumber);
            Console.WriteLine($"It took you {count} tries!");
            //Ask to the user if want to play again
            Console.WriteLine("Do you want to play again? ");
            response = Console.ReadLine();
        }while (response == "yes");
        Console.WriteLine("Thanks for playing!");       
    }
}