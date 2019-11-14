using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StaticModel.fieldOne); 
            Console.WriteLine(StaticModel.fieldTwo);
            Console.WriteLine();

            StaticClassAccessModel.Fun();

            Console.WriteLine(StaticModel.fieldOne);
            Console.WriteLine(StaticModel.fieldTwo);

            Console.WriteLine();

            Test test = new Test();

            Console.WriteLine(StaticModel.fieldOne);
            Console.WriteLine(StaticModel.fieldTwo);

            Console.WriteLine(@"Press any key to exit...");
            Console.ReadKey();
        }
    }
}
