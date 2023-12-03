using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        
        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public override double GetPremioSemestral()
        {
            return this.Salario + base.GetPremioSemestral() ;
        }
        public Diretor(string cpf) : base (cpf, 5000)
        {
            
            //Console.WriteLine("Criando um diretor");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
