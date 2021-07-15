using System;

namespace Caculadora_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número a ser operado: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o outro número a ser operado: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a operação que quer fazer: ");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("x");
            Console.WriteLine("/");
            char operacao = char.Parse(Console.ReadLine());

            if (operacao == '+') {
                Console.WriteLine("A Soma é: " + (a + b));
            }
            else if (operacao == '-')
            {
                Console.WriteLine("A Subtração é: " + (a - b));
            }
            else if (operacao == 'x')
            {
                Console.WriteLine("A Multiplicação é: " + (a * b));
            }
            else if (operacao == '/') {

                Console.WriteLine("A Razão é: " + (a / b));
            }
            else
            {
                Console.WriteLine("Operação Inválida");

            }

        }
    }
}