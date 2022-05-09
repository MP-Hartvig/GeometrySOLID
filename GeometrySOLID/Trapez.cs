using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySOLID
{
    class Trapez : Square
    {
        private int LongSide;
        private int ShortSide;
        private int EqualSide;

        public Trapez(int longSide, int shortSide) : base(longSide)
        {
            LongSide = longSide;
            ShortSide = shortSide;
        }

        public override double Perimiter()
        {
            double height = HeightCalculator();

            return ((1 / 2) * height * ((LongSide * 2) + (ShortSide * 2)));
        }

        public override double Area()
        {
            
            return ((LongSide * 2) + (ShortSide * 2));
        }

        private double HeightCalculator()
        {
            double s = (LongSide + EqualSide) - (ShortSide + EqualSide) / 2;

            return (2 / (LongSide - ShortSide) * Math.Sqrt(s * (s - LongSide + ShortSide) * (s - EqualSide) * (s - EqualSide)));
        }
    }
}
