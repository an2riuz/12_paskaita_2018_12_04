using _12_paskaita_2018_12_04.Classes;
using System;
using System.Collections.Generic;

namespace _12_paskaita_2018_12_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog suo = new Dog();
            Ghost vaiduoklis = new Ghost();
            Hero herojus = new Hero();
            House namas = new House();
            Sun saule = new Sun();
            suo.Print();
            saule.Glow();

            List<IPrintable> sarasas = new List<IPrintable>();
            sarasas.Add(herojus);
            sarasas.Add(suo);
            sarasas.Add(namas);

            Console.ReadKey();
        }
    }
}
