using System;
using FluentAssertions;
using Week1.Day1;
using Xunit;

namespace Week1.Tests
{
    public class FuelEquationTests
    {
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void Given_Module_Mass_Fuel_Should_Be_As_Expected(uint mass, uint expectedFuel)
        {
            var rocketFuelSystem = new RocketFuelSystem();

            var fuel = rocketFuelSystem.CalculateFuel(mass);

            fuel.Should().Be(expectedFuel);
        }

        [Theory]
        [InlineData(@"Input/rocket1Module.txt", 2)]
        [InlineData(@"Input/rocket2Module.txt", 67166)]
        [InlineData(@"Input/rocket3Module.txt", 67168)]
        [InlineData(@"Input/Empty.txt", 0)]
        public void Given_Input_File_For_Modules_Sum_Should_Be_As_Expected(string rocketFuelSystemConfig, ulong expectedTotalFuelSum)
        {
            var rocketFuelSystem = new RocketFuelSystem();

            rocketFuelSystem.Load(rocketFuelSystemConfig);

            rocketFuelSystem.TotalFuel.Should().Be(expectedTotalFuelSum);
        }

        [Theory]
        [InlineData(@"Input/rocketInvalid.txt")]
        [InlineData(@"Input/rocketInvalidDecimal.txt")]
        public void Given_Invalid_Input_File_For_Modules_Should_Throw_InvalidRocketConfigurationException(string rocketFuelSystemConfig)
        {
            var rocketFuelSystem = new RocketFuelSystem();

            Action loadRocketFuelSystem = () => rocketFuelSystem.Load(rocketFuelSystemConfig);

            loadRocketFuelSystem.Should().Throw<InvalidRocketConfigurationException>();
        }
    }
}
