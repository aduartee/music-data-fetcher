using System.Net;

namespace System.Filter.Musics;
internal class FilterLinq
{
    public static void FilterAllGenres(List<Music> musics)
    {
        var allGenres = musics.Select(genres => genres.Genre).Distinct().ToList();
        foreach (var gender in allGenres)
        {
            Console.WriteLine(gender);
        }
    }

    public static void FilterArtistsByGenre(List<Music> musics, string genre)
    {
        var artistOrderGenre = musics.Where(music => music.Genre!.Contains(genre)).Select(music => music.Artist).Distinct().ToList();
        foreach (var artist in artistOrderGenre)
        {
            Console.WriteLine(artist);
        }
    }
}