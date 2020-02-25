using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ordenador
    {
        private double pantalla = 13.3;
        private string procesador = "Core i5 de doble nucleo";
        private int almacenamiento = 1;
        private int memoria = 16;

        public ordenador()
        {
            Console.WriteLine("MacBook Air");
            Console.WriteLine("Pantalla:" + pantalla + "pulgadas");
            Console.WriteLine("procesador:" + procesador );
            Console.WriteLine("alamcenamiento " + almacenamiento +"TB");
            Console.WriteLine("memoria" + memoria + "GB");
        }


  


        

    }
}
