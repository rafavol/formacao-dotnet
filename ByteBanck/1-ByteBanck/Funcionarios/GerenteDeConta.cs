using ByteBanck.Sistemas;
using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBanck.Funcionarios
{
    public class GerenteDeConta : Funcionario, Autenticavel
    {
        public GerenteDeConta(double salario, string cpf) : base(salario, cpf)
        {

        }
        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
