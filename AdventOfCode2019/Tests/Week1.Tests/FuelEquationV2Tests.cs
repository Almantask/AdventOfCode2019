using FluentAssertions;
using System;
using Week1.Day1;
using Xunit;

namespace Week1.Tests
{
    public class FuelEquationV2Tests
    {
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 966)]
        [InlineData(100756, 50346)]
        public void Given_Module_Mass_Fuel_Should_Be_As_Expected(uint mass, uint expectedFuel)
        {
            var rocketFuelSystem = new RocketFuelSystemV2();

            var fuel = rocketFuelSystem.CalculateFuel(mass);

            fuel.Should().Be(expectedFuel);
        }

        [Theory]
        [InlineData(@"Input/rocket1Module.txt", 2)]
        [InlineData(@"Input/rocket2Module.txt", 100692)]
        [InlineData(@"Input/rocket3Module.txt", 100694)]
        [InlineData(@"Input/Empty.txt", 0)]
        public void Given_Input_File_For_Modules_Sum_Should_Be_As_Expected(string rocketFuelSystemConfig, ulong expectedTotalFuelSum)
        {
            var rocketFuelSystem = new RocketFuelSystemV2();

            rocketFuelSystem.Load(rocketFuelSystemConfig);

            rocketFuelSystem.TotalFuel.Should().Be(expectedTotalFuelSum);
        }

        [Theory]
        [InlineData(@"Input/rocketInvalid.txt")]
        [InlineData(@"Input/rocketInvalidDecimal.txt")]
        public void Given_Invalid_Input_File_For_Modules_Should_Throw_InvalidRocketConfigurationException(string rocketFuelSystemConfig)
        {
            var rocketFuelSystem = new RocketFuelSystemV2();

            Action loadRocketFuelSystem = () => rocketFuelSystem.Load(rocketFuelSystemConfig);

            loadRocketFuelSystem.Should().Throw<InvalidRocketConfigurationException>();
        }
    }
}
