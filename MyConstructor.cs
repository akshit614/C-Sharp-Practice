using System;

namespace MyConstructor
{
    class Car
    {
        public string model;
        public Car()
        {
            model = "Safari"; // setting initial value for model using constructor
        }

        static void Main(string[] args)
        {
            Car Tata = new Car();
            Tata.model = "Altroz"; // setting manually if we want later
            Console.WriteLine(Tata.model);
        }
    }

    // Constructor Parameters example
    //class Car
    //{
    //    public string model;

    //    public Car (string modelName)
    //    {
    //        model = modelName;
    //    }
        
    //    static void Main(string[] args)
    //    {
    //        Car myCar = new Car("Fortuner");
    //        Console.WriteLine(myCar.model);
    //    }
    //}

}


