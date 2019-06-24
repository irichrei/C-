using System;

namespace Calculadora
{
    class Program
    {
        static void Main()
        {
            double n1, n2, resultado;
            string opr, operador;

            Console.WriteLine("Digite o primeiro numero: ");
            opr = Console.ReadLine();
            n1 = float.Parse(opr);

            Console.WriteLine("Digite um operador + - x / : ");
            operador = Console.ReadLine();
            operador = operador.ToUpper();

            Console.WriteLine("Digite o segundo numero: ");
            opr = Console.ReadLine();
            n2 = float.Parse(opr);

            if (operador == "+")
            {
                resultado = n1 + n2;
                Console.WriteLine("Resultado : " + resultado);
            }

            else if (operador == "-")
            {
                resultado = n1 - n2;
                Console.WriteLine("Resultado : " + resultado);
            }

            else if (operador == "x")
            {
                resultado = n1 * n2;
                Console.WriteLine("Resultado : " + resultado);
            }

            else if (operador == "/")
            {
                resultado = n1 / n2;
                Console.WriteLine("Resultado : " + resultado);
            }

            else
            {
                Console.WriteLine("Operador digitado não foi identificado");
            }

            repetidor();
        }     
        
        static void repetidor()
        {
            string reiniciar;
            Console.WriteLine("Deseja Calcular novamente? Digite Y para sim e N para não: ");
            reiniciar = Console.ReadLine();
            reiniciar = reiniciar.ToUpper();

            if (reiniciar == "Y")
            {
                Main();
            }

            else if (reiniciar == "N")
            {
                Console.WriteLine("Obrigado! Até Breve =) ");
            }

            else
            {
                repetidor();
            }
        }
    }
}
