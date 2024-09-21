using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        int grade = int.Parse(Console.ReadLine());
        char letter = ' ';
        char sign = ' ';
        int rest = grade % 10;
        
        if (grade >= 90){

            letter = 'A';

        }
        else if (grade >= 80){
            letter = 'B';
        }
        else if (grade >= 70){
            letter = 'C';
        }
        else if (grade >= 60){
            letter = 'D';
        }
        else{
            letter = 'F';
        }
        //Not sign for A or F
        if (letter != 'A' && letter != 'F')
        {
            if (rest >= 7)
            {
                sign = '+';
            }
            else
            {
                sign = '-';
            }
            
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (grade >=70 && grade <= 100){
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else {
            Console.WriteLine("Oh no! You didn't pass the course.");
        }
    }
    
}