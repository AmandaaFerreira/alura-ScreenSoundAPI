using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelos;

internal class Musicas
{
    [JsonPropertyName("Song")]
    public string? Nome { get; set; }
    [JsonPropertyName("Artist")]
    public string? Artista { get; set;}
    [JsonPropertyName("Duration_ms")]
    public int Duracao { get; set;}
    [JsonPropertyName("Genre")]
    public string? Genero { get; set;}

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica {Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Genero: {Genero}");
    }

}
