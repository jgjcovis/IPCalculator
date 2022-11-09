using IPCalculatorNS;

namespace IPCalculator.Core.Tests
{
    public class IPCalculatorTests
    {
        [Fact]
        public void Calculate_WithIpAddressNull_DoesNotThrowNullReferenceException()
        {
            // Arrange, Act
            var exception = Assert.Throws<FormatException>(() => IPCalculatorCore.Calculate(null, 0));

            // Assert
            Assert.IsNotType<NullReferenceException>(exception);
        }

        [Fact]
        public void Calculate_WithValidIpAddress_DoesNotThrowException()
        {
            // Arrange, Act, Assert
            IPCalculatorCore.Calculate("192.168.0.0", 0);

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("abc")]
        [InlineData("192:168:0:1")]
        [InlineData("0.0.0.256")]
        [InlineData("192.168.0.0.1")]
        [InlineData("0.0.0.")]
        [InlineData("192.168.0./")]
        public void Calculate_WithInvalidIpAddress_ThrowsFormatException(string input)
        {
            // Arrange, Act, Assert
            Assert.Throws<FormatException>(() => IPCalculatorCore.Calculate(input, 0));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(31)]
        public void Calculate_WithInvalidSuffix_ThrowsArgumentOutOfRangeException(int input)
        {
            // Arrange, Act, Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => IPCalculatorCore.Calculate("0.0.0.0", input));
        }

        [Fact]
        public void Calculate_WithValidInput_CalculatesNetworkAddress()
        {
            // Arrange
            var expectedNetworkInfo = new NetworkInfo();
            expectedNetworkInfo.NetworkAddress = "192.168.48.0";

            // Act
            var actualNetworkInfo = IPCalculatorCore.Calculate("192.168.53.0", 21);

            // Assert
            Assert.NotNull(actualNetworkInfo);
            Assert.Equal(expectedNetworkInfo.NetworkAddress, actualNetworkInfo.NetworkAddress);
        }

        [Fact]
        public void Calculate_WithValidInput_CalculatesBroadcastAddress()
        {
            // Arrange
            var expectedNetworkInfo = new NetworkInfo();
            expectedNetworkInfo.BroadcastAddress = "192.168.55.255";

            // Act
            var actualNetworkInfo = IPCalculatorCore.Calculate("192.168.53.0", 21);

            // Assert
            Assert.NotNull(actualNetworkInfo);
            Assert.Equal(expectedNetworkInfo.BroadcastAddress, actualNetworkInfo.BroadcastAddress);
        }

        [Fact]
        public void ConvertToBinary_WithIpAddressNull_DoesNotThrowNullReferenceException()
        {
            // Arrange, Act
            var exception = Assert.Throws<FormatException>(() => IPCalculatorCore.ConvertToBinary(null));

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
        public void ConvertToBinary_WithInvalidIpAddress_ThrowsFormatException(string input)
        {
            // Arrange, Act, Assert
            Assert.Throws<FormatException>(() => IPCalculatorCore.ConvertToBinary(input));
        }

        [Fact]
        public void ConvertToBinary_WithValidInput_DoesNotThrowException()
        {
            // Arrange
            string expected = "00000000.11111111.01010101.11110000";

            // Act
            string actual = IPCalculatorCore.ConvertToBinary("0.255.85.240");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToIp_WithBinaryAddressNull_ThrowsArgumentNullException()
        {
            // Arrange, Act, Assert
            Assert.Throws<ArgumentNullException>(() => IPCalculatorCore.ConvertBinaryToIP(null));
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
        public void ConvertToBinary_WithInvalidBinaryAddress_ThrowsFormatException(string input)
        {
            // Arrange, Act, Assert
            Assert.Throws<FormatException>(() => IPCalculatorCore.ConvertBinaryToIP(input));
        }

        [Fact]
        public void ConvertToIP_WithValidInput_DoesNotThrowException()
        {
            // Arrange
            string expected = "0.255.85.240";

            // Act
            string actual = IPCalculatorCore.ConvertBinaryToIP("00000000.11111111.01010101.11110000");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}