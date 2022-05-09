using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySOLID
{
    class Parallelogram : Square
    {
        private int LongSide;
        private int ShortSide;
        private int Height;
        private int Tilt;

        public Parallelogram(int longSide, int shortSide, int height, int tilt) : base(longSide)
        {
            LongSide = longSide;
            ShortSide = shortSide;
            Height = height;
            Tilt = tilt;
        }

        public override double Perimiter()
        {
            return (Height * LongSide);
        }

        public override double Area()
        {
            return (LongSide * ShortSide * Math.Sin(Tilt));
        }
    }
}
