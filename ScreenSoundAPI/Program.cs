using System.Text.Json;
using ScreenSoundAPI.Modelos;
using ScreenSoundAPI.Filtros; 

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musicas>>(resposta)!;
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "rock");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Houve um problema: {ex.Message}");

    }
}
