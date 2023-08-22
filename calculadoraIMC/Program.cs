using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe seu peso em kg:");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("informe sua altura :");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\n imc =" + valorIMC + " voce esta abaixo do seu peso.");
            }
            else if (valorIMC >= 20 && valorIMC <= 30)
            {
                Console.WriteLine("\n imc =" + valorIMC + " voce esta acom peso ideal.");
            }
            else if (valorIMC > 30 && valorIMC <= 34)
            {
                Console.WriteLine("\n imc =" + valorIMC + " voce esta acima do seu peso.");
            }
            else
            {
                Console.WriteLine(" \n imc =" + valorIMC + " voce esta obeso.");
            }
            Console.ReadKey();
        }
    }
}
