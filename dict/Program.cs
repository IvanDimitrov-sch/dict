using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        void Zadacha1()
        {
            Dictionary<int, string> dict = new();
            dict.Add(1, "");
            dict.Add(1, "");
            dict.Add(1, "");
            dict.Add(1, "");
            dict.Add(1, "");
            dict.Add(1, "");
            dict.Add(1, "");
            dict.Add(1, "");
            int k;
            if(dict.ContainsKey(k = int.Parse(Console.ReadLine())))
            {
                Console.WriteLine(dict[k]);
            }
            else
            {
                Console.WriteLine("Doesnt exist");
            }
        }
        void Zadacha2()
        {
            Dictionary<string, int> dict = new();
            string[] Arrtext = Console.ReadLine().Split(" ");
            foreach(string str in Arrtext)
            {
                if (dict.ContainsKey(str))
                {
                    dict[str] += 1;
                }else
                {
                    dict.Add(str, 1);
                }
            }
            foreach(string s in dict.Keys)
            {
                Console.WriteLine($"{s} - {dict[s]}");
            }
        }
        void Zadacha3()
        {
            SortedDictionary<int, string> sd = new();
            string t = Console.ReadLine(); 
            while(string.IsNullOrEmpty(t))
            {
                string[] k = t.Split(" ");
                sd.Add(int.Parse(k[0]), k[1]);
                t = Console.ReadLine();
            }

            foreach(KeyValuePair<int, string> kvp in sd)
            {
                Console.WriteLine($"{kvp.Key} - ${kvp.Value}");
            }


        }
    }
}
