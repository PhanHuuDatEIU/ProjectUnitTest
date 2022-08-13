using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUnitTest.Data
{
    public class Triangle
    {
        public int EdgeA { get; private set; }
        public int EdgeB { get; private set; }
        public int EdgeC { get; private set; }
        public string TriangleType { get; private set; }

        public Triangle(int edgeA, int edgeB, int edgeC)
        {
            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;
            TriangleType = GetTriangleType();
        }

        public string GetTriangleType()
        {
            bool isValidInput = CheckInput(EdgeA) && CheckInput(EdgeB) && CheckInput(EdgeC);
            if (isValidInput)
            {
                if (IsTriangle(EdgeA, EdgeB, EdgeC))
                {
                    if (EdgeA == EdgeB && EdgeB == EdgeC)
                    {
                        return "Equilateral triangle";
                    }
                    else if (EdgeA == EdgeB || EdgeA == EdgeC || EdgeB == EdgeC)
                    {
                        return "Isosceles triangle";
                    }
                    else
                    {
                        return "Scalene triangle";
                    }
                }
                return "Not a triangle";
            }
            return "Invalid input";
        }
        private bool CheckInput(int edge)
        {
            if (edge >= 5 && edge <= 205)
            {
                return true;
            }
            return false;
        }

        private bool IsTriangle(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }
    }
}
