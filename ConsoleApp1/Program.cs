using System.Text.Json;
using System.Filter.Musics;

using (HttpClient client = new())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        musics[0].ShowDetailsSong();
        FilterLinq.FilterAllGenres(musics);
        LinqOrder.ShowListArtistsOrder(musics);
        FilterLinq.FilterArtistsByGenre(musics, "rock");
    } 
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}