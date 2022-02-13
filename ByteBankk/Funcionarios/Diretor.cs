using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankk.Funcionarios
{
    public class Diretor : Funcionario // A classe Diretor herda as características da classe Funcionario
    {
        // Esse método override está sobrepondo o comportamento do método
        // de mesmo nome na classe Funcionario, que é do tipo virtual.
        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}
