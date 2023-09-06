using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSistema
{
    internal class Biblioteca
    {

        private List<ItemBiblioteca> colecaobiblioteca = new();


        public Biblioteca(List<ItemBiblioteca> repositorio)
        {
            colecaobiblioteca = repositorio;
        }

        public Biblioteca()
        {
        }

        public void ListarItensPorTipo()
        {
            var livros = colecaobiblioteca.OfType<Livro>().ToList();
            var revistas = colecaobiblioteca.OfType<Revista>().ToList();
            var midiasDigitais = colecaobiblioteca.OfType<MidiaDigital>().ToList();

            Console.WriteLine("Livros:");
            foreach (var livro in livros)
            {
                Console.WriteLine($"- {livro.Titulo}");
            }

            Console.WriteLine("Revistas:");
            foreach (var revista in revistas)
            {
                Console.WriteLine($"- {revista.Titulo}");
            }

            Console.WriteLine("Mídias Digitais:");
            foreach (var midiaDigital in midiasDigitais)
            {
                Console.WriteLine($"- {midiaDigital.Titulo}");
            }
        }
        public void AdicionarItemColecao(ItemBiblioteca item)
        {
            if (item.Titulo == null)
            {
                throw new ArgumentNullException(nameof(item), "O item não pode ser nulo.");
            }

            // Verifique se o título não é nulo ou vazio
            if (string.IsNullOrWhiteSpace(item.Titulo))
            {
                throw new ArgumentException("O título do item não pode ser nulo ou vazio.");
            }

            // Verifique se o título já existe na coleção (ignorando maiúsculas/minúsculas)
            if (colecaobiblioteca.Any(i => i.Titulo != null && i.Titulo.Equals(item.Titulo, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"O título '{item.Titulo}' já existe na coleção da biblioteca.");
            }


            colecaobiblioteca.Add(item);

            if (item is Livro)
            {
                Console.WriteLine($"Livro '{item.Titulo}' adicionado à coleção.");
            }
            else if (item is Revista)
            {
                Console.WriteLine($"Revista '{item.Titulo}' adicionada à coleção.");
            }
            else if (item is MidiaDigital)
            {
                Console.WriteLine($"Mídia Digital '{item.Titulo}' adicionada à coleção.");
            }
            else
            {
                Console.WriteLine($"Item desconhecido '{item.Titulo}' adicionado à coleção.");
            }
        }

        public void RemoverItemColecao(ItemBiblioteca item)
        {
            colecaobiblioteca.Remove(item);
            Console.WriteLine($"Item removido: {item.Titulo}");
        }
    }
}
