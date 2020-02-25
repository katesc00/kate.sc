using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class biblioteca
    {
        private string libros;
        private string revista;
        private string nombre;

        public biblioteca()
        {
            Console.WriteLine("Los generos de libros son:\n novelas\n ciencia ficcion\n etc\n");
            Console.WriteLine("qué genero te interesa?");
            libros = Console.ReadLine();
            Console.WriteLine("tipos de revista:\n de divulgacio cientifica\n informativas\n especializadas\n");
            Console.WriteLine("que tipo de revista necesitas?");
            revista = Console.ReadLine();

        }
        public void prestamo()
        {
            Console.WriteLine("ingresa tu nombre completo");
            nombre = Console.ReadLine();
            Console.WriteLine("el cobro es de $20\n tines 10 días para devolverlo");

        }

    }
}

