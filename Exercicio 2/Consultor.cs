namespace Mentoria_.NET.Exercicio_2
{
    public class Consultor : Funcionario
    {
        public double valorHora { get; set; }
        public long horasTrabalhadas { get; set; }

        public Consultor(string nome, long cpf, double valorHora, long horasTrabalhadas) : base(nome, cpf)
        {
            this.valorHora = valorHora;
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public override double calculaSalario(){
            return (valorHora*horasTrabalhadas);
        }

        public override string ToString()
        {
            return "Nome: " + this.nome + "\n"
                + "CPF: " + this.cpf + "\n" +
                "Valor da Hora: " + this.valorHora + "\n"
                + "Horas trabalhadas: " + this.horasTrabalhadas 
                + "\n" + "Salário: " + calculaSalario();
        }
    }
}