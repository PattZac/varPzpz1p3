using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varPzpz1p3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite neku rečenicu: ");
            string s = Console.ReadLine();
            Console.WriteLine(s.Substring(0,s.IndexOf(' '))+
                s.Substring(s.LastIndexOf(' ') , s.Length-s.LastIndexOf(' ')));
            Console.ReadKey();
        }
    }
}
