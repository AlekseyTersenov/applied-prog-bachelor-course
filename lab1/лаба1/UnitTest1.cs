using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOnСrossing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MethodForPointEquals()
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(1, 1);

            Assert.AreEqual(p1.Equals(p2), true);
        }

        [TestMethod]
        public void MethodForLineEquals()
        {
            Line l1 = new Line(new Point(1, 1), new Point(1, 1));
            Line l2 = new Line(new Point(1, 1), new Point(1, 1));
            
            Assert.AreEqual(l1.Equals(l2), true);
        }

        [TestMethod]
        public void MethodForCrossing()
        {
            Line l1 = new Line(new Point(0, 2), new Point(2, 0));
            Line l2 = new Line(new Point(0, 0), new Point(1, 1));

            Assert.AreEqual(Line.getCrossing(l1, l2), new Point(1, 1));
        } 
    }
}
