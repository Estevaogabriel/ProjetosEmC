using System;

namespace Exercicios_estruturas_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
            Console.WriteLine("Entre com um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero > 0)
            {
             Console.WriteLine("Não Negativo");
             }
            else{
             Console.WriteLine("Negativo");
            }*/
            //-------------------------------------------------------------
            //Exercício 2
            /*
            Console.WriteLine("Entre com um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Ímpar");
            }*/
            //-------------------------------------------------------------
            //Exercício 3
            /*
            Console.WriteLine("Entre com um número inteiro: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um número inteiro: ");
            int b = int.Parse(Console.ReadLine());
            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Múltiplos");
            }
            else
            {
                Console.WriteLine("Não São Múltiplos");
            }*/
            //-------------------------------------------------------------
            //Exercício 4
            /*
            Console.WriteLine("Entre com a hora inicial (24h): ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a hora de término (24h): ");
            int b = int.Parse(Console.ReadLine());
            if (a <b )
            {
                int tempodejogo = a - b;
                Console.WriteLine("O jogo durou: " + Math.Abs(tempodejogo) + " horas");
            }
            else
            {
                int tempodejogo = 24 - a + b;
                Console.WriteLine("O jogo durou: " + Math.Abs(tempodejogo) + " horas");

            }*/
            //-------------------------------------------------------------
            //Exercício 5
            /*
            Console.WriteLine("Código |   Classificação   | Preço ");
            Console.WriteLine("----------------------------------_");
            Console.WriteLine("  1    |   Cachoro Quente  | R$4.00");
            Console.WriteLine("  2    |     X Salada      | R$4.50");
            Console.WriteLine("  3    |      X Bacon      | R$5.00");
            Console.WriteLine("  4    |  Torrada Simples  | R$2.00");
            Console.WriteLine("  5    |    Refrigerante   | R$1.50");

            Console.WriteLine("Selecione o Código do item e, em seguida, a quantidade: ");
            string[] entradas = Console.ReadLine().Split(' ');
            int codigo = int.Parse(entradas[0]);
            int quantidade = int.Parse(entradas[1]);
            double saida;
            if (codigo == 1)
            {
                saida = 4 * quantidade;
                Console.WriteLine("Total: R$ " + saida);
            }
            else if (codigo == 2)
            {
                saida = 4.5 * quantidade;
                Console.WriteLine("Total: R$ " + saida);

            }
            else if (codigo == 3)
            {
                saida = 5 * quantidade;
                Console.WriteLine("Total: R$ " + saida);
            }
            else if (codigo == 4)
            {
                saida = 2 * quantidade;
                Console.WriteLine("Total: R$ " + saida);
            }
            else if (codigo == 5)
            {
                saida = 1.5 * quantidade;
                Console.WriteLine("Total: R$ " + saida);
            }*/
            //-------------------------------------------------------------
            //Exercício 6
            /*
            Console.WriteLine("Entre com um número de 0 - 100: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero > 0 && numero <= 25)
            {
                Console.WriteLine("Intervalo entre 0 e 25");

            }
            else if (numero > 25 && numero <= 50)
            {
                Console.WriteLine("Intervalo entre 25 e 50");

            }
            else if (numero > 50 && numero <= 75)
            {
                Console.WriteLine("Intervalo entre 50 e 75");

            }
            else if (numero > 75 && numero <= 100)
            {
                Console.WriteLine("Intervalo entre 75 e 100");

            }
            else
            {
                Console.WriteLine("O Valor está fora do intervalo proposto!");

            }*/
            //-------------------------------------------------------------
            //Exercício 7
            /*
            Console.WriteLine("Entre com a coordenada em X: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a coordenada em Y: ");
            double y = double.Parse(Console.ReadLine());

            if(x > 0 && y > 0)
            {
                Console.WriteLine("Seu objeto se encontra no Quadrante 1.");

            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Seu objeto se encontra no Quadrante 4.");

            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Seu objeto se encontra no Quadrante 2.");

            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Seu objeto se encontra no Quadrante 3.");

            }
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Seu objeto se encontra na Origem.");

            }
            */
            //-------------------------------------------------------------
            //Exercício 8
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("|             Renda                 | Imposto de Renda |");
            Console.WriteLine("|------------------------------------------------------|");
            Console.WriteLine("| de 0.00 a R$2000.00               |       Isento     |");
            Console.WriteLine("| de 2000.01 até R$3000.00          |          8%      |");
            Console.WriteLine("| de 3000.01 até R$4500.00          |         18%      |");
            Console.WriteLine("| Acima de R$4500.00                |         28%      |");
            Console.WriteLine("|______________________________________________________|");


            Console.WriteLine("Entre com o seu vencimento: ");
            double vencimento = double.Parse(Console.ReadLine());
            double imposto;

            if (vencimento > 0 && vencimento <= 2000)
            {
                Console.WriteLine("Isento do Imposto de Renda!");
            }
            else if (vencimento > 2000 && vencimento <= 3000)
            {
                imposto = ((vencimento - 2000) * 8 / 100);
                Console.WriteLine("O Valor de imposto pago será: R$" + imposto.ToString("F2"));
            }
            else if (vencimento > 3000 && vencimento <= 4500)
            {
                imposto = (vencimento * 18 / 100);
                Console.WriteLine("O Valor de imposto pago será: R$" + imposto.ToString("F2"));
            }
            else if (vencimento > 4500)
            {
                imposto = (vencimento * 28 / 100);
                Console.WriteLine("O Valor de imposto pago será: R$" + imposto.ToString("F2"));
            }
        }
    }
}

