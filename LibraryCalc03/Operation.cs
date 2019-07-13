using LibraryCalc03.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc03
{
    public class Operation : IOperation
    {
        public double division(PointTest point)
        {
            double x = Double.Parse(point.x.ToString());
            double y = Double.Parse(point.y.ToString());
            return x / y ;
        }

        public int multiplication(PointTest point)
        {
            return point.x * point.y;
        }

        public int multiplication(int x, int y, int z)
        {
            return x * y * z;
        }

        public int subtraction(PointTest point)
        {
            return point.x - point.y;
        }

        public int subtraction(int x, int y, int z)
        {
            return (x - y) - z;
        }

        public int sum(PointTest point)
        {
            return point.x + point.y;
        }

        public int sum(int x, int y, int z)
        {
            return x + y +z;
        }
    }
}
