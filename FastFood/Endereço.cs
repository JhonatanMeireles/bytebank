using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    public class Endereco
    {
        public string rua;

        public int numero;

        public string bairro;

        public string cidade;

        public void ExibirEndereco()
        {
            Console.WriteLine($"Rua: {rua},{numero} - Bairro: {bairro}, {cidade}");
        }
    }
}
