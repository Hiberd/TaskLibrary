
namespace TaskLibrary.UnitTests
{
    public class CircleLogicTests
    {
        [Fact]
        public void CalculateTheArea_IsValid_ShouldReturnResult()
        {
            CircleLogic circle = new CircleLogic();

            var result = circle.CalculateTheArea(10);

            Assert.Equal(314.2, result);
        }
    }
}
