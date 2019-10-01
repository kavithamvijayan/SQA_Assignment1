using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQA_Assignment1_NUnit;

namespace UnitTestProject_NUnit
{
    [TestClass]
    public class UnitTest1
    {
        // Unit test for checking whether the sides mentioned are satisfied for triangle or not
        [TestMethod]
        public void TriangleOrNotTest()
        {
            int side1 = 14, side2 = 51, side3 = 10;
            //Arrange
            string expectedResult = "Scalene triangle";
            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        // Unit test for checking whether the sides given return a scalene triangle or not
        [TestMethod]
        public void ScaleneTest()
        {
            int side1 = 12, side2 = 15, side3 = 10;
            //Arrange
            string expectedResult = "Scalene triangle";
            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        // Unit test for checking whether the sides given return a equilateral triangle or not
        [TestMethod]
        public void EquilateralTest()
        {
            int side1 = 12, side2 = 12, side3 = 12;
            //Arrange
            string expectedResult = "Equilateral triangle";
            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        // Unit test for checking whether the sides given return a Isoceles triangle or not
        [TestMethod]
        public void IsocelesTest()
        {
            int side1 = 12, side2 = 12, side3 = 10;
            //Arrange
            string expectedResult = "Isoceles triangle";
            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        // Unit test for checking whether the sides given return a string 'do not form triangle'
        [TestMethod]
        public void NotaTriangleTest()
        {
            int side1 = 0, side2 = 0, side3 = 0;
            //Arrange
            string expectedResult = "Do not form a triangle";
            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        /* Unit test for checking whether the sides given return a string 'do not form triangle' even if the values 
        can be a scalane triangle and still */
        [TestMethod]
        public void ErrorScalaneTest()
        {
            int side1 = -1, side2 = 2, side3 = 3;
            //Arrange
            string expectedResult = "Do not form a triangle";
            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        /* Unit test for checking whether the sides given return a string 'do not form triangle' even if the values 
        can be a scalane triangle and still return an error value because one side value is less than zero */
        [TestMethod]
        public void ErrorEquilateralTest()
        {
            int side1 = -2, side2 = -2, side3 = -2;
            //Arrange
            string expectedResult = "Do not form a triangle";
            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        /* Unit test for checking whether the sides given return a string 'do not form triangle' even if the values 
        can be a Isoceles triangle and still return an error value because one side value is less than zero  */
        [TestMethod]
        public void ErrorIsocelesTest()
        {
            int side1 = -2, side2 = 5, side3 = -2;
            //Arrange
            string expectedResult = "Do not form a triangle";
            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
