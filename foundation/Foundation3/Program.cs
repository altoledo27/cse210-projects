using System;

class Program
{
    static void Main(string[] args)
    {
        Running run1 = new Running(DateTime.Now, 30, 4.8);
        Cycling run2 = new Cycling(DateTime.Now, 30, 20.0);
        Swimming run3 = new Swimming(DateTime.Now, 30, 5);

        Console.WriteLine(run1.GetSummary());
        Console.WriteLine(run2.GetSummary());
        Console.WriteLine(run3.GetSummary());
    }
}