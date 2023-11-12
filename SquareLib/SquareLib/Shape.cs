using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public abstract class Shape
    {
        protected abstract double CalculateArea();

        public double GetArea() 
        {
            double area = CalculateArea();
            CheckCorrectnessArea(area);
            return area;
        }

        protected bool CheckCorrectnessArea(double area)
        {
            bool isCorrect = (area < double.PositiveInfinity);
            if (!isCorrect)
                throw new ArgumentOutOfRangeException("The area value is too large for the double type");
            return isCorrect;
        }

        protected bool CheckCorrectnessParameter(double parameter, string nameTypeParameter)
        {
            bool isCorrect = (parameter > 0);
            if (!isCorrect)
                throw new ArgumentException($"Incorrect value of the {nameTypeParameter}: {parameter}");
            return isCorrect; 
        }

    }
}
