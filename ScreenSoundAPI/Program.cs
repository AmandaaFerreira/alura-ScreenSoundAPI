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

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Houve um problema: {ex.Message}");

    }
}
