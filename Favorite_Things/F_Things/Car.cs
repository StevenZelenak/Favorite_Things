using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.F_Things
{
    class Car
    {
        //Properties
        public string Model { get; set; }

        public string Type { get; set; }
        public int ModelYear { get; set; }

        //constructor
        public Car(string model, string type, int modelyear)
        {
            Model = model;
            Type = type;
            ModelYear = modelyear;
            Console.WriteLine($"Your Car is a {model} {type} and the model year is {modelyear}");
        }

        //Methods
        public void IsTheCarDamaged(bool isdamaged)
        {
            if (isdamaged)
            {
                Console.WriteLine($"This car is wrecked!");
            }
            else
            {
                Console.WriteLine($"This car is perfect!");
            }
        }
    }
}
