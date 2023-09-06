using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSistema
{
    internal class Revista : ItemBiblioteca, IPodeSerEmprestado
    {

        public bool ItemDisponivel { get; set; }
        public int TempoEmprestimo { get; private set; } = 14;
        public DateTime DataEmprestimo { get; set; }
        public Revista(string titulo, string autor, DateTime dataPublicacao, int numeroPaginas, bool ItemDisponivel, DateTime DataEmprestimo) : base(titulo, autor, dataPublicacao, numeroPaginas)
        {
        }

        public void EmprestimoItem()
        {
            if (ItemDisponivel == true)
            {
                ItemDisponivel = false;
                Console.WriteLine($"Emprétimo da Revista '{Titulo}' realizada!");
                DateTime dataLimiteDevolucao = DataEmprestimo.AddDays(TempoEmprestimo);
                Console.WriteLine($"Data limite de devolução: {dataLimiteDevolucao.ToShortDateString()}");
            }

            else
            {

                Console.WriteLine($"A Revista '{Titulo}' já está emprestada.");

            }
        }

        public void DevolucaoItem(DateTime DataEmprestimo)
        {
            if (ItemDisponivel == false)
            {
                ItemDisponivel = true;
                Console.WriteLine($"Revista '{Titulo}' devolvida com sucesso!");
                DateTime dataDevolucao = DateTime.Now;
                int atraso = (dataDevolucao - DataEmprestimo).Days;
                if (atraso > 14)
                {
                    double multa = (atraso - 14) * 1;
                    Console.WriteLine($"Multa por atraso: R$ {multa:F2}");
                }
            }
            else
            {
                Console.WriteLine($"a Revista '{Titulo}' não estava emprestada.");
            }
        }

    }
}
