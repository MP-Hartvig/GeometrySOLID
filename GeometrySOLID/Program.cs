using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number between 10 and 15: ");
            string firstInput = Console.ReadLine();
            double longSide = Convert.ToDouble(firstInput);

            Console.Write("Write a number between 5 and 10: ");
            string secondInput = Console.ReadLine();
            double shortSide = Convert.ToDouble(secondInput);

            Console.Write("Write a number between 8 and 12: ");
            string thirdInput = Console.ReadLine();
            double cathetus1 = Convert.ToDouble(thirdInput);

            Console.Write("Write a number between 8 and 12: ");
            string fourthInput = Console.ReadLine();
            double cathetus2 = Convert.ToDouble(fourthInput);

            Console.Write("Write a number between 5 and 15: ");
            string fifthInput = Console.ReadLine();
            double height = Convert.ToDouble(fifthInput);

            Console.Write("Write a number between 20 and 40: ");
            string sixthInput = Console.ReadLine();
            double tilt = Convert.ToDouble(sixthInput);

            Square square = new Square(longSide);
            Trapez trapez = new Trapez(longSide, shortSide);
            Rectangle rectangle = new Rectangle(longSide, shortSide);
            Parallelogram parallelogram = new Parallelogram(longSide, shortSide, height, tilt);
            OrthogonalTriangle triangle = new OrthogonalTriangle(longSide, cathetus1, cathetus2);

            List<Square> list = new List<Square>();

            list.Add(square);
            list.Add(trapez);
            list.Add(rectangle);
            list.Add(parallelogram);
            list.Add(triangle);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Perimiter: " + list[i].Perimiter());
                Console.WriteLine("Area: " + list[i].Area());
            }

            //Random random = new Random();

            //int longSide = random.Next(10, 21);
            //int shortSide = random.Next(1, 10);
            //int cathetus1 = random.Next(5, 10);
            //int cathetus2 = random.Next(5, 10);
            //int height = random.Next(3, 7);
            //int tilt = random.Next(20, 50);

            //Console.WriteLine($"Long side: {longSide}\nShort side: {shortSide}\nHeight: {height}");

            //Console.WriteLine("Square perimiter: " + square.Perimiter());
            //Console.WriteLine("Square area: " + square.Area());

            //Console.WriteLine("Trapez perimiter: " + trapez.Perimiter()); // Logic needs rework
            //Console.WriteLine("Trapez area: " + trapez.Area());

            //Console.WriteLine("Rectangle perimiter: " + rectangle.Perimiter());
            //Console.WriteLine("Rectangle area: " + rectangle.Area());

            //Console.WriteLine("Parallelogram perimiter: " + parallelogram.Perimiter());
            //Console.WriteLine("Parallelogram area: " + parallelogram.Area());

            //Console.WriteLine("Orthogonal perimiter: " + triangle.Perimiter());
            //Console.WriteLine("Orthogonal area: " + triangle.Area()); // Logic needs rework

            Console.ReadLine();
        }
    }
}
