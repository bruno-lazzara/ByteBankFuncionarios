using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankk.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        // O modificador de acesso protected utilizado acima ^ permite que o setter desta característica
        // seja acessado também pelas classes derivadas da classe Funcionaio (como Diretor, ou outras
        // que podem ser criadas futuramente). Se o setter fosse private, apenas a classe base poderia executá-lo.

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

        // Esse método é do tipo virtual. Ou seja, ele é um método que pode ser
        // sobrescrito por outros, ele não existe de forma tão fixa, predominante,
        // dentro da classe. Um método em outra classe filha pode sobrescrever
        // esse método utilizando o termo "override".
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
