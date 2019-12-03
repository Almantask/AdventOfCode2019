using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Week1.Tests.Day3;

namespace Week1.Day3
{
    public class Panel
    {
        private Wire _wire1;
        private Wire _wire2;

        // Core logic comes from untangles
        private readonly WireUntangler _wireUntangler;

        /// <summary>
        /// Calculates closest distance to origin. Use Manhatan algorithm.
        /// </summary>
        public long CalculateClosestDistance() => _wireUntangler.CalculateShortestDistanceToOrigin(_wire1, _wire2);

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
    }
}
