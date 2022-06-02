using System.Globalization;

namespace Mentoria_.NET.Exercicio_2
{
    public class Vendedor : Funcionario
    {
        public double comissao { get; set; }
        public long numVendas { get; set; }

        public Vendedor(string nome, long cpf, double comissao, long numVendas) : base(nome, cpf)
        {
            this.comissao = comissao;
            this.numVendas = numVendas;
        }

        public override double calculaSalario()
        {
            return salMinimo + (comissao*numVendas);
        }

        public override string ToString()
        {
            return "Nome: " + this.nome + "\n"
                + "CPF: " + this.cpf + "\n" +
                "Comissão: " + this.comissao + "\n"
                + "Número de vendas: " + this.numVendas 
                + "\n" + "Salário: " + calculaSalario();
        }

    }
}