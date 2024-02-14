using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosaRadianes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertidor de Grados y Radianes");
            Console.WriteLine("Seleccione la conversión:");
            Console.WriteLine("1. Grados a Radianes");
            Console.WriteLine("2. Radianes a Grados");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ConvertirGaR();
                    Console.ReadKey();
                    break;
                case 2:
                    ConvertirRaG();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione 1 o 2.");
                    Console.ReadKey();
                    break;
            }
        }
        static void ConvertirGaR()
        {
            Console.Write("Ingrese la medida en grados: ");
            double grados = double.Parse(Console.ReadLine());
            double radianes = grados * (Math.PI / 180);
            Console.WriteLine($"{grados} grados es equivalente a {radianes} radianes.");
        }

        static void ConvertirRaG()
        { 
            Console.Write("Ingrese la medida en radianes: ");
            double radianes = double.Parse(Console.ReadLine());
            double grados = radianes * (180 / Math.PI);
            Console.WriteLine($"{radianes} radianes es equivalente a {grados} grados.");
        }
    }
}
