using System.Text.Json.Serialization;
using System.Filter.Musics;

internal class Music
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("duration_ms")]
    public int? Duration { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    public void ShowDetailsSong()
    {
        Console.WriteLine($"{Name}");
        Console.WriteLine($"{Artist}");
        Console.WriteLine($"Duracao em segundos: {Duration / 1000}");
        Console.WriteLine($"{Genre}");
    }
}