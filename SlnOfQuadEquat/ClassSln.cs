using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnOfQuadEquat
{
    public class SlnOfEquat
    {
        //public List<double> slns = new List<double>();
        public List<double> Sln(List<double> numbers)
        {
            double a = numbers[0];
            double b = numbers[1];
            double c = numbers[2];
            double D = b * b - 4 * a * c;
            List<double> slns = new List<double>();
            if (D == 0)
            {
                slns.Add(-b / (2 * a));
                return slns;
            }
            else if (D > 0)
            {
                D = Math.Sqrt(D);
                slns.Add((-b + D) / (2 * a));
                slns.Add((-b - D) / (2 * a));
                return slns;
            }
            else
                return slns;
        }
    }
}
