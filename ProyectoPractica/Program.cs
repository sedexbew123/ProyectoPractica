using System;
using System.ComponentModel.Design;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Timers;

namespace ProyectoPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bienvenido a mi programa");

            Console.WriteLine("Ingrese el valor de X");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de Y");
            double y = double.Parse(Console.ReadLine());

            realizarTarea(x, y);
        }

        static void realizarTarea(double x, double y)
        {
            Punto origen = new Punto();

            Punto destino = new Punto(x, y);

            double distancia = origen.distanciaHasta(destino);

            Console.WriteLine("El valor final es: " + distancia);
        }
    }
}