﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000) 
        {

        }

        public override double GetBonificacao()
        {

            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario = this.Salario + (this.Salario * 0.05);
        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;

        }
    }
}
