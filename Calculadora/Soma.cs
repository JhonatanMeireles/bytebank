using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Soma
    {
        List<int> numeros = new List<int>();

         
        public void AdicionarNumeroSoma(int num) 
        {
            this.numeros.Add(num);
        }
        public void Somar() 
        {
            int number = 0;
            foreach (int i in numeros)
            {
                number += i;
            
            }
            Console.WriteLine(number);
        }

    }
}
