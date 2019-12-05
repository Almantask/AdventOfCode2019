using Week1.Day2;
using Week1.Day3;
using Week1.Tests.Day3;

namespace Presentation.Demos
{
    public static class Challenge3
    {
        static Challenge3()
        {
            ConsoleView.Print("Challenge 2...");
        }

        public static void FullDemo()
        {
            Demo1();
            Demo2();
        }

        public static void Demo1()
        {
            ConsoleView.Print("Demo 1:");
            var panel = new Panel("Input/C3.TangledWires.txt", new WireUntangler());

            var closestTangleDistance = panel.CalculateClosestTangleDistance();

            ConsoleView.Print($"Closest tangle wire distance is: {closestTangleDistance}");
        }

        public static void Demo2()
        {

        }
    }
}
