using System.Globalization;

namespace cadastroDeFuncionarios
{
    public class Funcionarios
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionarios(int id, string cpf, string nome, double salario)
        {
            Id = id;
            Cpf = cpf;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalarial(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return $"Nº{Id}, CPF: {Cpf}, Nome: {Nome}, R$ {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}