using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp Operaciones = new MathOp();
            int input = 5;
            int input2 = 6;
            int results = Operaciones.Sum(input, input2);

            Console.WriteLine(results);

            decimal input3 = 12.013547m;
            int input4 = 6;
            decimal results2 = Operaciones.Sum(input3, input4);

            Console.WriteLine(results2);

            string input5 = "50";
            int input6 = 5;
            int results3 = Operaciones.Sum(input5, input6);

            Console.WriteLine(results3);


            Console.ReadLine();
        }
    }
}
