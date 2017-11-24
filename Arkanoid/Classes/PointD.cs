using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Classes
{
    class PointD
    {
        public double X { get; set; }
        public double Y { get; set; }

        public PointD (double ax, double ay)
        {
            X = ax; Y = ay;
        }
    }
}
