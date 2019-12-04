using System;

namespace Presentation
{
    internal static class ConsoleView
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void PromptToExit()
        {
            Console.WriteLine("Demo done. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
