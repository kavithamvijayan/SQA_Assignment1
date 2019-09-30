using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQA_Assignment1_NUnit;

namespace UnitTestProject_NUnit
{
    [TestClass]
    public class UnitTest1
    {
        // Unit test for checking whether the sides mentioned 
        [TestMethod]
        public void TriangleOrNotTest()
        {
            int side1 = 14, side2 = 51, side3 = 10;
            TriangleSolver.Analyze(side1, side2, side3);
        }
        [TestMethod]
        public void ScaleneTest()
        {
            int side1 = 12, side2 = 15, side3 = 10;
            TriangleSolver.Analyze(side1,side2,side3);
        }
        [TestMethod]
        public void EquilateralTest()
        {
            int side1 = 12, side2 = 12, side3 = 12;
            TriangleSolver.Analyze(side1, side2, side3);
        }

        [TestMethod]
        public void IsocelesTest()
        {
            int side1 = 12, side2 = 12, side3 = 10;
            TriangleSolver.Analyze(side1, side2, side3);
        }
        [TestMethod]
        public void NotaTriangleTest()
        {
            int side1 = 0, side2 = 0, side3 = 0;
            TriangleSolver.Analyze(side1, side2, side3);
        }

        [TestMethod]
        public void ErrorScalaneTest()
        {
            int side1 = -1, side2 = 2, side3 = 3;
            TriangleSolver.Analyze(side1, side2, side3);
        }
        [TestMethod]
        public void ErrorEquilateralTest()
        {
            int side1 = -2, side2 = -2, side3 = -2;
            TriangleSolver.Analyze(side1, side2, side3);
        }
        [TestMethod]
        public void ErrorIsocelesTest()
        {
            int side1 = -2, side2 = 5, side3 = -2;
            TriangleSolver.Analyze(side1, side2, side3);
        }
    }
}
