using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesBoks
{
    class Bokser
    {
        public string Name { get; set; }
        public Bokser(string name)
        {
            Name = name;
        }

        public void PravuiYdar()
        {
            Console.WriteLine("Удар правой рукой");
        }

        public void LevuiYdar()
        {
            Console.WriteLine("Удар левой рукой");
        }

        public void Yvorot()
        {
            Console.WriteLine("Уклон");
        }
    }

    public delegate void Kombinacii();

    internal class Program
    {
        static void Main(string[] args)
        {
            Bokser Ysik = new Bokser("Усик");

            Kombinacii kombo = null;
            Kombinacii ydarPravoi = Ysik.PravuiYdar;
            Kombinacii ydarLivou = Ysik.LevuiYdar;
            Kombinacii yvorot = Ysik.Yvorot;

            kombo = ydarLivou + ydarLivou + yvorot + ydarPravoi;

            kombo();

            Console.ReadKey();

        }
    }
}
