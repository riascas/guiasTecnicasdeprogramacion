using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_guia_2
{
    class Plato
    {
        public Plato() { }
        public Plato(string elNombre, int cantDeIngredientes) { }

        public string elNombre;
        public int cantDeIngredientes;
        public int precioBase;

       
        public int getPrecio
        {
            get
            {
                if (cantDeIngredientes > 3)
                {
                    precioBase = cantDeIngredientes * 20;
                    return precioBase;
                }
                else
                {
                    precioBase = cantDeIngredientes * 30;
                    return precioBase;
                }
                
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Plato objPlato = new Plato();
            objPlato.elNombre = "Milanga";
            objPlato.cantDeIngredientes = 1;
            Console.WriteLine("Tu plato es: " + objPlato.elNombre);
            Console.WriteLine("Tu plato vale: " + objPlato.getPrecio + " pesos");
            Console.ReadKey();

        }
    }
}
