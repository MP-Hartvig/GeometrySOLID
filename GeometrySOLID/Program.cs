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
            //Random random = new Random();

            //int longSide = random.Next(10, 21);
            //int shortSide = random.Next(1, 10);
            //int cathetus1 = random.Next(5, 10);
            //int cathetus2 = random.Next(5, 10);
            //int height = random.Next(3, 7);
            //int tilt = random.Next(20, 50);

            Console.Write("Write a number between 10 and 15: ");
            string firstInput = Console.ReadLine();
            int longSide = Convert.ToInt32(firstInput);

            Console.Write("Write a number between 5 and 10: ");
            string secondInput = Console.ReadLine();
            int shortSide = Convert.ToInt32(secondInput);

            Console.Write("Write a number between 8 and 12: ");
            string thirdInput = Console.ReadLine();
            int cathetus1 = Convert.ToInt32(thirdInput);

            Console.Write("Write a number between 8 and 12: ");
            string fourthInput = Console.ReadLine();
            int cathetus2 = Convert.ToInt32(fourthInput);

            Console.Write("Write a number between 5 and 15: ");
            string fifthInput = Console.ReadLine();
            int height = Convert.ToInt32(fifthInput);

            Console.Write("Write a number between 20 and 40: ");
            string sixthInput = Console.ReadLine();
            int tilt = Convert.ToInt32(sixthInput);

            Square square = new Square(longSide);
            Trapez trapez = new Trapez(longSide, shortSide);
            Rectangle rectangle = new Rectangle(longSide, shortSide);
            Parallelogram parallelogram = new Parallelogram(longSide, shortSide, height, tilt);
            OrthogonalTriangle triangle = new OrthogonalTriangle(longSide, cathetus1, cathetus2);

            List<object> list = new List<object>();

            foreach (var item in list)
            {
                
            }

            Console.WriteLine($"Long side: {longSide}\nShort side: {shortSide}\nHeight: {height}");

            Console.WriteLine("Square perimiter: " + square.Perimiter());
            Console.WriteLine("Square area: " + square.Area());

            Console.WriteLine("Trapez perimiter: " + trapez.Perimiter()); // Logic needs rework
            Console.WriteLine("Trapez area: " + trapez.Area());

            Console.WriteLine("Rectangle perimiter: " + rectangle.Perimiter());
            Console.WriteLine("Rectangle area: " + rectangle.Area());

            Console.WriteLine("Parallelogram perimiter: " + parallelogram.Perimiter());
            Console.WriteLine("Parallelogram area: " + parallelogram.Area());

            Console.WriteLine("Orthogonal perimiter: " + triangle.Perimiter());
            Console.WriteLine("Orthogonal area: " + triangle.Area()); // Logic needs rework

            Console.ReadLine();
        }
    }
}
