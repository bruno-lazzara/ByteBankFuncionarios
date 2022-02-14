﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankk.Funcionarios
{
    public class Diretor : Funcionario // A classe Diretor herda as características da classe Funcionario
    {
        // O construtor da classe Diretor está chamando o construtor da classe base e passando para ela a string cpf.
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        // Esse método override está sobrepondo o comportamento do método
        // de mesmo nome na classe Funcionario, que é do tipo virtual.
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
