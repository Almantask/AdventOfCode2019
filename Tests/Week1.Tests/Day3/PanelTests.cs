using FluentAssertions;
using Week1.Day3;
using Xunit;

namespace Week1.Tests.Day3
{
    public class PanelTests
    {
        [Theory]
        [InlineData(@"Day3/Input/TangledWiresDist1.txt", 1)]
        [InlineData(@"Day3/Input/TangledWiresDist135.txt", 135)]
        [InlineData(@"Day3/Input/TangledWiresDist159.txt", 159)]
        [InlineData(@"Day3/Input/TangledWiresDist6.txt", 6)]
        public void Panel_Initialized_From_File_With_2_Tangled_Wires_Returns_Shortest_Tangle_Distance(string pathToPanelConfig, int expectedDistance)
        {
            var panel = new Panel(pathToPanelConfig, new WireUntangler());

            var distance = panel.CalculateClosestTangleDistance();

            distance.Should().Be(expectedDistance);
        }

        [Theory]
        [InlineData(@"Day3/Input/TangledWiresDist1.txt", 4)]
        [InlineData(@"Day3/Input/TangledWiresDist6.txt", 30)]
        [InlineData(@"Day3/Input/TangledWiresDist135.txt", 410)]
        [InlineData(@"Day3/Input/TangledWiresDist159.txt", 610)]
        public void Panel_With_Valid_Wires_Calculate_Shortest_Signal_Sum_Returns_Expected_Value(string pathToPanelConfig, int expectedDistance)
        {
            var panel = new Panel(pathToPanelConfig, new WireUntangler());

            var distance = panel.CalculateClosestSignalIntersectionSum();

            distance.Should().Be(expectedDistance);
        }
    }
}
