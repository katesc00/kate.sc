using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    class Class5
    {
        public static void reprobado()
        {

            int F = 0, C = 0, N = 0, MI = 0, FI = 0; string linea;
            Console.Write("Tamaño de la matriz para saber si estas aprobado o reprobado:");
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
                MAT[F, 1] = "R";
                MAT[MI, F] = "R";
                MAT[1, F] = "R";
            }
            FI = MI;
            for (F = 1; F <= MI; F++)
            {
                MAT[F, N] = "R";
                MAT[FI, FI] = "R";
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
            Console.Write("\n R de reprobado");
            Console.ReadKey();
        }



        public static void aprobado()
        {
            int F = 0; int C = 0; int N = 0; int MI = 0; string linea;
            Console.WriteLine("Tamaño de la matriz para saber si estas aprobado o reprobado:");
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
                MAT[F, N] = "A";
                MAT[MI, F] = "A";
                MAT[1, F] = "A";
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
            Console.Write("\n A de aprobado");
            Console.ReadLine();
        }

    }
}
