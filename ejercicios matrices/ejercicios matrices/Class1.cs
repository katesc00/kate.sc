using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_matrices
{
    class EjerciciosMatrices 
    {
        /// <summary>
        /// en esta funcion el usuario ingresara los sueldos de 4 empleados durante tres meses y el programa sumara los 3 sueldos de cada uno 
        /// la imprimira y dira cual es el sueldo mayor
        /// </summary>
        public static void matriz1()
        {
            string[] empleados;
            int[,] sueldos;
            int[] sueldostotal;
            empleados = new String[4];
            sueldos = new int[4, 3];
            for (int f = 0; f < empleados.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado:");
                empleados[f] = Console.ReadLine();
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    Console.Write("Ingrese sueldo:");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[f, c] = int.Parse(linea);
                }

            }
            sueldostotal = new int[4];
            for (int f = 0; f < sueldos.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    suma = suma + sueldos[f, c];
                }
                sueldostotal[f] = suma;
            }
            Console.WriteLine("Total de sueldos pagados por empleado.");
            for (int f = 0; f < sueldostotal.Length; f++)
            {
                Console.WriteLine(empleados[f] + " - " + sueldostotal[f]);
            }
            int may = sueldostotal[0];
            string nom = empleados[0];
            for (int f = 0; f < sueldostotal.Length; f++)
            {
                if (sueldostotal[f] > may)
                {
                    may = sueldostotal[f];
                    nom = empleados[f];
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es " + nom + " que tiene un sueldo de " + may);
            Console.ReadKey();
        }
        /// <summary>
        /// numero mayor y menor de una matriz de NxN
        /// </summary>
        public static void matriz3()
        {
            int n, m;
            int mayor, menor;
            Console.WriteLine("INDIQUE EL NUMERO DE FILAS");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("INDIQUE EL NUMERO DE COLUMNAS");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    Console.WriteLine("INGRESA EL ELEMENTO[" + i + "," + j + "]");
                    a[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("Los elementos que conforman la matriz son:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("  ");
                for (int j = 0; j < m; j++)
                {
                    Console.Write("  " + a[i, j]);
                }
            }
            Console.WriteLine(" ");
            mayor = menor = a[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < menor)
                    {
                        menor = a[i, j];
                    }
                    else
                        if (a[i, j] > mayor)
                    {
                        mayor = a[i, j];
                    }
                }
            }
            Console.WriteLine("MAXIMO elemento de la Matriz:" + mayor);
            Console.WriteLine("MINIMO elemento de la Matriz:" + menor);
            Console.ReadLine();
            Console.ReadKey();
        }
        /// <summary>
        /// esta funcion imprime una letra R en una matriz de NxN
        /// </summary>
        public static void matriz2()
        {
            int F = 0;
            int C = 0;
            int N = 0;
            int MI = 0;
            int FI = 0;
            string linea;
            Console.Write("TAMAÑO DE LA MATRIZ IMPAR:");
            linea = Console.ReadLine();
            N = int.Parse(linea);
            N = (N % 2 == 0 ? N + 1 : N);
            string[,] MAT = new string[N + 1, N + 1];
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    MAT[F, C] = " ";
                }
            }
            MI = N / 2 + 1;
            for (F = 1; F <= N; F++)
            {
                MAT[F, 1] = "A";
                MAT[MI, F] = "A";
                MAT[1, F] = "A";
            }
            FI = MI;
            for (F = 1; F <= MI; F++)
            {
                MAT[F, N] = "A";
                MAT[FI, FI] = "A";
                FI = FI + 1;
            }
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    Console.SetCursorPosition(C, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
        /// <summary>
        /// ordenamiento de una matriz de NxN
        /// </summary>
        public static void matriz4()
        {
            int F = 0;
            int C = 0;
            int I = 0;
            int K = 0;
            int N = 0;
            int AUX = 0;
            string cadena;
            Console.Write("TAMAÑO DE LA MATRIZ: ");
            cadena = Console.ReadLine();
            Random rnd = new Random();
            N = int.Parse(cadena);
            int[,] MAT = new int[N + 1, N + 1];
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    MAT[F, C] = rnd.Next(0, 100);
                    Console.SetCursorPosition(C * 4, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    for (I = 1; I <= N; I++)
                    {
                        for (K = 1; K <= N; K++)
                        {
                            if ((MAT[F, C] < MAT[I, K]))
                            {
                                AUX = MAT[F, C];
                                MAT[F, C] = MAT[I, K];
                                MAT[I, K] = AUX;
                            }
                        }
                    }
                }
            }
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    Console.SetCursorPosition(C * 4, F + 10);
                    Console.Write(MAT[F, C]);
                }
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
        /// <summary>
        /// menores de cada columna de una matriz de NxN
        /// </summary>
        public static void matriz5()
        {
            int F = 0;
            int C = 0;
            int N = 0;
            int MEN = 0;
            string cadena;
            Console.Write("TAMAÑO DE LA MATRIZ: ");
            cadena = Console.ReadLine();
            N = int.Parse(cadena);
            int[,] MAT = new int[100, 100];
            int[] VEC = new int[N + 1];
            Random rnd = new Random();
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    MAT[F, C] = rnd.Next(0, 100);
                    Console.SetCursorPosition(C * 4, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }
            for (C = 1; C <= N; C++)
            {
                MEN = MAT[1, C];
                for (F = 1; F <= N; F++)
                {
                    if ((MAT[F, C] < MEN))
                        MEN = MAT[F, C];
                }
                VEC[C] = MEN;
            }
            for (C = 1; C <= N; C++)
            {
                Console.SetCursorPosition(C * 4, 15);
                Console.Write(VEC[C]);
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
        /// <summary>
        /// mayores de cada fila de una matriz de NxN
        /// </summary>
        public static void matriz6()
        {
            int F = 0;
            int C = 0;
            int N = 0;
            int MAY = 0;
            string cadena;
            Console.Write("TAMAÑO DE LA MATRIZ: ");
            cadena = Console.ReadLine();
            N = int.Parse(cadena);
            int[,] MAT = new int[100, 100];
            int[] VEC = new int[N + 1];
            Random rnd = new Random();
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    MAT[F, C] = rnd.Next(0, 100);
                    Console.SetCursorPosition(C * 4, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }
            for (F = 1; F <= N; F++)
            {
                MAY = MAT[F, 1];
                for (C = 1; C <= N; C++)
                {
                    if (MAT[F, C] > MAY)
                        MAY = MAT[F, C];
                }
                VEC[F] = MAY;
            }
            for (F = 1; F <= N; F++)
            {
                Console.SetCursorPosition(50, F + 1);
                Console.Write(VEC[F]);
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();


        }
    }
}
