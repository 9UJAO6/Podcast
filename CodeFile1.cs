episodio ep1 = new(45, 1, "cração de scripts em C#");
ep1.AdicionarConvidados("João");
ep1.AdicionarConvidados("maria");
Console.WriteLine(ep1.resumo);

episodio ep2 = new(60, 2, "cração de scripts em C# 2");
ep2.AdicionarConvidados("João");
ep2.AdicionarConvidados("maria");
Console.WriteLine(ep2.resumo);

Podcast podcast = new("podcast  de c#", "Jurandir");
podcast.adicionarEpisodio(ep1);
podcast.adicionarEpisodio(ep2);
podcast.exibirDetalhes();