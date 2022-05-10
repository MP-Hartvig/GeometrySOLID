using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySOLID
{
    class Parallelogram : Square
    {
        private double LongSide;
        private double ShortSide;
        private double Height;
        private double Tilt;

        public Parallelogram(double longSide, double shortSide, double height, double tilt) : base(longSide)
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
