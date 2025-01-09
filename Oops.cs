using System;

namespace Oops
{
	/// <summary>
	/// This program is created for understanding Oops in programming.
	/// Mainly this one is about classes and objects
	/// </summary>
	public class Car
	{
		public string color = "red";
        public int totalTravelInKm = 15240;

		public void greet()
		{
			Console.WriteLine("Hello from your car.");
		}
	}

	// leaving the field blank and modfying them later 

	public class Cars
	{
        public string model;
        public string color;
        public int year;
    }

	class Program
	{
		static void Main(String[] args)
		{
			Car myCar = new Car();
			Console.WriteLine(myCar.color);
			Console.WriteLine(myCar.totalTravelInKm);
			myCar.greet();

			Cars Ford = new Cars();
			Ford.model = "Endevour";
			Ford.year = 2022;
			Ford.color = "black";

			Console.WriteLine(Ford.color);
			Console.WriteLine(Ford.model);
			Console.WriteLine(Ford.year);
		}
	}
}
