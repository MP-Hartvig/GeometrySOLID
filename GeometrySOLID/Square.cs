using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySOLID
{
    public class Square
    {
        private double sideLength;

        public Square(double length)
        {
            sideLength = length;
        }

        public virtual double Perimiter()
        {
            return (4 * sideLength);
        }

        public virtual double Area()
        {
            return (sideLength * sideLength);
        }
    }
}
