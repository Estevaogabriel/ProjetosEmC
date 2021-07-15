using System;

namespace AulaCriacaoDeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
            Pessoa a, b;//Instanciando a classe
            a = new Pessoa();//definindo A e B como tipo "Pessoa"
            b = new Pessoa();

            Console.WriteLine("Entre com o nome da 1º pessoa: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Entre com a idade da 1º pessoa: ");
            a.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome da 2º pessoa: ");
            b.nome = Console.ReadLine();
            Console.WriteLine("Entre com a idade da 2º pessoa: ");
            b.idade = int.Parse(Console.ReadLine());

            if (a.idade > b.idade)
            {
                Console.WriteLine("Pessoa {0} é a mais velha!", a.nome);
            }
            else
            {
                Console.WriteLine("Pessoa {0} é a mais velha!", b.nome);
            }
            */
            //Exercício 2
            Pessoa funcionarioaA, funcionarioB;
            funcionarioaA = new Pessoa();
            funcionarioB = new Pessoa();

            Console.WriteLine("Entre com o nome do 1º Funcionário!");
            funcionarioaA.nome = Console.ReadLine();
            Console.WriteLine("Entre com o salário do 1º Funcionário!");
            funcionarioaA.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome do 2º Funcionário!");
            funcionarioB.nome = Console.ReadLine();
            Console.WriteLine("Entre com o salário do 2º Funcionário!");
            funcionarioB.salario = double.Parse(Console.ReadLine());

            double media = (funcionarioaA.salario + funcionarioB.salario) / 2;
            Console.WriteLine("A média salarial é: " + media);
        }
    }
}
