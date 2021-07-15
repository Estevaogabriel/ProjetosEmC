using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a classe
            Funcionario Funcionario;
            Funcionario = new Funcionario();

            //Variaveis uteis
            double aumentarsalario;

            Console.WriteLine("Ficha de Cadastro 2021");
            Console.Write("Nome: ");
            Funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            Funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            Funcionario.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("Funcionario: " + Funcionario.Nome + ", R$ " + Funcionario.SalarioLiquido());
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            aumentarsalario = double.Parse(Console.ReadLine());
            Funcionario.AumentarSalario(aumentarsalario);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine("Funcionario: " + Funcionario.Nome + ", R$ " + Funcionario.SalarioLiquido());


        }
    }
}
