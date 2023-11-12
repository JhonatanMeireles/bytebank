using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico
{
    public class Pessoa
    {
        public string nome;

        public int idade;

        public double altura;

        public double peso;


        public void ExibirInfPessoa()
        {
            //this.nome = nome;
            Console.WriteLine($"Nome: {this.nome}, idade: {this.idade}, altura: {this.altura}, peso: {this.peso}");
        }
    }
}
