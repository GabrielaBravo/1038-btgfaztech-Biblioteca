using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSistema
{
    internal class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public bool ItemDisponivel { get; set; } = true;
        public int TempoEmprestimo { get; private set; } = 14;
        public DateTime DataEmprestimo { get; private set; }
        public Livro(string titulo, string autor, DateTime dataPublicacao, int numeroPaginas, bool ItemDisponivel) : base(titulo, autor, dataPublicacao, numeroPaginas)
        {
        }

        public void EmprestimoItem()
        {
            if (ItemDisponivel)
            {
                ItemDisponivel = false;
                DataEmprestimo = DateTime.Now;
                Console.WriteLine($"Emprétimo do livro '{Titulo}' realizado!");
                DateTime dataLimiteDevolucao = DataEmprestimo.AddDays(TempoEmprestimo);
                Console.WriteLine($"Data limite de devolução: {dataLimiteDevolucao.ToShortDateString()}");
            }

            else
            {

                Console.WriteLine($"O livro '{Titulo}' já está emprestado.");

            }
        }

        public void DevolucaoItem()
        {
            if (!ItemDisponivel)
            {
                ItemDisponivel = true;
                Console.WriteLine($"Livro '{Titulo}' devolvido com sucesso!");
                DateTime dataDevolucao = DateTime.Now;
                TimeSpan atraso = dataDevolucao - DataEmprestimo;
                if (atraso.TotalDays > 0)
                {
                    double multa = atraso.TotalDays * 1;
                    Console.WriteLine($"Multa por atraso: R$ {multa:F2}");
                }
            }
            else
            {
                Console.WriteLine($"O livro '{Titulo}' não estava emprestado.");
            }
        }

    }
}
