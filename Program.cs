using System.Globalization;

namespace cadastroDeFuncionarios
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão cadastrados? ");
            int n = int.Parse(Console.ReadLine()!);

            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine()!);
                Console.Write("CPF: ");
                string cpf = Console.ReadLine()!;
                Console.Write("Nome: ");
                string nome = Console.ReadLine()!;
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(id, cpf, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Informe o CPF do funcionário que terá aumento salarial: ");
            string buscaCpf = Console.ReadLine()!;

            Funcionarios emp = list.Find(x => x.Cpf == buscaCpf)!;
            if (emp != null)
            {
                Console.Write("Digite a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                emp.AumentoSalarial(percentage);
            }
            else
            {
                Console.WriteLine("Este funcionário não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            foreach (Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}