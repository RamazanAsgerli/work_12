using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_12
{
    internal class Bus:Vehicle
    {
        private int _passengercount;
        public int PassengerCount
        {
            get { return _passengercount; } 
            set
            {
                if(value > 0)
                {
                    _passengercount = value;
                }
                else
                {
                    Console.WriteLine(" Say Duzgun daxil edilmiyib");
                }
            }
        }
        public Bus(string color, int year,int _passengercount) : base(color,year)
        {
            PassengerCount = _passengercount;        
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Reng: {Color}, Il: {Year},Say: {PassengerCount}");
        }
    }
}
