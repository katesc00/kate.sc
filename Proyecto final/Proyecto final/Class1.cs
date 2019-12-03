using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    class Class1
    {
        public static void Datos()
        {
            int m;
            string n;
            Console.WriteLine("Escriba su nombre completo: (Apellido materno / apellido paterno / nombres");
            n = Console.ReadLine();
            Console.WriteLine("Escriba su matrícula");
            m = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(n);
            Console.WriteLine(m);
        }

    }
}
