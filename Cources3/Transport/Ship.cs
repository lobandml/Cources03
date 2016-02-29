using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources3.Transport
{
    class Ship:Vehicle
    {
        public string Port { get; private set; }
        public int Passengers { get; private set; }

        public Ship(double x, double y, int cost, int speed, int year, string port, int passengers): base(x, y, cost, speed, year)
        {
            this.Port = port;
            this.Passengers = passengers;
        }

    }


}
