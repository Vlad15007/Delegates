using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAnonim
{

    public delegate void Deistvia();

    internal class Program
    {
        static void Main(string[] args)
        {
            Deistvia plan = delegate
            {
                Console.WriteLine("План");
                Console.WriteLine("1 - Сходи");
                Console.WriteLine("2 - Подай");
                Console.WriteLine("3 - Принеси");
            };




            Sotrydnik mark = new Sotrydnik("Марк", plan);
            mark.Rabotat();


            Deistvia newPlan = delegate
            {
                Console.WriteLine();
                Console.WriteLine("План");
                Console.WriteLine("1 - Сходи");
                Console.WriteLine("2 - Принеси");
                Console.WriteLine("3 - Подай");
            };
            mark.Deistvia = newPlan;
            mark.Rabotat();

            Console.ReadKey();
        }
    }

    class Sotrydnik
    {
        public string Name { get; set; }
        public Deistvia Deistvia { get; set; }

        public Sotrydnik(string name, Deistvia deistvia)
        {
            Deistvia = deistvia;
        }

        public void Rabotat()
        {
            Deistvia();
        }
    }
}
