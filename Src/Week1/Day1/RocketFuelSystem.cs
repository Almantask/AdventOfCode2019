using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Week1.Day1
{
    public class RocketFuelSystem
    {
        public ulong TotalFuel { get; private set; }

        /// <summary>
        /// Loads rocket with fuel based on configuration.
        /// </summary>
        /// <param name="path">Rocket fuel configuration file path.</param>
        public void Load(string path)
        {
            var modules = ParseModules(path);
            TotalFuel = (ulong)modules.Sum(m => CalculateFuel(m));
        }

        /// <summary>
        /// Calculate amount of fuel needed to lift the specified rocket mass.
        /// </summary>
        public virtual uint CalculateFuel(uint mass)
        {
            return (uint)Math.Floor(mass / 3.0f) - 2;
        }

        private IEnumerable<uint> ParseModules(string path)
        {
            try
            {
                // Has to be a list because it needs to be evaluated here, so we can catch the exception of invalid input.
                var modules = File.ReadAllLines(path)
                    .Select(m => uint.Parse(m)).ToList();

                return modules;
            }
            catch(Exception ex)
            {
                throw new InvalidRocketConfigurationException($"{path} is not a valid rocket fuel module configuration.{Environment.NewLine}.Reason: {ex.Message}", ex);
            }
        }
    }
}