using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanciando a classe
            Retangulo retangulo;
            retangulo = new Retangulo();

            //Variáveis úteis
            char condicao = 's';

            //Lógica
            while (condicao != 'n')
            {
                Console.WriteLine("Entre com a largura e altura do Retângulo: ");
                Console.Write("Altura: ");
                retangulo.Altura = double.Parse(Console.ReadLine());
                Console.Write("Largura: ");
                retangulo.Largura = double.Parse(Console.ReadLine());
                Console.WriteLine("A área é " + retangulo.Area().ToString("F1"));
                Console.WriteLine("O Perímetro é " + retangulo.Perimetro().ToString("F1"));
                Console.WriteLine("A Diagonal é " + retangulo.Diagonal().ToString("F3"));
                Console.WriteLine("Deseja realizar outra operação? (s/n)");
                condicao = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
