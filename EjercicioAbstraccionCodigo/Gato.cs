using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsbtraccion
{
    internal class Gato : Animal
    {
        public  string obtenerTipoDeAnimal { get; set; }
        {
            return "Gato";
        }

        public string Comer ()
        {
            Console.WriteLine($"Gato está comiendo.");
        }

        public override void Dormir()
        {
            Console.WriteLine($"Gato está durmiendo.");
        }
    }

