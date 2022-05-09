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
        private int EqualSide;

        public Trapez(int longSide, int equalSide) : base(longSide)
        {
            LongSide = longSide;
            EqualSide = equalSide;
        }

        public override double Perimiter()
        {
            double height = HeightCalculator();

            return ((0.5) * height * ((LongSide * 2) + (EqualSide * 2)));
        }

        public override double Area()
        {
            
            return ((LongSide * 2) + (EqualSide * 2));
        }

        private double HeightCalculator()
        {
            double s = (LongSide + EqualSide) - (EqualSide + EqualSide) / 2;

            return (2 / (LongSide - EqualSide) * Math.Sqrt(s * (s - LongSide + EqualSide) * (s - EqualSide) * (s - EqualSide)));
        }
    }
}
