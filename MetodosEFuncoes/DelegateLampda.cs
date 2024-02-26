using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);
    class DelegateLampda
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;
            Operacao div = (x, y) => x / y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(3, 3));
            Console.WriteLine(div(9, 3));
        }
    }
}
