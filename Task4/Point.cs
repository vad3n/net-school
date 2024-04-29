using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Point
    {
        private int[] coordinates = new int[3];
        private double _mass;

        public int X
        {
            get
            {
                return coordinates[0];
            }

            set
            {
                coordinates[0] = value;
            }
        }

        public int Y
        {
            get
            {
                return coordinates[1];
            }

            set
            {
                coordinates[1] = value;
            }
        }

        public int Z
        {
            get
            {
                return coordinates[2];
            }

            set
            {
                coordinates[2] = value;
            }
        }

        public double Mass
        {
            get
            {
                return _mass;
            }

            set
            {
                _mass = value > 0 ? value : 0;
            }
        }

        public Point()
        {

        }

        public Point(int x, int y, int z, int mass)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Mass = mass;
        }

        public bool IsZero()
        {
            return X == 0 && Y == 0 && Z == 0;
        }

        public double CalculateDistance(Point other)
        {
            return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2) + Math.Pow(Z - other.Z, 2));
        }
    }
}
