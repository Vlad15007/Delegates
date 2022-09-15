using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    static class Tancu
    {
        public static void Step()
        {
            Console.WriteLine("Танцую степ");
        }

        public static void Tango()
        {
            Console.WriteLine("Танцую танго");
        }

        public static void Vals()
        {
            Console.WriteLine("Танцую вальс");
        }
    }


    public delegate void Deistvie();

    internal class Program
    {
        static void Main(string[] args)
        {
            Deistvie moieDeistvie = new Deistvie(Tancu.Step);

            moieDeistvie.Invoke();

            moieDeistvie();

            Console.ReadKey();
        }
    }
}
