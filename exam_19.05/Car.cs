using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace exam_19._05
{
    internal class Car
    {
        public Car(string vIN, string model, string brand, string color, string numberOfDoors, Owner owner)
        {
            VIN = vIN;
            Model = model;
            Brand = brand;
            Color = color;
            NumberOfDoors = numberOfDoors;
            Owner = owner;


        }

        public string VIN { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }   
        public string NumberOfDoors { get; set; }
        public Owner Owner { get; set; }

    }

}
