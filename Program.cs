using System.IO;
using System;

namespace Apagar_arquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destino = @"C:\Users\Matheus Canuto\Desktop\Destino";
            int nFoto = 0;
            for(int i = 100; i < 389; i++)
            {
                string sourcePath = @"C:\Users\Matheus Canuto\Desktop\Fotos ipad\DCIM\"+i+"APPLE";
                int j = i;
                foreach (string fotos in Directory.GetFiles(sourcePath))
                {
                    nFoto += 1;
                    Console.WriteLine(fotos);
                    File.Move(fotos, @"C:\Users\Matheus Canuto\Desktop\Destino\FotoMarcia"+ nFoto + " .JPG");
                }
            }

        }
    }
}