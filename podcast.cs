class Podcast
{

    private List<episodio> episodios = new();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get;  }
    public int TotalEpisodios => episodios.Count;

    public void adicionarEpisodio(episodio Episodio)
    {
        episodios.Add(Episodio);
    }

    public void exibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome} aprensentadp por {Host}\n");
        foreach (var episodio in episodios)
        {
            Console.WriteLine(episodio.resumo);
        }
        Console.WriteLine($"Este podcast possui {TotalEpisodios} epsodios");
    }
}