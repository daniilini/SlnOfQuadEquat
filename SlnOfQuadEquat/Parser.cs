using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnOfQuadEquat
{
    class Parser
    {
        public List<double> Parse(string str)
        {
            return str.Split().Select(double.Parse).ToList();
        }
    }
}
