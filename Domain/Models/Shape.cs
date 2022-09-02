using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class Shape
    {
        string name;
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract void Draw(); 

    }
}
