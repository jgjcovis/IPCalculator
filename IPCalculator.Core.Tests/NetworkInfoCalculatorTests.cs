using IPCalculatorNS;
using Moq;

namespace IPCalculator.Core.Tests
{
    public class NetworkInfoCalculatorTests
    {
        private static INetworkInfoCalculator CreateCalculator(IIPConverter conv = null)
        {
            var converter = conv ?? new IPConverter();
            var calculator = new NetworkInfoCalculator(converter);

            return calculator;
        }

        [Fact]
        public void Calculate_WithToBinaryReturningNull_DoesNotThrowNullReferenceException()
        {
            // Arrange
            var converter = new Mock<IIPConverter>();
            converter.Setup(x => x.ToBinary(It.IsAny<string>())).Returns<string>((s) => string.Empty);
            var calculator = CreateCalculator(converter.Object);

            // Act
            var _ = calculator.Calculate("0.0.0.0", 21);
        }

        [Fact]
        public void Calculate_WithIpAddressNull_DoesNotThrowNullReferenceException()
        {
            // Arrange
            var calculator = CreateCalculator();

            // Act
            var exception = Assert.Throws<FormatException>(() => calculator.Calculate(null, 0));

            // Assert
            Assert.IsNotType<NullReferenceException>(exception);
        }

        [Fact]
        public void Calculate_WithValidIpAddress_DoesNotThrowException()
        {
            // Arrange
            var calculator = CreateCalculator();

            // Act, Assert
            calculator.Calculate("192.168.0.0", 0);

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
            // Arrange
            var calculator = CreateCalculator();

            // Act, Assert
            Assert.Throws<FormatException>(() => calculator.Calculate(input, 0));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(31)]
        public void Calculate_WithInvalidSuffix_ThrowsArgumentOutOfRangeException(int input)
        {
            // Arrange
            var calculator = CreateCalculator();

            // Act, Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.Calculate("0.0.0.0", input));
        }

        [Fact]
        public void Calculate_WithValidInput_CalculatesNetworkAddress()
        {
            // Arrange
            var calculator = CreateCalculator();
            var expectedNetworkInfo = new NetworkInfo();
            expectedNetworkInfo.NetworkAddress = "192.168.48.0";

            // Act
            var actualNetworkInfo = calculator.Calculate("192.168.53.0", 21);

            // Assert
            Assert.NotNull(actualNetworkInfo);
            Assert.Equal(expectedNetworkInfo.NetworkAddress, actualNetworkInfo.NetworkAddress);
        }

        [Fact]
        public void Calculate_WithValidInput_CalculatesBroadcastAddress()
        {
            // Arrange
            var calculator = CreateCalculator();
            var expectedNetworkInfo = new NetworkInfo();
            expectedNetworkInfo.BroadcastAddress = "192.168.55.255";

            // Act
            var actualNetworkInfo = calculator.Calculate("192.168.53.0", 21);

            // Assert
            Assert.NotNull(actualNetworkInfo);
            Assert.Equal(expectedNetworkInfo.BroadcastAddress, actualNetworkInfo.BroadcastAddress);
        }
    }
}