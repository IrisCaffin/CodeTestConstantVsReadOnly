using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVsReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            obj.Check();
            Console.ReadLine();           
        }
    }
    class Test
    {
        readonly int read = 10;
        const int cons = 10;
        public Test()
        {
            read = 100;
        }
        public void Check()
        {
            Console.WriteLine("Read only : {0}", read);
            Console.WriteLine("const : {0}", cons);
        }
    }
}
