using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        public class Taller
        {
            private string vehiculo;
            private string trabajador;
            private int servicio;

            public Taller()
            {
                Console.WriteLine("Ingrese el tipo de vehiculo");
                vehiculo = Console.ReadLine();
                Console.WriteLine("Nombre del trabajador");
                trabajador = Console.ReadLine();          

            }

            public void Servicio()
            {
                Console.WriteLine("Qué servicio se realizará?\n  1. cambio de aceite\n 2.cambio de balatas\n 3.cambio de bujias\n ");
                servicio = int.Parse(Console.ReadLine());


                switch (servicio)
                {
                    case 1:
                        Console.WriteLine("cambio de aceite\n el precio es $300");
                        break;
                    case 2:
                        Console.WriteLine("cambio de balatas\n el precio es $500");
                        break;
                    default:
                        Console.WriteLine("No existe");
                        break;
                }
            }

        }

}

