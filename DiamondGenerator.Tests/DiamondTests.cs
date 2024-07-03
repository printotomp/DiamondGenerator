using System;
using Xunit;
using Moq;
using Assert = Xunit.Assert;

namespace DiamondGenerator.Tests
{
    public class DiamondTests
    {
        [Fact]
        public void Create_ValidInput_A_ReturnsExpectedDiamond()
        {
            // Arrange
            var diamond = new Diamond();
            char target = 'A'; // Example input

            // Act
            string result = diamond.Create(target);

            // Assert
            Assert.Equal("A\n", result);
        }

        [Fact]
        public void Create_ValidInput_B_ReturnsExpectedDiamond()
        {
            // Arrange
            var diamond = new Diamond();
            char target = 'B'; // Example input

            // Act
            string result = diamond.Create(target);

            // Assert
            Assert.Equal(" A \nB B\n A \n", result);
        }

        [Fact]
        public void Create_ValidInput_ReturnsExpectedDiamond()
        {
            // Arrange
            var diamond = new Diamond();
            char target = 'C'; // Example input

            // Act
            string result = diamond.Create(target);

            // Assert
            Assert.Equal("  A  \n B B \nC   C\n B B \n  A  \n", result);
        }

        [Fact]
        public void Create_InvalidInput_ThrowsArgumentException()
        {
            // Arrange
            var diamond = new Diamond();
            char invalidTarget = '1'; // Invalid input

            // Act & Assert
            Assert.Throws<ArgumentException>(() => diamond.Create(invalidTarget));
        }
    }
}