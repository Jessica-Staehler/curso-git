using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
    class Produto
    {
        private String _nome;
        public int Quantidade { get; private set; }
        public decimal Valor { get; private set; }

        //Para criar construtor sempre colocar logo depois de criar os campos
        public Produto()//Esse funciona como um padrão
        {
        }
        public Produto(string nome, int quantidade, decimal valor)
        {
            _nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }

        //Esse bloco é para alterar o Nome, não é possivel ver ou alterar sem passar por aqui.
        public string Nome
        {
            get { return _nome; }// define o que é feito quando é para ver o atributo
            set// define o que é feito quando está sendo alterado o atributo, toda vez que alterar o atributo ele faz o IF
            {
                if (value != null && value.Length > 1)//value é a variável que recebe por parâmetro, ele não pode usar a variável aqui então usa value
                {
                    _nome = value;
                }
            }
        }
        // FIM

        public decimal ValorTotalEmEstoque()
        {
            return Valor * Quantidade;
        }

        public void AdicionarQuatidade(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverQuatidade(int quantidade)
        {
            Quantidade -= quantidade;
        }
        
        public override string ToString()
        {
            return _nome 
                + ", $ " 
                + Valor.ToString("F2")
                + ", "
                + Quantidade
                + " uninades, Valor em Estoque $"
                + ValorTotalEmEstoque().ToString("F2")
                + ".";
        }
    }
}
