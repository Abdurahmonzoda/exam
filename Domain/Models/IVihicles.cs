using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    interface  IVihicles
    {
        public void Drive();
        public bool Refuel(int gaz); 

    }
    public class Car :IVihicles
    {
        public int Gaz { get; set; }
        public Car(int gaz)
        {
            Gaz = gaz;
        }

        public void Drive()
        {
            if (Gaz > 0)
                Console.WriteLine("Driving");
            else
                Console.WriteLine("The End"); 
        }

        public bool Refuel(int gaz)
        {
            Gaz += gaz;
            return true; 
        }
    }
}
