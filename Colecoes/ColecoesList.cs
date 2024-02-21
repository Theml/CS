using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        // Referente a Igualdade
        //public override bool Equals(object obj)
        //{
        //    Produto outroProduto = (Produto)obj;
        //    bool mesmoNome = Nome == outroProduto.Nome;
        //    bool mesmoPreco = Preco == outroProduto.Preco;
        //    return mesmoNome && mesmoPreco;
        //}
        public override bool Equals(object obj)
        {
            var produto = obj as Produto;
            return produto != null &&
                Nome == produto.Nome &&
                Preco == produto.Preco;
        }

        //public override int GetHashCode()
        //{
        //    return Nome.Length;
        //}

        // Alteração que afeta o Set 
        public override int GetHashCode()
        {
            var hashCode = -347481536;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();

            return hashCode;
        }
    }
    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8° Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            Console.WriteLine("Itens no carrinho: {0} ", carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.WriteLine("Numeração do item no carrinho: {0}", carrinho.IndexOf(item));
                Console.WriteLine($"Item: {item.Nome}, Preço: {item.Preco}");
            }

            Console.WriteLine("Itens no carrinho: {0} ", carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine("Numeração ultimo item do carrinho: {0}", carrinho.LastIndexOf(livro));
        }
    }
}
