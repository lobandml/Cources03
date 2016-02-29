using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources3.Transport
{
    class Plane:Vehicle
    {
        public int Z { get; private set; }

        public int Passengers { get; private set; }

        public Plane(double x, double y,  int z, int cost, int speed, int year, int passengers): base(x, y, cost, speed, year)
        {
            this.Z = z;
            this.Passengers = passengers;
        }
    }
}
