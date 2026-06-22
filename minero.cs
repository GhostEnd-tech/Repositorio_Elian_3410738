using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class minero : Personaje, IQuemable
    {
        public void Quemar()
        {
            Console.WriteLine(Nombre + "Se quemo mi muchacho;,( ");
        }
    }
}
