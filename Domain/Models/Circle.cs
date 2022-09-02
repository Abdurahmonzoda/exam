using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius , string name):base(name)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Circle has been Drawed");
        }
    }
}
