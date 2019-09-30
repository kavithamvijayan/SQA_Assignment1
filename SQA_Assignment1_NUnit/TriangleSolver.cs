using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment1_NUnit
{
    public static class TriangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
        {
            //initializing string triangleTestResult
            string trangleTestResult;
            // checking whether the sides entered is less than 0 or not
            if(side1<=0 || side2<=0 || side3<=0)
            {
                trangleTestResult = "Do not form a triangle";
            }
            // checking whether the sides entered can be of Equilateral triangle
            else if ((side1 == side2) & (side2 == side3) & (side3 == side1))
            {
                trangleTestResult = "Equilateral triangle";
            }
            // checking whether the sides entered can be of Isoceles triangle
            else if (side1 == side2 | side2 == side3 | side3 == side1)
            {
                trangleTestResult = "Isoceles triangle";
            }
            // checking whether the sides entered can be of Scalene triangle
            else if ((side1 != side2) | (side2 != side3) | (side3 != side1))
            {
                trangleTestResult = "Scalene triangle";
            }             
            else
            {
                trangleTestResult = "Do not form a triangle";
            }
            return trangleTestResult;
        }
    }
}

