using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySOLID
{
    class Trapez : Square
    {
        private double LongSide;
        private double EqualSide;

        public Trapez(double longSide, double equalSide) : base(longSide)
        {
            LongSide = longSide;
            EqualSide = equalSide;
        }

        public override double Perimiter() // Something here doesn't work
        {
            double height = HeightCalculator();

            return ((0.5) * height * ((LongSide * 2) + (EqualSide * 2)));
        }

        public override double Area()
        {            
            return ((LongSide * 2) + (EqualSide * 2));
        }

        private double HeightCalculator() // Might be this calculation which is wrong
        {
            double s = ((LongSide + EqualSide) - (EqualSide + LongSide)) / 2;

            return ((2 / (LongSide - EqualSide)) * Math.Sqrt((s * (s - LongSide + EqualSide) * (s - EqualSide) * (s - EqualSide))));
        }
    }
}
