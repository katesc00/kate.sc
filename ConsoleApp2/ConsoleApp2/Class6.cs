using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class telefono
    {
        private string SistOp = "IOS 13";
        private string capacidad = "64 GB";
        private string pantalla = "6.1 pulgadas, true tone";
        private string resolucion = "1792 x 828 pixeles";
        private string camara = "12 MP";

        public telefono()
        {
            Console.WriteLine("iPhone 11");
            Console.WriteLine("Sistema operativo:" + SistOp);
            Console.WriteLine("capacidad:" + capacidad);
            Console.WriteLine("pantalla" + pantalla);
            Console.WriteLine("resolución" + resolucion);
            Console.WriteLine("camara" + camara);
          
        }
        public void llamar()
        {
            int numero;
            Console.WriteLine("ingresa el numero:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("llamando...");
        }
        public void textear()
        {
            int numero;
            Console.WriteLine("ingresa el numero:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa el mensaje:");
            string mensaje;
            mensaje = Console.ReadLine();
        }


    }
}
