using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalculate
    {
        int Plus(int number1, int number2);
        int Minus(int number1, int number2);
        int Multiplication(int number1, int number2);
        int Divide(int number1, int number2);
    }
}
