using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal static class Calculator
    {
        public static int Calculate(string op, int value1, int value2)
        {
            //Usando o if
            if (op == "+")
            {
                return value1 + value2;
            }
            if (op == "-")
            {
                return value1 - value2;
            }
            if (op == "*")
            {
                return value1 * value2;
            }
            if (op == "/")
            {
                return value1 / value2;
            }

            switch (op)
            {
                case "+":
                    return value1 + value2;
                case "-":
                    return value2 - value2;
                case "*":
                    return value2 * value2;
                case "/":
                    return value2 / value2;
                default:
                    return 0;
            }
        }
    }
}