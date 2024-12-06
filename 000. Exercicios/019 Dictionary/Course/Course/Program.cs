using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> votacao = new Dictionary<string, int>();

            votacao["Alex Blue"] = 0;
            votacao["Maria Green"] = 0;
            votacao["Bob Brown"] = 0;

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        /*if (name == "Alex Blue")
                        {
                            votacao["Alex Blue"] += votes;
                        }
                        else if (name == "Maria Green")
                        {
                            votacao["Maria Green"] += votes;
                        }
                        else
                        {
                            votacao["Bob Brown"] += votes;
                        }*/

                        if (votacao.ContainsKey(name))
                        {
                            votacao[name] += votes;
                        }
                        else
                        {
                            votacao[name] = votes;
                        }
                    }
                }

                foreach (var item in votacao)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
