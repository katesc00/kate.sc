using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KARDEX DE INGENIERÍA BIOMÉDICA \n");
            Class1.Datos();
            Console.WriteLine("Servicios: \n");
            int servicio;
            Console.WriteLine("1. Clases según el semestre que cursas");
            Console.WriteLine("2. Calificaciones finales");
            Console.WriteLine("3. Especialidades de la carrera");
            servicio = int.Parse(Console.ReadLine());
            switch (servicio)
            {
                case 1:
                    Class2.Semestre();
                    break;
                case 2:
                    Class3.Calificaciones();
                    break;
                case 3:
                    Class4.Especialidades();
                    break;
                default:
                    Console.WriteLine("Esta opción no existe");
                    break;
            }
            Console.ReadKey();

        }
    }
}
