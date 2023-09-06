using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSistema
{
    internal class MidiaDigital : ItemBiblioteca
    {

        public MidiaDigital(string titulo, string autor, DateTime dataPublicacao, int numeroPaginas) : base(titulo, autor, dataPublicacao, numeroPaginas)
        {
        }

        public void EmprestimoItem()
        {
            Console.WriteLine($"A Midia '{Titulo}' já se encontra disponível na sua biblioteca digital!");

        }


    }
}
