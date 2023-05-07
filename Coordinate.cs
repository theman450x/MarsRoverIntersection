using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public sealed class Coordinate
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Coordinate()
        {
            
        }

        public Coordinate(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }
    }
}
