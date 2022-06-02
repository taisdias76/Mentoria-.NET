/*
Aplicar conceito de Herança criando uma classe mãe Funcionário com os atributos: 
{nome, cpf, cte salario minimo e método abstrato "calculaSalario"}
vendedores ganham 1 salário mínimo mais comissao por vendas
consultores ganham somente pelas horas que trabalharam
*/

namespace Mentoria_.NET.Exercicio_2
{
    public class Funcionario
    {
        public string nome { get; set; }
        public long cpf { get; set; }
        public double salMinimo = 1000.00;

        public Funcionario(string nome, long cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public virtual double calculaSalario()
        {
            return salMinimo;
        }

    }
}