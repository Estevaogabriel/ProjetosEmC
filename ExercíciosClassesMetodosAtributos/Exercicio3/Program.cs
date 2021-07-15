using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a Classe 
            Aluno Aluno;
            Aluno = new Aluno();

            //Variaveis uteis
            char opcao = 's';

            //Lógica
            while (opcao == 's')
            {
                Console.WriteLine("Calculador de Média com resultado!");
                Console.Write("Nome do Aluno: ");
                Aluno.Nome = Console.ReadLine();
                Console.Write("Nota 1º Unidade: ");
                Aluno.Nota1 = double.Parse(Console.ReadLine());
                Console.Write("Nota 2º Unidade: ");
                Aluno.Nota2 = double.Parse(Console.ReadLine());
                Console.Write("Nota 3º Unidade: ");
                Aluno.Nota3 = double.Parse(Console.ReadLine());
                if (Aluno.MediaFinal() >= 30)
                {
                    Console.WriteLine("Media final: " + Aluno.MediaFinal());
                    Console.WriteLine("APROVADO");
                    Console.WriteLine("Gostaria de Realizar Outra operação? (s/n)");
                    opcao = char.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Media final: " + Aluno.MediaFinal());
                    Console.WriteLine("REPROVADO");
                    Console.WriteLine("FALTARAM: " + (30 - Aluno.MediaFinal()));
                    Console.WriteLine("Gostaria de Realizar Outra operação? (s/n)");
                    opcao = char.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }
        }
    }
}