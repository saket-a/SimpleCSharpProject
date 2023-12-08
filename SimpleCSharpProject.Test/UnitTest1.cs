using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace SimpleCSharpProject.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int result;

            // Act
            result = Program.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }
    }
}