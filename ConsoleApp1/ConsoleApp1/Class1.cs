using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public static void Datos()
        {
            int m;
            string n;
            Console.WriteLine("Escribe tu nombre completo: (Apellido materno / apellido paterno / nombres");
            n = Console.ReadLine();
            Console.WriteLine("Escribe tu matrícula");
            m = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
