using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace exam_19._05
{
    internal class ParkingLot
    {
        public ParkingLot(int id, string address, int capacity)
        {
            Id = id;
            Address = address;
            Capacity = capacity;
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        public List<Car> ListOfCars { get; set; } = new List<Car>();
    }
}
