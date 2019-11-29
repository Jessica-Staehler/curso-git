using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class ProdMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! seja bem vindo!");
            int i = 1;
            while (i == 1)
            {
                Console.WriteLine("Qual programa você deseja executar? (1 SAIR) ");
                Console.WriteLine("Produto = 2   - Calculadora = 3  Novo = 4 ");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (i)
                {
                    case 1:
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                }

             }
        }
        static void Exercicio2()
        {
            //Produto p; //Diz que ele é do tipo triangulo (cria as variáveis com esse tipo)
            //p = new Produto();//instância a variável como sendo um triangulo ---> aqui é onde realmete cria ele

            Console.WriteLine("Bem Vindo ao Cadastro de Produto!");
            Console.Write("Informe o Nome:  ");
            //p.Nome = Console.ReadLine(); // assim era antes do construtor
            string nome = Console.ReadLine();
            Console.Write("Informe a Quantidade:  ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("Informe o Valor:  ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Produto p = new Produto(nome, quantidade, valor);//com o construtor

            Console.WriteLine("Produto: " + p);

            Console.Write("Informe a Quantidade para Adicionar:  ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarQuatidade(qtd);
            Console.WriteLine("Alteração do Produto: " + p);

            Console.Write("Informe a Quantidade para Remover:  ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverQuatidade(qtd);
            Console.WriteLine("Alteração do Produto: " + p);

            Console.Write("Informe novo nome:  ");
            nome = Console.ReadLine();
            p.Nome = nome; //pega a propriedade e não o atributo
            Console.WriteLine("Alteração do Produto: " + p.Nome);
        }
        static void Exercicio3()
        {
            Console.WriteLine(Calculadora.Pi.ToString("F2"));

            Console.WriteLine("Informe o Raio a ser calculado: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculadora.CalcularCircunferencia(raio).ToString("F2"));

            Console.WriteLine("Informe um dos lados do cubo a ser calculado: ");
            double lado = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculadora.CalcularVolume(lado).ToString("F2"));
        }
        static void Exercicio4()
        {
        }
    }
}
