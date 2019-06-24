using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            string opr, operador;

            Console.WriteLine("Digite o primeiro numero: "); 
            opr = Console.ReadLine();
            n1 = float.Parse(opr);

            Console.WriteLine("Digite um operador + - x / : ");
            operador = Console.ReadLine();
   
            Console.WriteLine("Digite o segundo numero: ");
            opr = Console.ReadLine();
            n2 = float.Parse(opr);

            if (operador == "+")
            {
                Console.WriteLine("O valor da soma é: ", n1 + n2);
            }

            else if (operador == "-")
            {
                Console.WriteLine("O valor da soma é: ", n1 - n2);
            }

            else if (operador == "x")
            {
                Console.WriteLine("O valor da soma é: ", n1 * n2);
            }

            else if (operador == "/")
            {
                Console.WriteLine("O valor da soma é: ", n1 / n2);
            }

            else
            {
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
