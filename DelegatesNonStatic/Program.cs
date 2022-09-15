using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesNonStatic
{
    interface IBorba
    {
        void Bitva();
    }

    class Thekvondo : IBorba
    {
        public void Bitva()
        {
            Console.WriteLine("Взмахи руками и ногами");
        }
    }

    class Boks : IBorba
    {
        public void Bitva()
        {
            Console.WriteLine("Двойка");
        }
    }

    class Boec
    {
        public string Name { get; set; }
        public IBorba Type { private get; set; }

        public void Srajatsa()
        {
            Type.Bitva();
        }

        public Boec(string name)
        {
            Name = name;
        }
    }


    public delegate void Gazeta();

    internal class Program
    {
        static void Main(string[] args)
        {
            Boec Ysik = new Boec("Усик");
            Ysik.Type = new Boks();



            Gazeta novost = Ysik.Srajatsa;

            novost.Invoke();
            novost();


            Console.ReadKey();
        }
    }
}
