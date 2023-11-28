using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string cpf, double salario) : base(cpf, salario) 
        {
            this.Salario = 4000;

        }

        public override double GetBonificacao()
        {

            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario = this.Salario + (this.Salario * 0.05);
        }
    }
}
