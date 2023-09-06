using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSistema
{
    public class ItemBiblioteca
    {

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int NumeroPaginas { get; set; }
        public bool EmprestimoDisponivel { get; internal set; }

        public ItemBiblioteca(string titulo, string autor, DateTime dataPublicacao, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            DataPublicacao = dataPublicacao;
            NumeroPaginas = numeroPaginas;
        }

    }
}
