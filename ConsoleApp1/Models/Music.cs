using System.Text.Json.Serialization;

internal class Music
{
    [JsonPropertyName("song")]
    public string? Name { get; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("duration_ms")]
    public string? Duration { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    public void ShowDetailsSong()
    {
        Console.WriteLine($"{Name}");
        Console.WriteLine($"{Artist}");
        Console.WriteLine($"{Duration}");
        Console.WriteLine($"{Genre}");
    }
}