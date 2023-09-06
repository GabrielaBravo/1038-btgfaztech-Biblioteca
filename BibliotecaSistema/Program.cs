using BibliotecaSistema;

internal class Program
{
    private static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        Livro livro = new Livro("Clean Code", "Robert C. Martin", new DateTime(2023, 9, 5), 200, true);
        Revista revista = new Revista("Educação & Tecnologia", "Roger S. Pressman", new DateTime(2023, 10, 2), 30, false, new DateTime(2023, 07, 17));
        MidiaDigital midiaDigital = new MidiaDigital("Internet das Coisas Sem Mistérios", "Renata Rampim", new DateTime(2016, 9, 16), 106);

        biblioteca.AdicionarItemColecao(livro);
        biblioteca.AdicionarItemColecao(revista);
        biblioteca.AdicionarItemColecao(midiaDigital);

        Console.WriteLine("--------------------------------------------------------------------");

        livro.EmprestimoItem();
        livro.DevolucaoItem();

        Console.WriteLine("--------------------------------------------------------------------");

        revista.EmprestimoItem();
        revista.DevolucaoItem(new DateTime(2023, 8, 16));

        Console.WriteLine("--------------------------------------------------------------------");

        midiaDigital.EmprestimoItem();

        Console.ReadKey();
    }
}