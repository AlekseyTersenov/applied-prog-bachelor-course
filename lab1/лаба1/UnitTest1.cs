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
		[TestMethod] 
        public void MethodForLineEquals() 
        { 
            Line l1 = new Line(new Point(1, 1), new Point(2, 2)); 
            Line l2 = new Line(new Point(1, 2), new Point(2, 3)); 

            if ((Math.Abs(l1.one.x - l2.one.x) == (Math.Abs(l1.two.x - lw.two.x))) && (Math.Abs(l1.one.y - l2.one.y) == (Math.Abs(l1.two.y - lw.two.y)))) 
            { 
                bool t = true; 
            } 
            else 
            { 
                bool t = false; 
            } 
            Assert.AreEqual(t, true); 
        }
    }
}
