using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    class Ellipse : Shape
    {
        public override double Area
        {
            get { return 0; }
        }

        public override double Perimeter
        {
            get { return 0; }
        }

        public Ellipse()
            : base(0, 0)
        {
            
        }
    }
}
