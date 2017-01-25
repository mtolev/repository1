using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            decimal n = 0;
            for (int i = 0; i < chislo; i++)
                n += decimal.Parse(Console.ReadLine());
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}