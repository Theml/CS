using System;
using System.IO;

namespace Learning.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirPojeto = @"~/Documents/Github/CS".ParseHome();

            var dirInfo = new DirectoryInfo(dirPojeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("\n\n == Arquivo ==");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n === Diretorios ===");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine();
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}
