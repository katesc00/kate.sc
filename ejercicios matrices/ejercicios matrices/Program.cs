using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("INGRESE UN NUMERO PARA ESCOGER LA FUNCION QUE DESEA EJECUTAR");
            Console.WriteLine("las opciones son");
            Console.WriteLine("1.sueldos totales de 4 empleados");
            Console.WriteLine("2.letra R en una matriz de NxN");
            Console.WriteLine("3.numeros mayor y menor de una matriz de NxN");
            Console.WriteLine("4.ordenamiento de una matriz de NxN");
            Console.WriteLine("5.menores de cada columna de una matriz NxN en un vector");
            Console.WriteLine("6.MAYORES DE CADA FILA DE UNA MATRIZ NxN EN UN VECTOR");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    EjerciciosMatrices.matriz1();
                    break;

                case 2:
                    EjerciciosMatrices.matriz2();
                    break;
                case 3:
                    EjerciciosMatrices.matriz3();
                    break;
                case 4:
                    EjerciciosMatrices.matriz4();
                    break;
                case 5:
                    EjerciciosMatrices.matriz5();
                    break;
                case 6:
                    EjerciciosMatrices.matriz6();
                    break;
                default:
                    Console.WriteLine("esta opcion no existe ingresa un numero del 1 al 6");
                    break;
            }
        }
    }
}
