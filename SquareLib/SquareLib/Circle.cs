using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Circle : Shape
    {
        public readonly double radius; 

        public Circle(double radius) 
        {
            if(CheckCorrectnessParameter(radius, "radius of cirle"))
                this.radius = radius;
        }

        protected override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
