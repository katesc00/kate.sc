using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class4
    {
        public static void Especialidades()

        {
            Console.Clear();
            int n;
            Console.WriteLine("La especialidades se toman a partir del 6to semestre de la carrera \n");
            Console.WriteLine("las especialidades disponibles para la carrera de Ing. Biomédica son las siguientes: \n");
            Console.WriteLine("1. Biomecanica ");
            Console.WriteLine("2. Ingeniería Clinica");
            Console.WriteLine("3. Ingeniería para rehabilitación");
            Console.WriteLine("4. Sistemas Fisiológicos");
            Console.WriteLine("5. Investigación de biomateriales");
            Console.WriteLine("6. Bioinstrumentación \n");
            Console.WriteLine("Si deseas conocer un poco mas sobre cada especialidad selecciona la opcion que desees");

            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Biomecánica \n");
                    Console.WriteLine("Esta especialidad se encarga de estudiar la mecánica, tanto de los cuerpos humanos y animales,");
                    Console.WriteLine("como otras dinámicas como la termodinámica");
                    Console.WriteLine("Esto con el objetivo de encontrar soluciones a problemas médicos y biológicos");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingeniería Clinica \n");
                    Console.WriteLine("Usan la tecnología y los desarrollos técnicos para mejorar los procesos de");
                    Console.WriteLine("prestación de servicios médicos básicos y avanzados.");
                    Console.ReadKey();

                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Ingenieria para rehabilitación \n");
                    Console.WriteLine("Combina la ingeniería y la informática para desarrollar aplicaciones y");
                    Console.WriteLine("dispositivos que ayuden a personas con discapacidades cognitivas, sensoriales");
                    Console.WriteLine("o motoras.");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Sistemas Fisiológicos \n");
                    Console.WriteLine("Estudian el funcionamiento interno de los seres vivos, su campo de estudio");
                    Console.WriteLine("va desde los sistemas humanos más complejos, hasta el funcionamiento");
                    Console.WriteLine(" interno de los virus y bacterias.");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Investigacion de biomateriales \n");
                    Console.WriteLine("Investigación de materiales existentes o creación de nuevos materiales");
                    Console.WriteLine("en el laboratorio para su utilización en dispositivos médicos,");
                    Console.WriteLine("prótesis, injertos, trasplantes o creación de órganos.");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Bioinstrumentación \n");
                    Console.WriteLine("Combina los sistemas de información, la electrónica y datos de ");
                    Console.WriteLine("medición para crear herramientas o dispositivos para el");
                    Console.WriteLine("tratamiento o diagnóstico de enfermedades.");
                    Console.ReadKey();
                    break;


                default:
                    Console.WriteLine("Esta opción no es valida");
                    break;

            }
        }
    }
}
