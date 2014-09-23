using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Point3D
{
    class Problem01Point3D
    {
        static void Main(string[] args)
        {
            Point3D pointA = new Point3D("A", 6, 5, 8);
            Point3D pointB = new Point3D("B", 1.5, 8, 2.3);
            Point3D pointC = new Point3D("C", 9, 3, 7.5);
            Point3D pointD = new Point3D("D", 3, 1, 4.5);

            Console.WriteLine(Point3D.StartingPoint.ToString());
            Console.WriteLine();
            Console.WriteLine(pointA.ToString());
            Console.WriteLine();
            Console.WriteLine(pointB.ToString());
            Console.WriteLine();
            Console.WriteLine(pointC.ToString());
            Console.WriteLine();
            Console.WriteLine(pointD.ToString());
            Console.WriteLine();
        }
    }
}
