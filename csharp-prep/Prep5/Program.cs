using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        number = number * number;
        Console.WriteLine("Please enter the year you were born: ");
        int pre = int.Parse(Console.ReadLine());
        int year = 2026 - pre;
        Console.WriteLine($"{name}, the square of your number is {number}");
        Console.WriteLine($"{name}, you will turn {year} this year.");
    }
}