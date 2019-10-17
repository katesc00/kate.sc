using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kate
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a;
            decimal b;
            decimal c;
            Console.WriteLine("escribir un numero decimal");
            a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("escrbir numero decimal mayor que el primero");
            b = decimal.Parse(Console.ReadLine());

            if (b > a)
            {
                Console.WriteLine("escribe otro decimal");
                c = decimal.Parse(Console.ReadLine());
            }
            else if (b < a)
            {
                Console.WriteLine("el decimal no es mayor");
                Console.ReadLine();

            }
            Console.ReadKey();
        }
    }
}
