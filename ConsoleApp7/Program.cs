using System.Text.Json.Nodes;

namespace ConsoleApp7
{
    class adat
    { 
     public List<string> nevek { get; set; }

     public List<int> korok { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = File.ReadAllText("json.json",System.Text.Encoding.Latin1);
            Console.WriteLine(fajl);
        }
    }
}
