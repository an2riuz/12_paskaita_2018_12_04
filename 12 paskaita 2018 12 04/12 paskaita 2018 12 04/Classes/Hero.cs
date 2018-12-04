using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_paskaita_2018_12_04.Classes
{
    class Hero : IPrintable
    {
        public void Print() { Console.WriteLine( name); }

        private string name = "Rembo";
        private string film = "Pats baisiausias";
        private int year = 2006;

        public Hero()
        {

        }
        public string Name { get; set; }
    }
}
