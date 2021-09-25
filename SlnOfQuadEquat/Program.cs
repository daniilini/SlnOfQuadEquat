using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnOfQuadEquat
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleController consoleController = new ConsoleController();
            Parser parser = new Parser();
            SlnOfEquat slnOfEquat = new SlnOfEquat();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            while (true)
            {
                consoleController.WriteTheMessage("Для уравнения вида ax^2 + bx + c = 0 введите переменные a, b c через пробел после чего нажмите Enter");
                List<double> numbers = parser.Parse(consoleController.Read());
                consoleController.WriteTheAnswer(slnOfEquat.Sln(numbers));
            }
        }
    }
}
