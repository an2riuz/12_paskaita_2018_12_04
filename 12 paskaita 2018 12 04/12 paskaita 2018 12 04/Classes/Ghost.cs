using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_paskaita_2018_12_04.Classes
{
    class Ghost : IPrintable
    {
        public void Print() { Console.WriteLine(name); }
    
        private string name = "Baubas";
        private string color = "Pilkas";
        private int age = 289;

        public Ghost()
        {

        }
        public string Name { get; set; }
    }
}
