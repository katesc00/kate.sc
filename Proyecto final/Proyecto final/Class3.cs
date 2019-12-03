using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    class Class3
    {
        public static void Calificaciones()
        {
            Console.WriteLine("Escribir el semestre que cursa con numero (recordar que la carrera consta de solo 10 semestres)");
            int sem;
            sem = int.Parse(Console.ReadLine());
            switch (sem)
            {
                case 1:
                    Console.WriteLine("Semestre 1");
                    Console.WriteLine("Materias:");
                    Console.WriteLine("Cálculo diferencial");
                    Console.WriteLine("Taller de etica");
                    Console.WriteLine("Quimica inorganica");
                    Console.WriteLine("Fudamentos de programacion");
                    Console.WriteLine("Introduccion a la ingenieria biomedica");
                    Console.WriteLine("Fundamentos de investigacion I");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas segun el orden presentado");
                    double calificacion, suma = 0;
                    for (int i = 1; i < 7; i++)
                    {
                        Console.WriteLine("Escribe tu calificacion");
                        calificacion = int.Parse(Console.ReadLine());
                        suma = suma + calificacion;
                    }
                    double promedio;
                    promedio = suma / 6;
                    Console.WriteLine("El promedio es :" + promedio);
                    Console.ReadKey();
                    Console.Clear();
                    if (promedio < 7)
                    {
                        Class5.reprobado();
                    }
                    else if (promedio > 7)
                    {
                        Class5.aprobado();
                    }
                    break;
                case 2:
                    Console.WriteLine("Semestre 2");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Calculo integral");
                    Console.WriteLine("Mecanica clasica");
                    Console.WriteLine("Fundamentos de quimica organica");
                    Console.WriteLine("Programacion orientada a objetos");
                    Console.WriteLine("Gestion de costos");
                    Console.WriteLine("Desarrollo sustentable");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas segun el orden presentado");
                    double calificacion1, suma1 = 0;
                    for (int i = 1; i < 7; i++)
                    {
                        Console.WriteLine("Escribe tu calificacion");
                        calificacion1 = int.Parse(Console.ReadLine());
                        suma1 = suma1 + calificacion1;
                    }
                    double promedio1;
                    promedio1 = suma1 / 6;
                    Console.WriteLine("El promedio es :" + promedio1);
                    Console.ReadKey();
                    Console.Clear();
                    if (promedio1 < 7)
                    {
                        Class5.reprobado();
                        Console.ReadKey();
                    }


                    else if (promedio1 > 7)
                    {
                        Class5.aprobado();
                    }
                    break;
                case 3:
                    Console.WriteLine("Semestre 3");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Calculo vectorial");
                    Console.WriteLine("Electromagnetismo");
                    Console.WriteLine("Bioquimica");
                    Console.WriteLine("Algebra lineal");
                    Console.WriteLine("Mediciones electricas");
                    Console.WriteLine("Anatomia y fisiologia I");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas segun el orden presentado");
                    double calificacion2, suma2 = 0;
                    for (int i = 1; i < 7; i++)
                    {
                        Console.WriteLine("Escribe tu calificacion");
                        calificacion2 = int.Parse(Console.ReadLine());
                        suma = suma2 + calificacion2;
                    }
                    double promedio2;
                    promedio2 = suma2 / 6;
                    Console.WriteLine("El promedio es :" + promedio2);
                    Console.ReadKey();
                    Console.Clear();
                    if (promedio2 < 7)
                    {
                        Class5.reprobado();
                    }
                    else if (promedio2 > 7)
                    {
                        Class5.aprobado();
                    }
                    break;
                case 4:
                    Console.WriteLine("Semestre 4");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Ecuaciones diferenciales");
                    Console.WriteLine("Probabilidad y estadistica");
                    Console.WriteLine("Fenomenos de transporte en biosistemas");
                    Console.WriteLine("Oprica y ondas");
                    Console.WriteLine("Circuitos y maquinas electricas");
                    Console.WriteLine("Anatomia y fisiologia II");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas segun el orden presentado");
                    double calificacion3, suma3 = 0;
                    for (int i = 1; i < 7; i++)
                    {
                        Console.WriteLine("Escribe tu calificacion");
                        calificacion3 = int.Parse(Console.ReadLine());
                        suma3 = suma3 + calificacion3;
                    }
                    double promedio3;
                    promedio3 = suma3 / 6;
                    Console.WriteLine("El promedio es :" + promedio3);
                    Console.ReadKey();
                    Console.Clear();
                    if (promedio3 < 7)
                    {
                        Class5.reprobado();
                    }
                    else if (promedio3 > 7)
                    {
                        Class5.aprobado();
                    }
                    break;
                case 5:
                    Console.WriteLine("Semestre 5");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Metodos numericos");
                    Console.WriteLine("Desarrollo sustentable");
                    Console.WriteLine("Tecnologias de base de datos");
                    Console.WriteLine("Electronica analogica");
                    Console.WriteLine("Electronica digital");
                    Console.WriteLine("Fisica medica");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas segun el orden presentado");
                    double calificacion4, suma4 = 0;
                    for (int i = 1; i < 7; i++)
                    {
                        Console.WriteLine("Escribe tu calificacion");
                        calificacion4 = int.Parse(Console.ReadLine());
                        suma4 = suma4 + calificacion4;
                    }
                    double promedio4;
                    promedio4 = suma4 / 6;
                    Console.WriteLine("El promedio es :" + promedio4);
                    Console.ReadKey();
                    Console.Clear();
                    if (promedio4 < 7)
                    {
                        Class5.reprobado();
                    }
                    else if (promedio4 > 7)
                    {
                        Class5.aprobado();
                    }
                    break;
                case 6:
                    Console.WriteLine("Semestre 6");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Sensores y actuadores");
                    Console.WriteLine("Ssitemas de computo y redes");
                    Console.WriteLine("Propiedades de los materias");
                    Console.WriteLine("Amplificadores de bioseñales");
                    Console.WriteLine("Microcontroladores");
                    Console.WriteLine("Instrumentacion virtual");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas segun el orden presentado");
                    double calificacion5, suma5 = 0;
                    for (int i = 1; i < 7; i++)
                    {
                        Console.WriteLine("Escribe tu calificacion");
                        calificacion5 = int.Parse(Console.ReadLine());
                        suma5 = suma5 + calificacion5;
                    }
                    double promedio5;
                    promedio5 = suma5 / 6;
                    Console.WriteLine("El promedio es :" + promedio5);
                    Console.ReadKey();
                    Console.Clear();
                    if (promedio5 < 7)
                    {
                        Class5.reprobado();
                    }
                    else if (promedio5 > 7)
                    {
                        Class5.aprobado();
                    }
                    break;
                case 7:
                    Console.WriteLine("Semestre 7");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Intrumentacion biomedica");
                    Console.WriteLine("Señales y sistemas");
                    Console.WriteLine("Biomateriales");
                    Console.WriteLine("Taller de investigacion I");
                    Console.WriteLine("Modelado de sistemas fisiologicos");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas segun el orden presentado");
                    double calificacion6, suma6 = 0;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine("Escribe tu calificacion");
                        calificacion6 = int.Parse(Console.ReadLine());
                        suma6 = suma6 + calificacion6;
                    }
                    double promedio6;
                    promedio6 = suma6 / 5;
                    Console.WriteLine("El promedio es :" + promedio6);
                    Console.ReadKey();
                    Console.Clear();
                    if (promedio6 < 7)
                    {
                        Class5.reprobado();
                    }
                    else if (promedio6 > 7)
                    {
                        Class5.aprobado();
                    }
                    break;
                case 8:
                    Console.WriteLine("Semestre 8");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Seguridad e higiene en el sector salud");
                    Console.WriteLine("Procesamiento digital de señales");
                    Console.WriteLine("Taller de investigacion II");
                    Console.WriteLine("Para calcular tu promedio final, ingresa las calificaciones finales de tus materias cursadas segun el orden presentado");
                    double calificacion7, suma7 = 0;
                    for (int i = 1; i < 4; i++)
                    {
                        Console.WriteLine("Escribe tu calificacion");
                        calificacion7 = int.Parse(Console.ReadLine());
                        suma7 = suma7 + calificacion7;
                    }
                    double promedio7;
                    promedio7 = suma7 / 3;
                    Console.WriteLine("El promedio es :" + promedio7);
                    Console.ReadKey();
                    Console.Clear();
                    if (promedio7 < 7)
                    {
                        Class5.reprobado();
                    }
                    else if (promedio7 > 7)
                    {
                        Class5.aprobado();
                    }
                    break;
                case 9:
                    Console.WriteLine("Semestre 9");
                    Console.WriteLine("Materias: ");
                    Console.WriteLine("Proyecto de ingenieria biomedica");
                    Console.WriteLine("Servicio social 10 creditos");
                    Console.WriteLine("Actividades complementarias 5 creditos");
                    Console.WriteLine("Especialidad 10 creditos");
                    Console.WriteLine("En este semestre solo hay una materia, pero se puede calcular el total de creditos");
                    double creditos, suma8 = 0;
                    for (int i = 1; i < 7; i++)
                    {
                        Console.WriteLine("Escribe tu total de creditos");
                        creditos = int.Parse(Console.ReadLine());
                        suma8 = suma8 + creditos;
                    }
                    double promedio8;
                    promedio8 = suma8 / 3;
                    Console.WriteLine("El promedio es :" + promedio8);
                    Console.ReadKey();
                    Console.Clear();
                    if (promedio8 < 7)
                    {
                        Class5.reprobado();
                    }
                    else if (promedio8 > 7)
                    {
                        Class5.aprobado();
                    }
                    break;
                case 10:
                    Console.WriteLine("Residencia profesional 10 creditos");
                    Console.WriteLine("Total de creditos por la residencia");
                    Console.ReadKey();
                    break;
            }
        }

    }
}
