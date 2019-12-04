using System;

namespace Week1.Day1
{
    public class RocketFuelSystemV2: RocketFuelSystem
    {

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override uint CalculateFuel(uint mass)
        {
            uint sum = 0;
            CalculateFuelStep(mass, ref sum);

            return (uint)sum;
        }

        private static void CalculateFuelStep(uint mass, ref uint sum)
        {
            var fuel = (int)Math.Floor(mass / 3.0f) - 2;
            if (fuel < 0)
            {
                return;
            }
            else
            {
                sum += (uint)fuel;
                CalculateFuelStep((uint)fuel, ref sum);
            }

        }

    }
}