using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //v1
            Console.WriteLine("Normal..");
            Console.Read();//auto
            //async
            Console.WriteLine("Normal.. ASYNC 1");
            Console.Read();
        }
    }
}
