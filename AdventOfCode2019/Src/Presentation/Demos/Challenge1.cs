using Presentation;
using System;
using System.Collections.Generic;
using System.Text;

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
            var rocket = new RocketFuelSystem(@"Input/rocket1Module.txt");
            ConsoleView.Print(rocket.TotalFuel.ToString());
        }

        public static void Demo2()
        {
            ConsoleView.Print("Demo 2:");
            var rocket = new RocketFuelSystemV2(@"Input/rocket1Module.txt");
            ConsoleView.Print(rocket.TotalFuel.ToString());
        }
    }
}
