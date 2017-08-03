using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LR4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Operation.add(10, 3));
            Console.WriteLine(Operation.deduct(10, 3));
            Console.WriteLine(Operation.multiply(10, 3));
            Console.WriteLine(Operation.divide(10, 3));
            Console.WriteLine(Operation.getNod(10, 3));
            Console.ReadKey();
        }
    }
}
