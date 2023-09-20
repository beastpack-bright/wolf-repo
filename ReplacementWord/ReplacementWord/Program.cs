using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacementWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string, preferably containing the word 'no'");
            string s = Console.ReadLine();
            s = s.Replace("no", "yes");
            s = s.Replace("No", "Yes");
            s = s.Replace("NO", "YES");
            s = s.Replace("nO", "yES");
            Console.WriteLine(s);
        }
    }
}
