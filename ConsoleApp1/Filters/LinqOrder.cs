namespace System.Filter.Musics;

internal class LinqOrder
{
    public static void ShowListArtistsOrder(List<Music> musics)
    {
        var allArtist = musics.OrderBy(music => music.Artist).Select(music => music.Artist).Distinct().ToList();
        foreach (var artist in allArtist)
        {
            Console.WriteLine(artist);
        }
    }
}