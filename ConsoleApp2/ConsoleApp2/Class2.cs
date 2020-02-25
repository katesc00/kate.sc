using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class coche
    {
        private string color;
        private string marca;
        private string modelo;
        private int motor;
        bool acelerando;

        public coche()
        {
            Console.WriteLine("de qué color es el coche? ");
            color = Console.ReadLine();
            Console.WriteLine("Qué marca es el coche?");
            color = Console.ReadLine();
            Console.WriteLine("modelo:");
            modelo = Console.ReadLine();
            Console.WriteLine("´motor:");
            motor = int.Parse(Console.ReadLine());
        }
        public void acelerar()
        {
            acelerando = true;
        }
        public void frenar()
        {
            acelerando = false;
        }

    }



}
