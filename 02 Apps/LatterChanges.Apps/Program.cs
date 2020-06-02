using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatterChanges.Logic;

namespace LatterChanges.Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            var latterChangeLogic = new LatterChangeLogic();

            Console.WriteLine($"Input: hello*3 : OutPut : {latterChangeLogic.GetChangeLatter("hello*3")}");
            Console.WriteLine($"Input: fun times! : OutPut : {latterChangeLogic.GetChangeLatter("fun times!")}");
            Console.ReadLine();
        }
    }
}
