using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Geometriska Figurer - Nivå A";


        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            Shape el1 = new Ellipse();

            return el1;
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            return 1;
        }

        private static void ViewMenu()
        {

        }
        private static void ViewShapeDetail(Shape shape)
        {

        }
    }
}
