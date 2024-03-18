using ClassLibrary1;

namespace test
{
    public class drobitests
    {
        [Theory]
        [InlineData(2, 5, 3, 5, 1, 1)]
        [InlineData(3, 4, 2, 5, 23, 1)]
        public void plus(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            // Arrange
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            drobi expect = new drobi(r1, r2);

            // Act
            drobi c = a + b;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }
        [Theory]
        [InlineData(2, 5, 3, 5, -1, 1)]
        [InlineData(3, 4, 2, 5, 7, 1)]
        public void minus(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            // Arrange
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            drobi expect = new drobi(r1, r2);

            // Act
            drobi c = a - b;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, 6, 1)]
        [InlineData(3, 4, 2, 5, 3, 1)]
        public void ymnoj(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            // Arrange
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            drobi expect = new drobi(r1, r2);

            // Act
            drobi c = a * b;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, 2, 1)]
        [InlineData(3, 4, 2, 5, 15, 1)]
        public void razdel(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            // Arrange
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            drobi expect = new drobi(r1, r2);

            // Act
            drobi c = a / b;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, -2, 1)]
        [InlineData(3, 4, 2, 5, -3, 1)]
        public void ymarminys(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            // Arrange
            drobi a = new drobi(a1, a2);
            drobi expect = new drobi(r1, r2);

            // Act
            drobi c = -a;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, false)]
        [InlineData(3, 4, 2, 5, false)]
        public void ravnoravno(int a1, int a2, int b1, int b2, bool r)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            bool expect = r;

            // Act
            bool c = a == b;

            // Assert
            Assert.Equal(expect, c);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, true)]
        [InlineData(3, 4, 2, 5, true)]
        public void neravno(int a1, int a2, int b1, int b2, bool r)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            bool expect = r;

            // Act
            bool c = a != b;

            // Assert
            Assert.Equal(expect, c);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, false)]
        [InlineData(3, 4, 2, 5, false)]
        public void menishe(int a1, int a2, int b1, int b2, bool r)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            bool expect = r;

            // Act
            bool c = a < b;

            // Assert
            Assert.Equal(expect, c);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, false)]
        [InlineData(3, 4, 2, 5, false)]
        public void bolishe(int a1, int a2, int b1, int b2, bool r)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            bool expect = r;

            // Act
            bool c = a > b;

            // Assert
            Assert.Equal(expect, c);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, true)]
        [InlineData(3, 4, 2, 5, false)]
        public void menisheorravno(int a1, int a2, int b1, int b2, bool r)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            bool expect = r;

            // Act
            bool c = a <= b;

            // Assert
            Assert.Equal(expect, c);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, true)]
        [InlineData(3, 4, 2, 5, false)]
        public void bolisheorravno(int a1, int a2, int b1, int b2, bool r)
        {
            drobi a = new drobi(a1, a2);
            drobi b = new drobi(b1, b2);
            bool expect = r;

            // Act
            bool c = a <= b;

            // Assert
            Assert.Equal(expect, c);
        }

    }
}