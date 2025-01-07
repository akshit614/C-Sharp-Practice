using System;

namespace FirstProgram
{
    // program for "if else" conditional control flow statements
    class FirstProgram
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 2;
            int y = 3;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("y is greater than x");
            }
        }
    }
}