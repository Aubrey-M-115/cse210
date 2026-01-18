using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        if (number >= 93)
        {
            Console.WriteLine("Congrats! You got an A!");
        }

        else if (number >= 90)
        {
            Console.WriteLine("Congrats! You got a A-!");
        }

        else if (number >= 87)
        {
            Console.WriteLine("Congrats! You got a B+!");
        }

        else if (number >= 83)
        {
            Console.WriteLine("Congrats! You got a B!");
        }

        else if (number >= 80)
        {
            Console.WriteLine("Congrats! You got a B-!");
        }

        else if (number >= 77)
        {
            Console.WriteLine("Congrats! You got a C+!");
        }

        else if (number >= 73)
        {
            Console.WriteLine("Congrats! You got a C!");
        }

        else if (number >= 70)
        {
            Console.WriteLine("Congrats! You got a C-!");
        }

        else if (number >= 67)
        {
            Console.WriteLine("Congrats! You got a D+!");
        }

        else if (number >= 63)
        {
            Console.WriteLine("Congrats! You got a D!");
        }

        else if (number >= 60)
        {
            Console.WriteLine("Congrats! You got a D-!");
        }

        else
        {
            Console.WriteLine("You got lower than a 60, so you got an F.");
        }

        if (number >= 70)
        {
            Console.WriteLine("You have passed the class!");
        }

        else
        {
            Console.WriteLine("You have failed this class. Good luck next time.");
        }
    }
}