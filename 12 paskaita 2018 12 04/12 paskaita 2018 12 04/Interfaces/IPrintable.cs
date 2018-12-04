using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_paskaita_2018_12_04.Classes
{
    interface IPrintable
    {
        void Print();
        string Name
        {
            get;
            set;
        }
    }
}
