using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        private int tipo;//0-Funcionario 1-Diretor 2-Analista 

        public virtual double GetBonificacao()
        {

            return this.Salario * 0.1;
        }

        public virtual double GetPremioSemestral()
        {
            return this.Salario * 0.2;
        }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalDeFuncionarios++;

            //Console.WriteLine("Criando um funcionário.");
        }

        public virtual void AumentarSalario()
        {
            this.Salario = this.Salario + (this.Salario * 0.1); 
        }
    }
}
