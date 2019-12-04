using Presentation;

namespace Week1.Day1
{
    public static class Challenge1
    {
        static Challenge1()
        {
            ConsoleView.Print("Challenge 1...");
        }

        public static void FullDemo()
        {
            Demo1();
            Demo2();
        }

        public static void Demo1()
        {
            ConsoleView.Print("Demo 1:");
            var rocket = new RocketFuelSystem();
            rocket.Load(@"Input/C1.rocket1Module.txt");

            ConsoleView.Print(rocket.TotalFuel.ToString());
        }

        public static void Demo2()
        {
            ConsoleView.Print("Demo 2:");
            var rocket = new RocketFuelSystemV2();
            rocket.Load(@"Input/C1.rocket1Module.txt");

            ConsoleView.Print(rocket.TotalFuel.ToString());
        }
    }
}
