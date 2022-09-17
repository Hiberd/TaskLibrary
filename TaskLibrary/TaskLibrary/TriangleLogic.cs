using TaskLibrary.Domain;

namespace TaskLibrary
{
    public class TriangleLogic
    {
        public double CalculateTheArea(double a, double b, double c)
        {
            var triangle = Triangle.Create(a, b, c);

            double p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;

            double area = Math.Sqrt(p * (p - triangle.SideA) * (p - triangle.SideB) * (p - triangle.SideC));

            return area;

        }

        public bool IsRightTriangle(double a, double b, double c)
        {
            var triangle = Triangle.Create(a, b, c);

            double SqrSideA = Math.Pow(triangle.SideA, 2);

            double SqrSideB = Math.Pow(triangle.SideB, 2);

            double SqrSideC = Math.Pow(triangle.SideC, 2);

            bool result = (SqrSideA == SqrSideB + SqrSideC
                || SqrSideB == SqrSideA + SqrSideC
                || SqrSideC == SqrSideA + SqrSideB);

            return result;
        }
    }
}
