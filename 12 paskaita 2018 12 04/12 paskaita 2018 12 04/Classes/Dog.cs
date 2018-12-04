using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_paskaita_2018_12_04.Classes
{
    class Dog : IPrintable, IMovable
    {
        public void Print() { Console.WriteLine(name); }
    
        private string name = "Brisius";
        private string color = "Juodas";
        private string breed = "Lenciuginis";
        private int age = 6;
        public Dog()
        {

        }
        public string Name { get; set; }
        public void Move()
        {

        }
        public string Action { get; set; }
    }
}
