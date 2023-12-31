﻿using ScreenSoundAPI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoundAPI.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musicas> musicas)
        {
            var artistasOdenados = musicas.OrderBy(musica => musica.Artista).Select (musica
                => musica.Artista).Distinct().ToList();
            Console.WriteLine("Lista de artistas ordenados");
            foreach (var artista in artistasOdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }
    }
}
