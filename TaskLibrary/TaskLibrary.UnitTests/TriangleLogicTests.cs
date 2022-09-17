
namespace TaskLibrary.UnitTests
{
    public class TriangleLogicTests
    {
        [Fact]
        public void CalculateTheArea_IsValid_ShouldReturnResult()
        {
            TriangleLogic triangle = new TriangleLogic();

            var result = triangle.CalculateTheArea(8, 5, 5);

            Assert.Equal(12, result);
        }

        [Fact]
        public void IsRightTriangle_IsValid_ShouldReturnTrue()
        {
            TriangleLogic triangle = new TriangleLogic();

            var result = triangle.IsRightTriangle(10, 6, 8);

            Assert.True(result);
        }

        [Fact]
        public void IsRightTriangle_IsValid_ShouldReturnFalse()
        {
            TriangleLogic triangle = new TriangleLogic();

            var result = triangle.IsRightTriangle(10, 6, 9);

            Assert.False(result);
        }
    }
}
