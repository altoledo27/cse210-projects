using System;

class Program

{   //Declare functions
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(){
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;  
    }
    static int PromptUserNumber(){
        Console.WriteLine("Please enter your favorite number: ");
        int favoriteNumber= int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static int SquareNumber(int number){
        int squared = number * number;
        return squared;
    }

    static void DisplayResult(string name, int squaredNumber){
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
     
}