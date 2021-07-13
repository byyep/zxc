using System;
using System.Linq; 

namespace index
{
    class Program
    {
        static void Main(string[] args)
        {
            vehicle your_car = new vehicle(10, 15, 20);
            your_car.characteristic();
        }
    }
    public class vehicle
    {
        protected uint gas_volume { get; set; }
        protected uint number_of_wheels { get; set; }
        protected uint size { get; set; }
        public vehicle(uint gas_volume, uint number_of_wheels, uint size)
        {
            this.gas_volume = gas_volume;
            this.number_of_wheels = number_of_wheels;
            this.size = size; 
        } 
        public void characteristic()
        {
            Console.WriteLine("Объем бака: " + gas_volume 
                + "\nКоличество колес: " + number_of_wheels + "\nГабариты: " + size);
        }

    }
    public class car : vehicle
    {
        public car(uint gas_volume, uint number_of_wheels, uint size) 
            : base(gas_volume, number_of_wheels, size)
        {
            this.gas_volume = gas_volume;
            this.number_of_wheels = number_of_wheels;
            this.size = size;
        }
    }
}
