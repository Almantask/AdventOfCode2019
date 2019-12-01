using System;
using System.IO;
using System.Linq;

namespace Week1.Day1
{
    public class RocketFuelSystem
    {
        public ulong TotalFuel { get; }

        public RocketFuelSystem(string path)
        {
            TotalFuel = CalculateTotalFuel(path);
        }

        public static uint CalculateFuel(uint mass)
        {
            return (uint)Math.Floor(mass / 3.0f) - 2;
        }

        private ulong CalculateTotalFuel(string path)
        {
            var modules = File.ReadAllLines(path);

            try
            {
                var totalFuel = modules.Select(m => uint.Parse(m))
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