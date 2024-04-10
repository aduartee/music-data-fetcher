using System.Text.Json;
using System.Filter.Musics;
using System.Linq.Expressions;

using (HttpClient client = new())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        // musics[10].ShowDetailsSong();
        FilterKey.FilterMusicsByKey(musics, "C#");
        // Console.WriteLine("teste");
        // FilterLinq.FilterAllGenres(musics);
        // LinqOrder.ShowListArtistsOrder(musics);
        // FilterLinq.FilterArtistsByGenre(musics,  "rock");
        // var favoriteMusic = new FavMusic("Arthur");
        // favoriteMusic.AddFavoriteMusics(musics[10]);
        // favoriteMusic.ShowFavoriteMusic();
    } 
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}