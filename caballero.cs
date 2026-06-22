using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class caballero : Personaje, ICongelar, IQuemable
    {
        public void congelar()
        {
            Console.WriteLine("El caballero se ha congela");
        }
        
    }
}
