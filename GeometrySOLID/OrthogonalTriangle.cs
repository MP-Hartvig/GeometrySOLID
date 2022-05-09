using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySOLID
{
    class OrthogonalTriangle : Square
    {
        private int Hypotenusen;
        private int Cathetus1;
        private int Cathetus2;

        public OrthogonalTriangle(int hypotenusen, int cathetus1, int cathetus2) : base(hypotenusen)
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
