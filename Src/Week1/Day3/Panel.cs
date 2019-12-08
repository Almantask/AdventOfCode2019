using System.IO;
using System.Linq;
using Week1.Tests.Day3;

namespace Week1.Day3
{
    public class Panel
    {
        public static Point OriginPoint { get; } = new Point(0,0);

        private Wire _wire1;
        private Wire _wire2;

        // Core logic comes from untangles
        private readonly WireUntangler _wireUntangler;

        /// <summary>
        /// Calculates closest distance to origin. Use Manhatan algorithm.
        /// </summary>
        public long CalculateClosestTangleDistance() => _wireUntangler.CalculateShortestDistanceToOrigin(_wire1, _wire2);

        public Panel(string panelMapPath, WireUntangler untangler)
        {
            _wireUntangler = untangler;
            LoadWires(panelMapPath);
        }

        private void LoadWires(string panelMapPath)
        {
            var lines = File.ReadAllLines(panelMapPath);
            var wires = lines.Select(
                    line => line.Split(','))
                .Select(path => new Wire(path)).ToList();

            _wire1 = wires[0];
            _wire2 = wires[1];
        }

        /// <summary>
        /// Calculates and find the sum of intersection of both wires,
        /// which results in the shortest signal path to travel for both.
        /// </summary>
        public int CalculateClosestSignalIntersectionSum()
        {
            var tangles = _wireUntangler.FindTangles(_wire1, _wire2);
            var closestSignalDistance = int.MaxValue;

            foreach (var tangle in tangles)
            {
                var signalStep1 = _wire1.CalculateLengthToPoint(tangle);
                var signalStep2 = _wire2.CalculateLengthToPoint(tangle);

                var totalSignalSteps = signalStep1 + signalStep2;

                if(totalSignalSteps < closestSignalDistance)
                {
                    closestSignalDistance = totalSignalSteps;
                }
            }

            return closestSignalDistance;
        }
    }
}
