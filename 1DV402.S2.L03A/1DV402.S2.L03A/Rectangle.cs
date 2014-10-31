using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    /// <summary>
    /// Class which implements the abstract properties (Area and Perimeter) in the base class (Shape)
    /// in order to instantiate Rectangle-objects with its specific Area and Perimeter calculations.
    /// </summary>
    public class Rectangle : Shape
    {
        public override double Area
        {
            get { return Length * Width; }
        }

        public override double Perimeter
        {
            get { return Length * 2 + Width * 2; }
        }

        public Rectangle(double length, double width)
            : base(length, width)
        {
            
        }
    }
}
