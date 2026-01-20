using System;

class Program
{
    static void Main(string[] args)
    {
        int input = 1;
        int sum = 0;
        List<int> numbers = new List<int>();

        while (input != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");



        // for (int i = 0; i <10; i++);
        // {
        //     numbers.Add()
        // }

    }
}