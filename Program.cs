using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bit = int.Parse(Console.ReadLine());
            var china = double.Parse(Console.ReadLine());
            var k = double.Parse(Console.ReadLine());
            var lv = bit * 1168;
            var d = china * 0.15;
            var lv1=d*1.76;
            var sum = (lv+lv1)/1.95;
            var sum1 =k/100*sum ;
            var vs = sum - sum1;
            Console.WriteLine(vs);

        }
    }
}
