using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personaje> personajes = new List<Personaje>()
            {
            
            new Princesa("Princesa"),
            new Minero("Minero"),
            new Caballero("Caballero")

            };

            FireBall f1 = new FireBall();
            BolaHielo b1 = new BolaHielo();
           
            foreach (var item in personajes)
            {
                if (item is ICongelar congelable)
                {
                    b1.Congelar(congelable);
                }
                if (item is IQuemable quemable)
                {
                    f1.Quemar(quemable);
                }
            }

        }
    }
}
