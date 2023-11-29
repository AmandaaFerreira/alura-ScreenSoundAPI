using ScreenSoundAPI.Modelos;
using System.Linq;

namespace ScreenSoundAPI.Filtros;

internal class LinqFilter
{
    private static object musica;

    public static void FiltrarTodosOsGenerosMusicais(List <Musicas> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($" - {genero}");
        }


    }
    public static void FiltrarArtistaPorGeneroMusical(List <Musicas> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => 
        musica.Genero!.Contains(genero)).Select(musica =>musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por genero musical {genero}");
        foreach (var artist in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musicas> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.
        Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var MUSICA in musicasDoArtista)
        {
            Console.WriteLine($"- {musicas}");
        }


    }




}
