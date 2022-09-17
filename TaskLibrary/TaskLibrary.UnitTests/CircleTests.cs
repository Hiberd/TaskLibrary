using TaskLibrary.Domain;

namespace TaskLibrary.UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void Create_IsValid_ShouldReturnTriangle()
        {
            var radius = 10;

            var circle = Circle.Create(radius);

            Assert.Equal(10, circle.Radius);
        }

        [Fact]
        public void Create_IsNotValid_ShouldReturnExeption()
        {
            var radius = -10;

            Assert.Throws<Exception>(() => Circle.Create(radius));
        }
    }
}
