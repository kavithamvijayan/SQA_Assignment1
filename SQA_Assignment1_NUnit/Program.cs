using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment1_NUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            // printing the menu
            Console.WriteLine("1. Enter triangle dimensions\n2. Exit");
            string ans = Console.ReadLine();
            if (ans != "2")
            {
                do
                {
                    if (ans == "1")
                    {
                        string stringSide1 = string.Empty;
                        string stringSide2 = string.Empty;
                        string stringSide3 = string.Empty;
                        int side1 = 0;
                        int side2 = 0;
                        int side3 = 0;
                        // getting the sides of triangles
                        // parsing the values to ineteger using tryparse method
                        do
                        {
                            Console.Write("Enter side 1 of triangle: ");
                            stringSide1 = Console.ReadLine();
                        } while (!int.TryParse(stringSide1, out side1));
                        do
                        {
                            Console.Write("Enter side 2 of triangle: ");
                            stringSide2 = Console.ReadLine();
                        } while (!int.TryParse(stringSide2, out side2));
                        do
                        {
                            Console.Write("Enter side 3 of triangle: ");
                            stringSide3 = Console.ReadLine();
                        } while (!int.TryParse(stringSide3, out side3));
                        // invoking the Analyze method
                        string result = TriangleSolver.Analyze(side1, side2, side3);
                        Console.WriteLine(result);
                    }
                    // printing the menu in loop till you press 2
                    Console.WriteLine("\n1. Enter triangle dimensions\n2. Exit");
                    ans = Console.ReadLine();
                } while (ans != "2");
            }
        }
    }
}
