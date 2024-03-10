using ClassLibrary1;
using Xunit;

namespace test
{
    public class drobitests
    {
        [Fact]
        public void plus()
        {
            // Arrange
            drobi a = new drobi(2, 5);
            drobi b = new drobi(3, 5);
            drobi expect = new drobi(1, 1);

            // Act
            drobi c = a + b;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }
        [Fact]
        public void minus()
        {
            // Arrange
            drobi a = new drobi(2, 5);
            drobi b = new drobi(3, 5);
            drobi expect = new drobi(1, 5);

            // Act
            drobi c = b - a;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }

        [Fact]
        public void ymnoj()
        {
            // Arrange
            drobi a = new drobi(2, 5);
            drobi b = new drobi(3, 5);
            drobi expect = new drobi(6, 25);

            // Act
            drobi c = b * a;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }

        [Fact]
        public void razdel()
        {
            // Arrange
            drobi a = new drobi(2, 5);
            drobi b = new drobi(3, 5);
            drobi expect = new drobi(2, 3);

            // Act
            drobi c = a / b;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }

        [Fact]
        public void ynarminus()
        {
            // Arrange
            drobi a = new drobi(2, 5);
            drobi expect = new drobi(-2, 5);

            // Act
            drobi c = -a;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }

        [Fact]
        public void ravno_ravno()
        {
            // Arrange
            drobi a = new drobi(2, 5);
            drobi b = new drobi(3, 5);
            bool expect = false;

            // Act
            bool c = a == b;

            // Assert
            Assert.Equal(expect, c);
        }

        [Fact]
        public void ne_ravno()
        {
            // Arrange
            drobi a = new drobi(2, 5);
            drobi b = new drobi(3, 5);
            bool expect = true;

            // Act
            bool c = a != b;

            // Assert
            Assert.Equal(expect, c);
        }
        
        [Fact]
        public void menishe()
        {
            // Arrange
            drobi a = new drobi(2, 5);
            drobi b = new drobi(3, 5);
            bool expect = false;

            // Act
            bool c = a < b;

            // Assert
            Assert.Equal(expect, c);
        }

        [Fact]
        public void bolishe()
        {
            // Arrange
            var a = new drobi(2, 5);
            drobi b = new drobi(3, 5);
            bool expect = false;

            // Act
            bool c = a > b;

            // Assert
            Assert.Equal(expect, c);
        }

        [Fact]
        public void menishe_or_ravno()
        {
            // Arrange
            drobi a = new drobi(2, 5);
            drobi b = new drobi(3, 5);
            bool expect = true;

            // Act
            bool c = a <= b;

            // Assert
            Assert.Equal(expect, c);
        }

        [Fact]
        public void bolishe_or_ravno()
        {
            // Arrange
            drobi a = new drobi(2, 5);
            drobi b = new drobi(3, 5);
            bool expect = false;

            // Act
            bool c = a >= b;

            // Assert
            Assert.Equal(expect, c);
        }

    }
}