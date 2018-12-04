using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_paskaita_2018_12_04.Interfaces
{
    interface IRenderable
    {
        void Render();
        int Age { get; set; }
    }
}
