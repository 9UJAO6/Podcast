class episodio
{
    private List <string> convidados = new ();

    public void AdicionarConvidados (string convidado)
    {
        convidados.Add(convidado);
    }

    private List<Podcast> Episodios = new List<Podcast>();

    public episodio(int duração, int ordem, string titulo)
    {
        this.duração = duração;
        this.ordem = ordem;
        this.titulo = titulo;
    }

    public int duração { get; }
    public int ordem { get; }
    public string titulo { get; }
    public string resumo => $"{ordem}. {titulo}. ({duração} min) - {string.Join(", ", convidados)} ";


    public void AdicionarEpisodios(Podcast episodios)
    {
        Episodios.Add(episodios);
    }
}