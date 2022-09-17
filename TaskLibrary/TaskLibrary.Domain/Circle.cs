namespace TaskLibrary.Domain
{
    public record Circle
    {
        public double Radius { get; init; }

        private Circle(double radius)
        {
            Radius = radius;
        }

        public static Circle Create(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Радиус не может быть меньше либо равен 0");
            }

            return new Circle(radius);
        }
    }
}
