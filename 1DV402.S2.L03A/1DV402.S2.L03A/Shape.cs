using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    // Enum type defining which type of shapes the application can handle.
    public enum ShapeType { Indefinite, Ellipse, Rectangle };

    /// <summary>
    /// Base class containing members which are mutual to Ellipses and Rectangles, including a string representation of an instance's value used in the final presentation.
    /// </summary>
    public abstract class Shape
    {
        private double _length;
        private double _width;

        public abstract double Area { get;}

        public double Length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
        }

        public abstract double Perimeter { get;}

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }

        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return (string.Format("Längd  :\t{0:0.00}\nBredd  :\t{1:0.00}\nOmkrets:\t{2:0.0}\nArea   :\t{3:0.0}", Length, Width, Perimeter, Area));
        }
    }
}
