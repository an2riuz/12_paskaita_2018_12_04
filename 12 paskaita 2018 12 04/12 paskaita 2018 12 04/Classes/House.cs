using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_paskaita_2018_12_04.Classes
{
    class House : IPrintable
    {
        public void Print() { Console.WriteLine(type); }
        private string type = "Namas";
        private int size = 180;
        private string address = "Vilnius";

        public House()
        {

        }
        public string Name { get; set; }
    }
}
