using System.Text.Json;

internal class FavMusic
{
    public string? Name { get; set; }
    public List<Music>? ListFavoriteMusics { get; }

    public FavMusic(string name)
    {
        Name = name;
        ListFavoriteMusics = new();
    }

    public void AddFavoriteMusics(Music music)
    {
        ListFavoriteMusics!.Add(music);
    }

    public void ShowFavoriteMusic()
    {
        foreach (var music in ListFavoriteMusics!)
        {
            Console.WriteLine(music.Name);
        }
    }

    public void CreateFileJson()
    {
        Dictionary<string, object> data = new Dictionary<string, object>
        {
            {"name", Name},
            {"musics", ListFavoriteMusics}
        };


        string jsonInfo = JsonSerializer.Serialize(data);

        string fileName = $"favorite-music-{Name}.json";
        File.WriteAllText(fileName, jsonInfo);
        System.Console.WriteLine("Success! The JSON file has been created");
    }
}