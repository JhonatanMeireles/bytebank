using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    public class Usuario
    {
        public string nome;

        public int idade;

        public string documento;

        public Endereco endereco;

        
        public void SetUsuario(string name, int age, string document, string street, int number, string city, string district)
        {
            if(this.endereco == null)
            {
                endereco = new Endereco();
            }
            this.nome = name;
            this.idade = age;
            this.documento = document;
            this.endereco.rua = street;
            this.endereco.numero = number;
            this.endereco.cidade = city;
            this.endereco.bairro = district;

            Console.WriteLine(nome);

        }
    }
}
