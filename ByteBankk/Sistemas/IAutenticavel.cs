using ByteBankk.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankk.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
