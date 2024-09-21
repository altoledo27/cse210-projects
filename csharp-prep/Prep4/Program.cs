using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber;
        int sum = 0;
        double average;
        int maxNumber = -99999999;
        int minNumber = 999999999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.Write("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0){
                numbers.Add(newNumber);
                sum +=newNumber;

            }  
        }while (newNumber != 0);
        average = (double)sum / (numbers.Count);
        foreach (int number in numbers)
        {
            if(number < minNumber && number > -1){
                minNumber= number;
            }
            if (number > maxNumber){
                maxNumber = number;
            }
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {minNumber}");
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (int n in numbers){
            Console.WriteLine(n);
        }

    }
}