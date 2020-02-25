using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elige una opción");
            Console.WriteLine("1. Clase Taller ");
            Console.WriteLine("2. clase coche");
            Console.WriteLine("3. clase biblioteca ");
            Console.WriteLine("4. clase libro");
            Console.WriteLine("5. clase ordenador");
            Console.WriteLine("6. clase telefono");
            Console.WriteLine("7. clase figuras");
            int opcion;
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:

                    Console.WriteLine(" Clase Taller ");

                    Taller t = new Taller();
                    t.Servicio();
                    break;
                case 2:
                    Console.WriteLine(" clase coche");
                    coche c = new coche();
                    break;
                case 3:
                    Console.WriteLine("clase biblioteca ");
                    biblioteca b = new biblioteca();
                    b.prestamo();
                    break;
                case 4:
                    Console.WriteLine(" clase libro");
                    libro l = new libro();
                    break;
                case 5:
                    Console.WriteLine("clase ordenador");
                    ordenador o = new ordenador();

                    break;
                case 6:
                    Console.WriteLine("clase telefono");
                    telefono tel = new telefono();
                    tel.llamar();
                    tel.textear();
                    break;
                case 7:
                    Console.WriteLine("clase figuras");
                    figuras f = new figuras();
                    f.area();
                    f.perimetro();

                    break;
                default:
                    break;
            }


        }
    }
}
