using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("A", 1.89); 
            var p2 = new Produto("A", 1.89);
            var p3 = p2;

            
            Console.WriteLine(p1 == p2);//comparação de localização de memoria atribuição de valor então retorna falso
            Console.WriteLine(p3 == p2);// deve retorna true atribuição por referência

            Console.WriteLine(p1.Equals(p2));
        }
    }
}
