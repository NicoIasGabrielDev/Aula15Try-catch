using System;
using System.IO;

namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Permissao app = new Permissao();
            app.Autorizar();

            try
            {
                using (StreamReader sr = File.OpenText("data.txt"))
                {
                    Console.WriteLine($"A primeira linha desse arquivo é: \n {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException)//tipo de erro
            {
                Console.WriteLine($"O arquivo não foi encontrado");
            }
            catch (DirectoryNotFoundException)//tipo de erro
            {
                Console.WriteLine($"O diretório não foi encontrado");
            }

        }

        private static Permissao GetApp()
        {
            return new Permissao();
        }
    }
}
