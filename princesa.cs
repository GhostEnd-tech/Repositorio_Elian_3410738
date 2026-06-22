using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class princesa : Personaje, ICongelar
    {
        public void congelar()
        {
            Console.WriteLine("La princesa se ha congela");
        }
    }
}
