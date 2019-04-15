using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculo_do_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double massa, imc, altura;
            
            Console.WriteLine("Digita a massa:");
            massa = double.Parse(Console.ReadLine());
            Console.WriteLine("Digita a altura:");
            altura = double.Parse(Console.ReadLine());

            imc = massa / (altura * 2);
            if (imc < 17.0)
            {
                Console.WriteLine("Muito Abaixo do Peso: " + imc.ToString("f2", CultureInfo.InvariantCulture) + "IMC");
            }
            else if (imc == 17.0 && imc == 18.49)
            {
                Console.WriteLine("Abaixo do peso " + imc.ToString("f2", CultureInfo.InvariantCulture) + "IMC");
            }
            else if (imc >= 18.5 && imc <= 25.0)
            {
                Console.WriteLine("Parabéns esta no peso normal : " + imc.ToString("f2", CultureInfo.InvariantCulture) + "IMC");
            }
            else if (imc > 25 && imc <= 30.0)
            {
                Console.WriteLine("Acima do peso: " + imc.ToString("f2", CultureInfo.InvariantCulture) + "IMC");
            }
            else if (imc > 30.0 && imc <= 35.0)
            {
                Console.WriteLine("Você Esta na Obesidade 1: " + imc.ToString("f2", CultureInfo.InvariantCulture) + "IMC");
            }
            else if (imc > 35.0 && imc < 40.0)
            {
                Console.WriteLine("Você Esta na Obesidade 2 (severa): " + imc);
            }
            else
            {
                Console.WriteLine("Você Esta na Obesidade 3 (Mórbida): " + imc);

            }
          


               
               
            Console.ReadKey();







            



            
        }
    }
}
