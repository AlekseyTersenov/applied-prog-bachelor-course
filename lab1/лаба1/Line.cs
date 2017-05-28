using System;

namespace PointOnСrossing
{
    public class Line
    {
        public Point one, two;

        public Line()
        {
            one = new Point();
            two = new Point();
        }

        public Line(Point one, Point two)
        {
            this.one = one;
            this.two = two;
        }

        public void init()
        {
            Console.WriteLine("Координаты первой точки: ");

            Console.Write("x=");
            one.X = Convert.ToDouble(Console.ReadLine());

            Console.Write("y=");
            one.Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Координаты второй точки:");

            Console.Write("x=");
            two.X = Convert.ToDouble(Console.ReadLine());

            Console.Write("y=");
            two.Y = Convert.ToDouble(Console.ReadLine());
        }

        public override bool Equals(object obj)
        {
            Line l = obj as Line;

            if (one.Equals(l.one) && two.Equals(l.two) || one.Equals(l.two) && two.Equals(l.one))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Point getCrossing(Line l1, Line l2)
        {
            if (!l1.Equals(l2))
            {
                if(l1.one.Equals(l2.two))
                {
                    return l1.one;
                } else if(l1.two.Equals(l2.one))
                {
                    return l1.two;
                }

                double x, y;
                double a1, b1, c1;
                double a2, b2, c2;

                a1 = l1.one.Y - l1.two.Y;
                b1 = l1.two.X - l1.one.X;
                c1 = l1.one.X * l1.two.Y - l1.two.X * l1.one.Y;

                a2 = l2.one.Y - l2.two.Y;
                b2 = l2.two.X - l2.one.X;
                c2 = l2.one.X * l2.two.Y - l2.two.X * l2.one.Y;
                
                if (a1 * b2 - a2 * b1 == 0)
                {
                    Console.WriteLine("Прямые параллельны");
                    return null;
                }
                else
                {
                    y = (a2 * c1 - c2 * a1) / (b2 * a1 - a2 * b1);
                    x = (-b1 * y - c1) / a1;

                    return new Point(x, y);
                }
            }
            else
            {
                Console.WriteLine("Бесконечное количество точек пересечения");
                return null;
            }
        }
    }
}
