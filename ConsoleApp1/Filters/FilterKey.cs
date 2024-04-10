namespace System.Filter.Musics;

internal class FilterKey
{
    internal static void FilterMusicsByKey(List<Music> musics, string key)
    {
        var allMusicsByKey = musics.Where(music => music.KeyResult.Equals(key)).Select(music => music.Name).Distinct().ToList();
        
        foreach (var music in allMusicsByKey)
        {
            Console.WriteLine($"Musicas com a tonalidade {key}: {music}");
        }
    }
}