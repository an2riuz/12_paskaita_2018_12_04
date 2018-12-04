using _12_paskaita_2018_12_04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_paskaita_2018_12_04.Classes
{
    class Sun : IPrintable, IGlows
    {
        public void Print() { Console.WriteLine(color); }
        private string color = "Geltona";
        private int temperature = 3000;

        public Sun()
        {

        }
        public string Name { get; set; }

        public void Glow()
        {
            Console.WriteLine("Saule sviecia!");
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
