using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2009, 10, 23, 15, 30, 22);
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", d);
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", d);
        }
    }
}
