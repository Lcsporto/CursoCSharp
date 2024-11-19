using System.IO;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Using Block

                Sintaxe Simplificada que garante que os objetos IDisposable serão fechados.

                Objetos IDisposable NÃO são gerenciados pelo CLR. Eles precisam ser manualmente fechados. 
                    Exemplos: Font, FileStream, StreamReader, StreamWriter
             */

            string path = @"E:\Estudos 2.0\C#\CursoCSharp\029. Using Block\file1.txt";

            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open)) // O bloco 'Using' serve parautilizarmos o arquivo e ele fechará automaticamente ao final da execução.
                //{
                using (StreamReader sr = File.OpenText(path))//new StreamReader(fs)) // Podemos cascatear dentro do bloco Using
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                //}
            }
            catch (IOException e)
            {
                Console.WriteLine("An error Occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
