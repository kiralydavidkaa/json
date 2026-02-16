using System.Text.Json;
using System.Text.Json.Nodes;

namespace ConsoleApp7
{
    class adat
    {
        public List<string> nevek { get; set; }

        public List<int> korok { get; set; }
    }

    class diak
    {
        public string nev { get; set; }
        public int jegyek { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = File.ReadAllText("json.json", System.Text.Encoding.Latin1);
            Console.WriteLine(fajl);
            adat adat = JsonSerializer.Deserialize<adat>(fajl);

            foreach (var nev in adat.nevek)
            {
                Console.WriteLine(nev);
            }
            Console.WriteLine($"{adat.nevek[0]} életkora: { adat.korok[0]}");
        }
    }
}
