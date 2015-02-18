using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtension;
using MyExtension.Extension;

namespace ExtentionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 0;
            var testTab = test.ToArray();
            Console.WriteLine(testTab.GetValue(0));
            DateTime d = new DateTime();
            Console.WriteLine("extension: " + d.DaysInYear());
            Console.WriteLine("helper date: " + DateHelper.DaysInYear(new DateTime()));
            Console.WriteLine("helper string: " + DateHelper.DaysInYear("2012"));
            Console.WriteLine("helper string: " + DateHelper.DaysInYear(2015));
            Console.ReadLine();
        }
    }
}
