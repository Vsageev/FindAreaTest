using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLib;
using System;

namespace FindAreaUnitTests
{
    [TestClass]
    public class FiguresTest
    {
        [TestMethod]
        public void findAreaCircle()
        {
            double actual = Figures.findArea(2);
            double expected = 12.566371;
            double tolerance = .001;
            Assert.AreEqual(expected, actual, tolerance);
        }

        [TestMethod]
        public void findAreaTriangle()
        {
            double actual = Figures.findArea(3, 4, 5);
            double expected = 6;
            double tolerance = .001;
            Assert.AreEqual(expected, actual, tolerance);
        }
    }

    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void findArea1()
        {
            double actual = Circle.findArea(2);
            double expected = 12.566371;
            double tolerance = .001;
            Assert.AreEqual(expected, actual, tolerance);
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void findArea1()
        {
            double actual = Triangle.findArea(3, 4, 5);
            double expected = 6;
            double tolerance = .001;
            Assert.AreEqual(expected, actual, tolerance);
        }

        [TestMethod]
        public void findArea2()
        {
            double actual = Triangle.findArea(5, 7, 4);
            double expected = 9.797959;
            double tolerance = .001;
            Assert.AreEqual(expected, actual, tolerance);
        }

        [TestMethod]
        public void isRight1()
        {
            bool actual = Triangle.isRight(3, 4, 5);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isRight2()
        {
            bool actual = Triangle.isRight(3, 6, 5);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}
