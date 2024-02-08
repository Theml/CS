using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.ClasseEMetodo
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalculadorDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
     
    class AtributosEstaticos
    {   
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
            };

            Console.WriteLine("Preço com Desconto: {0}", produto1.CalculadorDesconto());
            Console.WriteLine("Preço com Desconto: {0}", produto2.CalculadorDesconto());

            Produto.Desconto = 0.5;


            Console.WriteLine("Preço com Desconto: {0}", produto1.CalculadorDesconto());
            Console.WriteLine("Preço com Desconto: {0}", produto2.CalculadorDesconto());

            Produto.Desconto = 0.02;
        }
    }
}
