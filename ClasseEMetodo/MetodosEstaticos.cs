using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.ClasseEMetodo
{
    class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {
            // Metodo de Instancia
            public int Somar(int a, int b)
            {
                return a + b;
            }

            // Metodo estatico ou Metodo de classes
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }

        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();

            Console.WriteLine(calc.Somar(2, 2));
            //Console.WriteLine(calc.Multiplicar(2, 2));

            //Console.WriteLine(CalculadoraEstatica.Somar(2, 2));
            Console.WriteLine(CalculadoraEstatica.Multiplicar(2, 2));
        }
    }
}
