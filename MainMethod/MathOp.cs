using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MathOp
    {
        public int Sum(int i, int i2)
        {
            int num1 = i;
            int num2 = i2;
            return num1 + num2;
        }

        public decimal Sum(decimal i, int i2)
        {
            decimal num1 = i;
            int num2 = i2;
            return num1 - num2;
        }

        public int Sum(string i, int i2)
        {
            string str1 = i;
            int parse = Int32.Parse(str1);
            int num1 = i2 * parse;
            return num1;
        }

    }
}

