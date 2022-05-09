using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySOLID
{
    class Rectangle : Square
    {
        private int ShortSide;
        private int LongSide;

        public Rectangle(int longSide, int shortSide) : base(longSide)
        {
            ShortSide = shortSide;
            LongSide = longSide;
        }

        public override double Perimiter()
        {
            return (2 * (LongSide + ShortSide));
        }

        public override double Area()
        {
            return (ShortSide * LongSide);
        }
    }
}
