using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesReturnString
{
    interface IBorba
    {
        string Bitva();
    }

    class Thekvondo : IBorba
    {
        public string Bitva()
        {
            return "Взмахи руками и ногами";
        }
    }

    class Boks : IBorba
    {
        public string Bitva()
        {
            return "Двойка";
        }
    }

    class Boec
    {
        public string Name { get; set; }
        public IBorba Type { get; set; }
        public Boec(string name)
        {
            Name = name;
        }
    }


    public delegate string Gazeta();

    internal class Program
    {
        static void Main(string[] args)
        {
            Boec Ysik = new Boec("Усик");
            Ysik.Type = new Boks();






            Gazeta novost = Ysik.Type.Bitva;
            string novosti = novost();
            Console.WriteLine(novosti);
            


            Console.ReadKey();
        }
    }
}
