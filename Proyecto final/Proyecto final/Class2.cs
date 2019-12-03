using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    class Class2
    {
        public static void Semestre()
        {
            int sem;
            Console.WriteLine("Para saber las materias correspondientes, ingresar el semestre que cursa:");
            sem = int.Parse(Console.ReadLine());
            switch (sem)
            {
                case 1:
                    Console.WriteLine("Semestre 1");
                    Console.WriteLine("Materias:");
                    Console.WriteLine("Cálculo diferencial");
                    Console.WriteLine("Taller de etica");
                    Console.WriteLine("Química inorgánica");
                    Console.WriteLine("Fundamentos de programación");
                    Console.WriteLine("Introducción a la ingeniería biomédica");
                    Console.WriteLine("Fundamentos de investigacion I");
                    break;
                case 2:
                    Console.WriteLine("Semestre 2");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Calculo integral");
                    Console.WriteLine("Mecánica clásica");
                    Console.WriteLine("Fundamentos de química orgánica");
                    Console.WriteLine("Programación orientada a objetos");
                    Console.WriteLine("Gestión de costos");
                    Console.WriteLine("Desarrollo sustentable");

                    break;
                case 3:
                    Console.WriteLine("Semestre 3");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Calculo vectorial");
                    Console.WriteLine("Electromagnetismo");
                    Console.WriteLine("Bioquímica");
                    Console.WriteLine("Algebra lineal");
                    Console.WriteLine("Mediciones eléctricas");
                    Console.WriteLine("Anatomia y fisiologia I");

                    break;
                case 4:
                    Console.WriteLine("Semestre 4");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Ecuaciones diferenciales");
                    Console.WriteLine("Probabilidad y estadística");
                    Console.WriteLine("Fenómenos de transporte en biosistemas");
                    Console.WriteLine("Óptica y ondas");
                    Console.WriteLine("Circuitos y máquinas eléctricas");
                    Console.WriteLine("Anatomia y fisiologia II");
                    break;
                case 5:
                    Console.WriteLine("Semestre 5");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Métodos numéricos");
                    Console.WriteLine("Desarrollo sustentable");
                    Console.WriteLine("Tecnologías de base de datos");
                    Console.WriteLine("Electronica analogica");
                    Console.WriteLine("Electrónica digital");
                    Console.WriteLine("Física médica");
                    break;
                case 6:
                    Console.WriteLine("Semestre 6");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Sensores y actuadores");
                    Console.WriteLine("Sistemas de cómputo y redes");
                    Console.WriteLine("Propiedades de los materiales");
                    Console.WriteLine("Amplificadores de bioseñales");
                    Console.WriteLine("Microcontroladores");
                    Console.WriteLine("Instrumentación virtual");
                    break;
                case 7:
                    Console.WriteLine("Semestre 7");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Instrumentación biomédica");
                    Console.WriteLine("Señales y sistemas");
                    Console.WriteLine("Biomateriales");
                    Console.WriteLine("Taller de investigación I");
                    Console.WriteLine("Modelado de sistemas fisiológicos");
                    break;
                case 8:
                    Console.WriteLine("Semestre 8");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Seguridad e higiene en el sector salud");
                    Console.WriteLine("Procesamiento digital de señales");
                    Console.WriteLine("Taller de investigación II");
                    break;
                case 9:
                    Console.WriteLine("Semestre 9");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Proyecto de ingeniería biomédica");
                    Console.WriteLine("Servicio social 10 créditos");
                    Console.WriteLine("Actividades complementarias 5 créditos");
                    Console.WriteLine("Especialidad 10 créditos");
                    break;
                case 10:
                    Console.WriteLine("Residencia profesional 10 créditos");
                    break;
                default:
                    Console.WriteLine("Excediste el número de semestres");
                    break;
            }
            Console.ReadKey();
        }

    }
}
