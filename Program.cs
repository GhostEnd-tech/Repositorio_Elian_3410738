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
            Guerrero g1 = new Guerrero("Guerrero");
            Mago m1 = new Mago("Mago");
            Sacerdote s1 = new Sacerdote("Sacerdote");

            g1.Atacar(m1);
            m1.Atacar(g1);

            s1.Curar(m1, 30);
            g1.Atacar(m1);
            g1.Atacar(s1);
            s1.Atacar(g1);
            g1.Atacar(m1);
            m1.Atacar(g1);
            s1.Curar(s1, 50);

            m1.MostrarDatos();
            g1.MostrarDatos();
            s1.MostrarDatos();
        }
    }
}