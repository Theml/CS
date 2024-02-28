using System;
using System.IO;

namespace Learning.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("Home")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            //var path = @"c:/primeiro_arquivo.txt";

            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é ");
                    sw.WriteLine("o nosso ");
                    sw.WriteLine("primeiro ");
                    sw.WriteLine("arquivo ");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
