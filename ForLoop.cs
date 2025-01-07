using System;
public class ForLoop
{
    //understanding loops in c#
    static void Main(string[] args)
    {
        int x, y = 1;

        for (x = 1; x <= 10; x++)
        {
            Console.WriteLine($"count : {x}");
        }

        while (y < 11)
        {
            Console.WriteLine($"Count from while loop : {y}");
            y++;
        }

        // loop for printing table of any number
        int num;
        Console.WriteLine("Enter number for printing table : ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Printing Table of {num} ->");

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine($"{num} X {i} = " + num * i);
        }
    }
}
