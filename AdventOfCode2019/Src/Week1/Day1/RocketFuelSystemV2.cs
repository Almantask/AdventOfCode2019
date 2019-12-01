using System;
using System.IO;
using System.Linq;

namespace Week1.Day1
{
    public class RocketFuelSystemV2
    {
        public ulong TotalFuel { get; }

        public RocketFuelSystemV2(string path)
        {
            TotalFuel = CalculateTotalFuel(path);
        }

        public static uint CalculateFuel(int mass)
        {
            int sum = 0;
            CalculateFuelStep(mass, ref sum);

            return (uint)sum;
        }

        private static void CalculateFuelStep(int mass, ref int sum)
        {
            var fuel = (int)Math.Floor(mass / 3.0f) - 2;
            if (fuel < 0)
            {
                return;
            }
            else
            {
                sum += fuel;
                CalculateFuelStep(fuel, ref sum);
            }

        }

        private ulong CalculateTotalFuel(string path)
        {
            var modules = File.ReadAllLines(path);

            try
            {
                var totalFuel = modules.Select(m => int.Parse(m))
                    .Sum(m => CalculateFuel(m));
                
                return (ulong)totalFuel;
            }
            catch(Exception ex)
            {
                throw new InvalidRocketConfigurationException($"{path} is not a valid rocket fuel module configuration.{Environment.NewLine}.Reason: {ex.Message}", ex);
            }
        }
    }
}