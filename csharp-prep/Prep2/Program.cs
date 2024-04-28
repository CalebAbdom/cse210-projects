using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";


        if (grade >= 90 && grade <= 100)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
            
        }

        else if (grade>= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter  = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is an {letter}.");

        if (grade >=70)
        {
            Console.WriteLine("You Passed!");
        }

        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}