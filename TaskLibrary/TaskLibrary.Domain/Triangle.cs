namespace TaskLibrary.Domain
{
    public record Triangle
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }

        private Triangle(double a, double b, double c)
        {
                SideA = a;
                SideB = b;
                SideC = c;
        }

        public static Triangle Create(double a, double b, double c)
        {
            if (a > (b + c) || b > (c + a) || c > (b + a))
            {
                throw new Exception("Такой треугольник не может существовать " +
                    "(одна сторона треугольника больше суммы двух других сторон)");
            }

            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Такой треугольник не может существовать, т.к. одна из сторон не больше 0");
            }

            return new Triangle(a, b, c);
        }
    }
}
