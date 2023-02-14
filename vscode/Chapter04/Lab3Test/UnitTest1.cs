using Xunit;
using Lab3;

namespace Lab3Test;

public class UnitTest1
{
    [Fact]
    public void TestProductOf2Numbers()
    {

            double a = 6;
            double b = 4;
            double expected = 24;

            double actual = Task5.Multiply(a, b);

            Assert.Equal(expected, actual);
    }

      public void TestProductOf3Numbers()
        {
            double a = 6;
            double b = 4;
            double c = 8;
            double expected = 192;

            double actual = Task5.Multiply(a, b, c);

            Assert.Equal(expected, actual);
        }
}