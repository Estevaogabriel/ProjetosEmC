using System;

namespace uri1067
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercício 1
            /*
            Console.WriteLine("Entre com  o valor de X: ");
            int x = int.Parse(Console.ReadLine());

            while (x <= 1 || x >= 1000)
            {
                Console.WriteLine("Valor Inválido!");
                Console.WriteLine("Entre com  o valor de X adequado: ");
                x = int.Parse(Console.ReadLine());

            }

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            //Exercício 2
            /*
            Console.WriteLine("Entre com um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            int contadorin = 0, contadorout = 0, i;
            int entrada;
                        for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre com um número inteiro: ");
                entrada = int.Parse(Console.ReadLine());
                if (entrada >= 10 && entrada <= 20)
                {
                    contadorin++;
                }
                else
                {
                    contadorout++;
                }
                        }
            Console.WriteLine("{0} in e {1} out", contadorin, contadorout);
            */

            //Exercício 4
            /*
            Console.WriteLine("Entre com um número N: ");
            double entrada = int.Parse(Console.ReadLine());
            double par1, par2, divisao;
            int i;

            for (i = 0; i < entrada; i++)
            {
                Console.WriteLine("Entre com os pares");
                par1 = double.Parse(Console.ReadLine());
                par2 = double.Parse(Console.ReadLine());
                if (par2 == 0)
                {
                    Console.WriteLine("Divisão impossível!");

                }
                divisao = par1 / par2;
                Console.WriteLine("O resultado da divisão é: " + divisao);

            }*/

            //Exercício 6
            /*
            Console.WriteLine("Entre com o valor N: ");
            int n = int.Parse(Console.ReadLine()), i;

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }

            }
            */

            //Exercício 7

            Console.WriteLine("Entre com o valor N: ");
            int n = int.Parse(Console.ReadLine()), i;

            for (i = 1; i < n+1; i++)
            {
                Console.WriteLine("{0} {1} {2}", i, Math.Pow(i,2), Math.Pow(i,3));
                
            }
        }
    }
}