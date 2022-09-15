using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLambdaV
{
    public delegate int DeistviaDliaBygalterov(int dohodu, int rashodu);
    public delegate bool DeistviaDliaFinansistov(int schet);

    internal class Program
    {
        static void Main(string[] args)
        {
            DeistviaDliaBygalterov rabotaBygaltera = delegate(int pribul, int rastratu) 
            { 
                return pribul - rastratu; 
            };


            Bygalter serega = new Bygalter();
            serega.Deistvia = rabotaBygaltera;
            int otchet = serega.Deistvia(1000, 2300);



        }
    }

    class Bygalter
    {
        public DeistviaDliaBygalterov Deistvia { get; set; }
    }

    class FinansovuiAnalituk
    {
        public DeistviaDliaBygalterov Deistvia { get; set; }
    }
}
