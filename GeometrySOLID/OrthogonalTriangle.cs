using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySOLID
{
    class OrthogonalTriangle : Square
    {
        private double Hypotenusen;
        private double Cathetus1;
        private double Cathetus2;

        public OrthogonalTriangle(double hypotenusen, double cathetus1, double cathetus2) : base(hypotenusen)
        {
            Hypotenusen = hypotenusen;
            Cathetus1 = cathetus1;
            Cathetus2 = cathetus2;
        }

        public override double Perimiter()
        {
            return (Hypotenusen + Cathetus1 + Cathetus2);
        }

        public override double Area()
        {
            return ((0.5) * Cathetus1 * Hypotenusen);
        }
    }
}
