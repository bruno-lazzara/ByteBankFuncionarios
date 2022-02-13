using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankk.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

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
