using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char op;
            double resultado;

            Console.WriteLine("Coloque o Primeiro Numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coloque o Segundo Numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escolha a Operação (+, -, *, /): ");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Não se divide por zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Operação Invalida.");
                    break;
            }

            Console.ReadLine();
        }
    }
}