using System.Reflection.Metadata;

namespace ShapeLib
{
    public class Triangle : Shape
    {
        public readonly double sideA;
        public readonly double sideB;
        public readonly double sideC;
        
        public Triangle(double sideA, double sideB, double sideC) 
        {
            if (CheckExistSides(sideA, sideB, sideC))
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
        }

        protected override double CalculateArea()
        {
            double halfSum = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(halfSum * (halfSum - sideA) * (halfSum - sideB) * (halfSum - sideC));
        }

        public bool IsRectangular() 
        {
            double squareA = sideA * sideA;
            double squareB = sideB * sideB;
            double squareC = sideC * sideC;
            double halfSumSquaresSides = (squareA + squareB + squareC) / 2;
            return ((halfSumSquaresSides == squareA) || (halfSumSquaresSides == squareB) || (halfSumSquaresSides == squareC));
        }

        private bool CheckExistSides(double sideA, double sideB, double sideC) 
        {
            string nameTypeParameter = "triangle side";
            bool result = CheckCorrectnessParameter(sideA, nameTypeParameter) && CheckCorrectnessParameter(sideB, nameTypeParameter) && CheckCorrectnessParameter(sideC, nameTypeParameter);
            if (result)
            {
                result &= (sideA < (sideB + sideC)) && (sideB < (sideA + sideC)) && (sideC < (sideB + sideA));
                if (!result)
                    throw new ArgumentOutOfRangeException("There is no triangle with such values of sides, where one side is greater than or equal to the sum of the other sides");
            }
            return result;
        }
    }
}