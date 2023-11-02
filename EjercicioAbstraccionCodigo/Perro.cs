using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsbtraccion
{
    internal class Perro : Animal
    {
            public string raza { get; set; }

            public  string obtenerTipoDeAnimal { get; set; }

            {
                return "Perro";
            }

     public string Comer ()
            {
        Console.WriteLine($"Perro esta comiendo");
            }

            public  string Dormir ()
            {
                Console.WriteLine($" Perro está durmiendo.");
            }
}

    

