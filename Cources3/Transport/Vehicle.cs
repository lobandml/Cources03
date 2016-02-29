using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Cources3.Transport
{
    class Vehicle
    {
        public double X { get; private set;}

        public double Y { get; private set; }

        public int Cost { get; private set; }

        public int Speed { get; private set; }

        public int Year { get; private set; }

        public Vehicle(double x, double y, int cost, int speed, int year)
        {
            this.X = x;
            this.Y = y;
            this.Cost = cost;
            this.Speed = speed;
            this.Year = year;
        }

        public override string ToString()
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(this);
            StringBuilder builder = new StringBuilder(this.GetType().Name,255);
            builder.Append(" (");

            foreach (PropertyDescriptor property in properties)
            {
                builder.Append(property.Name);
                builder.Append(" = ");
                builder.Append( property.GetValue(this).ToString());
                builder.Append("; ");
            }
            builder.Remove(builder.Length - 2, 2);
            builder.Append(")");
            
            return builder.ToString();
        }
    }
}
