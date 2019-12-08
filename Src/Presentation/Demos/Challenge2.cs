using Week1.Day2;

namespace Presentation.Demos
{
    public static class Challenge2
    {
        static Challenge2()
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
            var program = new IntCodeProgram("Input/C3.GravitonIntCodeProgram.txt");
            program.ResetTo1202Alaram(2, 12);
            
            var intCodeCompiler = new IntCodeCompiler();
            intCodeCompiler.Compile(program);
            
            ConsoleView.Print($"1202 program alarm state is:{program.AlarmState}");
        }

        public static void Demo2()
        {
            ConsoleView.Print("Demo 2:");
            var program = new IntCodeProgram("Input/C2.GravitonIntCodeProgram.txt");

            var intCodeCompiler = new VerbAndNounIntCodeCompiler(19690720, 0, 99);
            var result = intCodeCompiler.CompileSolution(program);

            ConsoleView.Print($"{result}");
        }
    }
}
