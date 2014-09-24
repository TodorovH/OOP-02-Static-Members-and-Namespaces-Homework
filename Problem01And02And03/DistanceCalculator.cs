using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01And02And03
{
    static class DistanceCalculator
    {
        public static double CalculateTheDistance(Point3D pointA, Point3D pointB)
        {
            double distance = Math.Sqrt((pointB.X - pointA.X)*(pointB.X - pointA.X) + (pointB.Y - pointA.Y)*(pointB.Y - pointA.Y) + (pointB.Z - pointA.Z)*(pointB.Z - pointA.Z));
            return distance;
        }
    }
}
