// See https://aka.ms/new-console-template for more information
using EjercicioAsbtraccion;

Console.WriteLine("Hello, World!");

class Programa
{
    static void Main(string[] args)
    {
        Perro perro = new Perro
        {
            nombre = "Firulais",
            edad = 5,
           Color = "Marron",
            peso = 10.5,
            raza = "Bulldog"
        };

        Gato gato = new Gato
        {
            nombre = "Whiskas",
            edad = 2,
            Color = "Gris",
            peso = 5.2
        };

        Console.WriteLine($"Datos del perro: {perro.nombre}, {perro.edad} años, {perro.Color}, {perro.peso} kg, {perro.raza}");
        Console.WriteLine($"Datos del gato: {gato.nombre}, {gato.edad} años, {gato.Color}, {gato.peso} kg");

        
    }
}