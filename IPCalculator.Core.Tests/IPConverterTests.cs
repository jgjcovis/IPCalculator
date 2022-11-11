using IPCalculatorNS;

namespace IPCalculator.Core.Tests
{
    public class IPConverterTests
    {
        private static IIPConverter CreateConverter()
        {
            return new IPConverter();
        }

        [Fact]
        public void ToBinary_WithIpAddressNull_DoesNotThrowNullReferenceException()
        {
            // Arrange, Act
            var converter = CreateConverter();
            var exception = Assert.Throws<FormatException>(() => converter.ToBinary(null));

            // Assert
            Assert.IsNotType<NullReferenceException>(exception);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("abc")]
        [InlineData("192:168:0:1")]
        [InlineData("0.0.0.256")]
        [InlineData("192.168.0.0.1")]
        [InlineData("0.0.0.")]
        [InlineData("192.168.0./")]
        public void ToBinary_WithInvalidIpAddress_ThrowsFormatException(string input)
        {
            // Arrange
            var converter = CreateConverter();

            // Act, Assert
            Assert.Throws<FormatException>(() => converter.ToBinary(input));
        }

        [Fact]
        public void ToBinary_WithValidInput_DoesNotThrowException()
        {
            // Arrange
            var converter = CreateConverter();
            string expected = "00000000.11111111.01010101.11110000";

            // Act
            string actual = converter.ToBinary("0.255.85.240");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToIp_WithBinaryAddressNull_ThrowsArgumentNullException()
        {
            // Arrange
            var converter = CreateConverter();

            // Act, Assert
            Assert.Throws<ArgumentNullException>(() => converter.ToIP(null));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("abc")]
        [InlineData("00000000.00000000.00000000")]
        [InlineData("00000000.00000000.00000000.0000000")]
        [InlineData("00000000.00000000.00000000.0000000b")]
        [InlineData("00000000000000000000000000000000")]
        [InlineData("00000000.00000000.0000000.00000000")]
        public void ToBinary_WithInvalidBinaryAddress_ThrowsFormatException(string input)
        {
            // Arrange
            var converter = CreateConverter();

            // Act, Assert
            Assert.Throws<FormatException>(() => converter.ToIP(input));
        }

        [Fact]
        public void ToIP_WithValidInput_DoesNotThrowException()
        {
            // Arrange
            var converter = CreateConverter();
            string expected = "0.255.85.240";

            // Act
            string actual = converter.ToIP("00000000.11111111.01010101.11110000");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}