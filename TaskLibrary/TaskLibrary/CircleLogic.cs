using TaskLibrary.Domain;

namespace TaskLibrary
{
    public class CircleLogic 
    {
        public double CalculateTheArea(double radius)
        {
            var circle = Circle.Create(radius);
              
            return Math.Round(Math.PI * Math.Pow(circle.Radius, 2),1);
        }
    }
}
