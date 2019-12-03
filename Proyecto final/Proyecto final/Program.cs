using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
                Console.WriteLine("Bienvenidos al programa del KARDEX DE INGENIERÍA BIOMÉDICA \n");
                Class1.Datos();
                Console.WriteLine("Los servicios que ofrecemos son: \n");
                int servicio;
                Console.WriteLine("1. Clases según el semestre que cursas");
                Console.WriteLine("2. Calificaciones finales");
                Console.WriteLine("3. Especialidades de la carrera de ingenieria biomedica");
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
                        return;
                }
            }

        }
    }

