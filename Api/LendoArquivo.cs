using System;
using System.IO;

namespace Learning.Api
{
    class LendoArquivo
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Borracha Branca;2.89;27");
                    sw.WriteLine("Caneta Bic Preta;3.59;89");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
