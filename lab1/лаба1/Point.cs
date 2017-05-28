using System;

namespace PointOnСrossing
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point() { }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return String.Format("x={0}\ny={1}", X, Y);
        }

        public override bool Equals(object obj)
        {
            Point p = obj as Point;

            if (X == p.X && Y == p.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
