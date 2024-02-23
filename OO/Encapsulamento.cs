using System;
using Encapsulamento;

namespace Learning.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho não Reconhecido. . .");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(JeitoDeFalar);
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();
        
        public void MeusAcessos()
        {
            Console.WriteLine("Amigo Distante. . .");

            Console.WriteLine(amiga.InfoPublica);
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();
            Console.WriteLine();
            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            Console.WriteLine();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
