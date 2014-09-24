using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01And02And03
{
    class Point3D
    {
        private string name;
        private double x;
        private double y;
        private double z;

        public static readonly Point3D startingPoint;

        static Point3D()
        {
            startingPoint = new Point3D("Center", 0, 0, 0);
        }

        public Point3D(string name, double x, double y, double z)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z 
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D StartingPoint
        {
            get { return Point3D.startingPoint; }
        }

        public override string ToString()
        {
            return String.Format("{0} (X = {1:F}, Y = {2:F}, Z = {3:F})", this.Name.ToString(), this.X.ToString(), this.Y.ToString(), this.Z.ToString());
        }
    }
}
