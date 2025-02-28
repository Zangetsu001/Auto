using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile auto1 = new Automobile("Жигули", 1999);
            Automobile auto2 = new Automobile("Жигули", 2001);
            Automobile auto3 = new Automobile("Жигули", 2005);
            Automobile auto4 = new Automobile("Жигули", 2045);

            Console.WriteLine($"Марка: {auto1.Model}\t Год Производства: {auto1.Year}");
            Console.WriteLine($"Марка: {auto2.Model}\t Год Производства: {auto2.Year}");
            Console.WriteLine($"Марка: {auto3.Model}\t Год Производства: {auto3.Year}");
            Console.WriteLine($"Марка: {auto4.Model}\t Год Производства: {auto4.Year}");
            Console.WriteLine(Automobile.totalcars);

            Console.Read();
        }
    }
}
