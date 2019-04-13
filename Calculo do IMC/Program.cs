using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_do_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double massa, imc, altura;
            

            
            



            Console.WriteLine("Digita a massa:");
            massa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digita a altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = massa / (altura * 2);
            if (imc >= 18.5) 
                Console.WriteLine("esta no peso ideal");
            else
            if (imc <= 25)
            
                Console.WriteLine("esta obeso");
            Console.ReadKey();








            



            
        }
    }
}
