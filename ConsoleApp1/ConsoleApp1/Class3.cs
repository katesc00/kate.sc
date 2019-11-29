using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        public static void Calificaciones()
        {
            Console.Clear();
            Console.WriteLine("Qué semestre cursas?");
            int sem;
            sem = int.Parse(Console.ReadLine());
            switch (sem)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Semestre 1");
                    Console.WriteLine("Materias:");
                    Console.WriteLine("Cálculo diferencial");
                    Console.WriteLine("Taller de etica");
                    Console.WriteLine("Química inorgánica");
                    Console.WriteLine("Fundamentos de programación");
                    Console.WriteLine("Introducción a la ingeniería biomédica");
                    Console.WriteLine("Fundamentos de investigacion I");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas según el orden presentado");
                    double calificación, suma = 0;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine("Escribe tu calificación");
                        calificación = int.Parse(Console.ReadLine());
                        suma = suma + calificación;
                    }
                    double promedio;
                    promedio = suma / 6;
                    Console.WriteLine("el promedio es :" + promedio);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Semestre 2");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Calculo integral");
                    Console.WriteLine("Mecánica clásica");
                    Console.WriteLine("Fundamentos de química orgánica");
                    Console.WriteLine("Programación orientada a objetos");
                    Console.WriteLine("Gestión de costos");
                    Console.WriteLine("Desarrollo sustentable");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas según el orden presentado");
                    double calificación1, suma1 = 0;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine("Escribe tu calificación");
                        calificación1 = int.Parse(Console.ReadLine());
                        suma1 = suma1 + calificación1;
                    }
                    double promedio1;
                    promedio1 = suma1 / 6;
                    Console.WriteLine("el promedio es :" + promedio1);

                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Semestre 3");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Calculo vectorial");
                    Console.WriteLine("Electromagnetismo");
                    Console.WriteLine("Bioquímica");
                    Console.WriteLine("Algebra lineal");
                    Console.WriteLine("Mediciones eléctricas");
                    Console.WriteLine("Anatomia y fisiologia I");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas según el orden presentado");
                    double calificación2, suma2 = 0;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine("Escribe tu calificación");
                        calificación2 = int.Parse(Console.ReadLine());
                        suma = suma2 + calificación2;
                    }
                    double promedio2;
                    promedio2 = suma2 / 6;
                    Console.WriteLine("el promedio es :" + promedio2);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Semestre 4");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Ecuaciones diferenciales");
                    Console.WriteLine("Probabilidad y estadística");
                    Console.WriteLine("Fenómenos de transporte en biosistemas");
                    Console.WriteLine("Óptica y ondas");
                    Console.WriteLine("Circuitos y máquinas eléctricas");
                    Console.WriteLine("Anatomia y fisiologia II");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas según el orden presentado");
                    double calificación3, suma3 = 0;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine("Escribe tu calificación");
                        calificación3 = int.Parse(Console.ReadLine());
                        suma3 = suma3 + calificación3;
                    }
                    double promedio3;
                    promedio3 = suma3 / 6;
                    Console.WriteLine("el promedio es :" + promedio3);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Semestre 5");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Métodos numéricos");
                    Console.WriteLine("Desarrollo sustentable");
                    Console.WriteLine("Tecnologías de base de datos");
                    Console.WriteLine("Electronica analogica");
                    Console.WriteLine("Electrónica digital");
                    Console.WriteLine("Física médica");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas según el orden presentado");
                    double calificación4, suma4 = 0;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine("Escribe tu calificación");
                        calificación4 = int.Parse(Console.ReadLine());
                        suma4 = suma4 + calificación4;
                    }
                    double promedio4;
                    promedio4 = suma4 / 6;
                    Console.WriteLine("el promedio es :" + promedio4);
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Semestre 6");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Sensores y actuadores");
                    Console.WriteLine("Sistemas de cómputo y redes");
                    Console.WriteLine("Propiedades de los materiales");
                    Console.WriteLine("Amplificadores de bioseñales");
                    Console.WriteLine("Microcontroladores");
                    Console.WriteLine("Instrumentación virtual");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas según el orden presentado");
                    double calificación5, suma5 = 0;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine("Escribe tu calificación");
                        calificación5 = int.Parse(Console.ReadLine());
                        suma5 = suma5 + calificación5;
                    }
                    double promedio5;
                    promedio5 = suma5 / 6;
                    Console.WriteLine("el promedio es :" + promedio5);
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Semestre 7");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Instrumentacion biomedica");
                    Console.WriteLine("Señales y sistemas");
                    Console.WriteLine("Biomateriales");
                    Console.WriteLine("Taller de investigación I");
                    Console.WriteLine("Modelado de sistemas fisiológicos");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas según el orden presentado");
                    double calificación6, suma6 = 0;
                    for (int i = 1; i < 5; i++)
                    {
                        Console.WriteLine("Escribe tu calificación");
                        calificación6 = int.Parse(Console.ReadLine());
                        suma6 = suma6 + calificación6;
                    }
                    double promedio6;
                    promedio6 = suma6 / 5;
                    Console.WriteLine("el promedio es :" + promedio6);
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Semestre 8");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Seguridad e higiene en el sector salud");
                    Console.WriteLine("Procesamiento digital de señales");
                    Console.WriteLine("Taller de investigación II");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas según el orden presentado");
                    double calificación7, suma7 = 0;
                    for (int i = 1; i < 3; i++)
                    {
                        Console.WriteLine("Escribe tu calificación");
                        calificación7 = int.Parse(Console.ReadLine());
                        suma7 = suma7 + calificación7;
                    }
                    double promedio7;
                    promedio7 = suma7 / 3;
                    Console.WriteLine("el promedio es :" + promedio7);
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Semestre 9");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Proyecto de ingeniería biomédica");
                    Console.WriteLine("Servicio social 10 créditos");
                    Console.WriteLine("Actividades complementarias 5 créditos");
                    Console.WriteLine("Especialidad 10 créditos");
                    Console.WriteLine("En este semestre solo hay una materia, pero se puede calcular el total de créditos");
                    double créditos, suma8 = 0;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine("Escribe tus créditos totales");
                        créditos = int.Parse(Console.ReadLine());
                        suma8 = suma8 + créditos;
                    }
                    double promedio8;
                    promedio8 = suma8 / 3;
                    Console.WriteLine("el promedio es :" + promedio8);
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("Residencia profesional 10 créditos");
                    Console.WriteLine("Total de créditos por la residencia");
                    break;
                default:
                    Console.WriteLine("El maximo son 10 semestres");
                    break;
            }
            Console.ReadKey();

        }
    }
}
