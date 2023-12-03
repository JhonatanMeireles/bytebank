using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace desafioEditora.Livro
{
    public class Livro
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string ISBN { get; private set; }

        public int AnoPublicacao { get; set; }

        public string EstiloLiterario { get; set; }

        public int NumeroDePaginas { get; set; }

        public string Pais { get; set; }


        public Livro(string isbn)
        {
            this.ISBN = isbn;
        }
    }
}
