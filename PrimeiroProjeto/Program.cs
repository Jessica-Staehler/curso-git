using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void eMain(string[] args)
        {
            Pessoa pes1, pes2; //Diz que ele é do tipo triangulo (cria as variáveis com esse tipo)
            pes1 = new Pessoa();//instância a variável como sendo um triangulo ---> aqui é onde realmete cria ele
            pes2 = new Pessoa();

            Console.WriteLine("Entre com o Nome, Idade e Salário da Pessoa:");
            pes1.NOME = Console.ReadLine();
            pes1.IDADE = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pes1.SALARIO = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o Nome, Idade e Salário da Pessoa:");
            pes2.NOME = Console.ReadLine();
            pes2.IDADE = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pes2.SALARIO = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (pes1.IDADE > pes2.IDADE)
            {
                Console.WriteLine("A pessoa mais velha é: " + pes1.NOME);
            }
            else if (pes1.IDADE < pes2.IDADE)
            {
                Console.WriteLine("A pessoa mais velha é: " + pes2.NOME);
            }
            else
            {
                Console.WriteLine("As duas pessoas tem a mesma idade.");
            }

            decimal salariomedio = (pes1.SALARIO + pes2.SALARIO) / 2;

            Console.WriteLine();
            Console.WriteLine($"A média de salrios é de: {salariomedio}");


        }
    }
}
