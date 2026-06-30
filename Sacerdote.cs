using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sacerdote : Personaje
    {
        public Sacerdote(string nombre) : base(150, nombre, 40)
        {
        }
        public override void Atacar(Personaje objetivo)
        {
            if (vivo)
            {
                Console.WriteLine(Nombre + " ataco con un Rayo de luz a " + objetivo.Nombre + " y le causo " + daño + " DMG");
                objetivo.RecibirDaño(daño);
            }
            else
            {
                Console.WriteLine(Nombre + " esta muerto, DEJALO EN PAAAZZZZ");
            }
        }
        public void Curar(Personaje objetivo, int cura)
        {
            if (objetivo is ICurable curable)
            {
                curable.RecibirCura(cura);
                Console.WriteLine(Nombre + " curo a " + objetivo.Nombre + " " + cura + " PV");
            }
            else
            {
                Console.WriteLine(Nombre + " intento curar a  " + objetivo.Nombre + " pero no fue posible");
            }
        }
    }
}