using TaskLibrary.Domain;

namespace TaskLibrary.UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void Create_IsNotValid_ShouldReturnExeption_LessThanZero()
        {
            var sideA = -10;
            var sideB = 1;
            var sideC = 2;

            Assert.Throws<Exception>(() => Triangle.Create(sideA, sideB, sideC));
        }

        [Fact]
        public void Create_IsNotValid_ShouldReturnExeption()
        {
            
            var sideA = 10;
            var sideB = 1;
            var sideC = 2;


            Assert.Throws<Exception>(() => Triangle.Create(sideA, sideB, sideC));
        }

        [Fact]
        public void Create_IsValid_ShouldReturnTriangle()
        {
            var sideA = 4;
            var sideB = 5;
            var sideC = 6;

            var triangle = Triangle.Create(sideA, sideB, sideC);

            Assert.Equal(4, triangle.SideA);
            Assert.Equal(5, triangle.SideB);
            Assert.Equal(6, triangle.SideC);
        }
    }
}
