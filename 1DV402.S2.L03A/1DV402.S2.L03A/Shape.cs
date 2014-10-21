using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    public enum ShapeType { Ellipse, Rectangle }

    abstract class Shape
    {
        private double _length;
        private double _width;

        public abstract double Area 
        { 
            get { return 0; } 
        }

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

        public abstract double Perimeter
        {
            get { return 0; }
        }

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
            return (string.Format("Längd  :\t{0}\nBredd  :\t{1}\nOmkrets:\t{2}\nArea   :\t{3}", _length, _width, 0, 0));
        }
    }
}
