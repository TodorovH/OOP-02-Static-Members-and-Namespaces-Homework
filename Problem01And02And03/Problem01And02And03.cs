using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01And02And03
{
    class Problem01And02And03
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

            Console.WriteLine("The Distance between point A and point B is: " + DistanceCalculator.CalculateTheDistance(pointA, pointB));
            Console.WriteLine();

            string pathToFile = @"D:\Documents\Software University\2nd level\OOP\02.OOP-Static-Members-and-Namespaces-Homework\trunk\Problem01Point3D\Problem01Point3D\Path3D.txt";
            Path3D path = new Path3D(pointA, pointB, Point3D.StartingPoint);
            Console.WriteLine("Save path: {0}", path);
            Storage.SavePath(pathToFile, path);
            Console.WriteLine();
            Path3D path2 = new Path3D(pointA, pointB, pointC, pointD);
            Console.WriteLine("Save path: {0}", path2);
            Storage.SavePath(pathToFile, path2);
            Console.WriteLine();
            Path3D path3 = new Path3D(pointC, pointB, pointD);
            Console.WriteLine("Save path: {0}", path3);
            Storage.SavePath(pathToFile, path3);
            Console.WriteLine();
            Path3D loadPath = Storage.LoadPath(pathToFile);
            Console.WriteLine("Load path: {0}", loadPath);
        }
    }
}
