using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBanck.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(double salario, string cpf) : base (salario, cpf)
        {
        }
        public override double GetBonificacao()
        {
            return Salario * 0.5 ;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
