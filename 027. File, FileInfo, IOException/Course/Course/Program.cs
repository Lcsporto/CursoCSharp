using System.IO;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Namespace System.IO

            Realiza operações com arquivos (create, copy, delete, move, open, etc.) e ajuda na criação de objetos FileStream.

            File
                Static members (simples, mas realiza verificação de segurança para cada operação)

            FileInfo
                instance members

            IOException - Superclasse de todas as exceções dos File e FileInfo
             */

            string sourcePath = @"E:\Estudos 2.0\C#\CursoCSharp\027. File, FileInfo, IOException\file1.txt"; // Caminho criado com o file
            string targetPath = @"E:\Estudos 2.0\C#\CursoCSharp\027. File, FileInfo, IOException\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
