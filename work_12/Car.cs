using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_12
{
    internal class Car:Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        private int _maxspeed;
        public int MaxSpeed
        {
            get { return _maxspeed; }
            set
            {
                if (value > 0)
                {
                    _maxspeed = value;
                }
                else
                {
                    Console.WriteLine("Duzgun daxil edin");
                }
            }
        }

        public Car(string color,int year,string brand,string model,int _maxSpeed) : base(color,year)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = _maxSpeed;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Reng: {Color}, Il: {Year},Brand: {Brand},Model: {Model},MaxSuret: {MaxSpeed} ");
        }
    }
}
