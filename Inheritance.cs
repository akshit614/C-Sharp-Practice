using System;

namespace Inheritance
{
	// Base or Parent  class
	class Vehicle
	{
		public string brand = "Ford";
		public void honk()
		{
			Console.WriteLine("peep, peep");
		}
	}

	// Derived or child class
	class Car : Vehicle // Inheritance syntax for inheriting one class to another
	{
		public string ModelName = "Mustang";
	}

	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();
			car.honk(); // we can access honk method by object of car class because of inheritance 

            Console.WriteLine(car.brand + " " + car.ModelName  + " Coming");
		}
	}
}
