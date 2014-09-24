using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem01And02And03
{
    static class Storage
    {
        public static void SavePath(string pathToFile, Path3D path)
        {

            if (!File.Exists(pathToFile))
            {
                using (StreamWriter sw = File.CreateText(pathToFile))
                {
                    sw.Write(path);
                }

            }
            else
            {
                File.AppendAllText(pathToFile, path.ToString());
            }
        }

        public static Path3D LoadPath(string pathToFile)
        {
            Path3D path = new Path3D();

            using (StreamReader sr = new StreamReader(pathToFile))
            {
                string readText = File.ReadAllText(pathToFile);

                string pattern = "([a-zA-Z]+) [(]X = ([0-9.]*[0-9]+), Y = ([0-9.]*[0-9]+), Z = ([0-9.]*[0-9]+)[)]";

                var regex = new Regex(pattern);
                var matches = regex.Matches(readText);

                if (matches.Count <= 0)
                {
                    throw new ApplicationException("Invalid data in file " + pathToFile);
                }

                foreach (Match match in matches)
                {
                    string str = match.Groups[1].Value;
                    double x = double.Parse(match.Groups[2].Value);
                    double y = double.Parse(match.Groups[3].Value);
                    double z = double.Parse(match.Groups[4].Value);

                    Point3D p = new Point3D(str, x, y, z);
                    path.AddPoint(p);
                }
            }

            return path;
        }
    }
}
