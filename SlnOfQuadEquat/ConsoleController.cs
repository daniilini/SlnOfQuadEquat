using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnOfQuadEquat
{
    class ConsoleController
    {
        public string Read()
        {
            return Console.ReadLine();
        }

        public void WriteTheAnswer(List<double> slns)
        {
            if (slns.Count == 2)
                Console.WriteLine("Найдено два корня: x1 = " + slns[0] + ", x2 = " + slns[1]);
            if (slns.Count == 1)
                Console.WriteLine("Найдено одно решение: x = " + slns[0]);
            if (slns.Count == 0)
                Console.WriteLine("Не найдено ни одного корня");
        }

        public void WriteTheMessage(string str)
        {
            Console.WriteLine(str);
        }
    }
}
