using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine();

        //person 1
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate? ");
        decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Hours worked per week? ");
        double hoursPerWeek1 = Convert.ToDouble(Console.ReadLine());

        //person 2
        Console.WriteLine("\nPerson 2");
        Console.WriteLine("Hourly Rate? ");
        decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Hours worked per week? ");
        double hoursPerWeek2 = Convert.ToDouble(Console.ReadLine());

        //annual salary calc
        decimal annualSalary1 = hourlyRate1 * (decimal)hoursPerWeek1 * 52;
        decimal annualSalary2 = hourlyRate2 * (decimal)hoursPerWeek2 * 52;

        //output
        Console.WriteLine("\nAnnual salary of Person 1: ");
        Console.WriteLine(annualSalary1);

        Console.WriteLine("Annual salary of Person 2: ");
        Console.WriteLine(annualSalary2);

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(annualSalary1 > annualSalary2);
    }
}