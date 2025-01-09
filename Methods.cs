using System;

namespace Methods
{
    public class Methods
    {
		/// <summary>
		/// Program to perform method overloading
		/// Executing functions with same name and same parameters only different type
		/// </summary>


        // Method for integer addition
        static int PlusMethod(int a, int b)
        {
            int add = a + b ;
            return add;
        }

		// Method for double addition of same name
		static double PlusMethod(double a, double b)
		{
			double add = a + b;
			return add;
		}

		static string AddString(string a, string b)
		{
			return a + b;
		}

		static void Main(String[] args)
        {
			int sum = PlusMethod(5, 15);
			double sum2 = PlusMethod(5.2, 15.5);
			Console.WriteLine(sum);
			Console.WriteLine(sum2);
			string concat = AddString("New", "Join");
			Console.WriteLine(concat);

			// Adding string by taking input
			string input1, input2;
			
			Console.WriteLine("Enter input 1 : ");
			input1 = Console.ReadLine();

			Console.WriteLine("Enter input 2 : ");
			input2 = Console.ReadLine();

			string concatInputs = AddString(input1, input2);
			Console.WriteLine(concatInputs);
		}
	}
}