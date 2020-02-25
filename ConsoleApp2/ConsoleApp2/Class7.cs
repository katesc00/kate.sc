using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class figuras
    {
        private string rectangulo;
        private string triangulo;
        private string circulo;
        public figuras()
        {
            Console.WriteLine("dimensiones del rectangulo:\n base = 6\n altura = 12");
            Console.WriteLine("dimensiones del triangulo:\n base = 5\n altura = 8");
            Console.WriteLine("dimensiones circulo:\n radio = 5.5 ");
        }
        public void area()
        {
            int aREC, aTRI;
            double aCIR;
            aREC = 6 * 12;
            aTRI = (5 * 8) / 2;
            aCIR = (3.1416 * 5.5 * 5.5);
            Console.WriteLine("Area del rectangulo" + aREC);
            Console.WriteLine("Area del triangulo" + aTRI);
            Console.WriteLine("area del circulo" + aCIR);
        }
        public void perimetro()
        {
            int pr, pt;
            double pc;
            pr = (6 * 2) + (12 * 2);
            pt = 5 * 3;
            pc = 3.1416 * 11;
            Console.WriteLine("perimetro del trieangulo:" + pr);
            Console.WriteLine("perimetro del triangulo" + pt);
            Console.WriteLine("perimetro del circulo" + pc);
        }

        
    }
}
