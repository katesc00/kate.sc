using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class libro
    {
        private string título = "metodología de la POO";
        private string autor = "L.L Roman";
        private string editorial = "Alfaomega";
       
        public libro()
        {
            Console.WriteLine("titulo:" + título);
            Console.WriteLine("autor:" + autor);
            Console.WriteLine("aditorial" + editorial);


        }
        


    }
}
