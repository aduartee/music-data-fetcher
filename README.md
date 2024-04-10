# Summary 📄
- This project was created to apply my learning from the course offered by Alura.
- I utilized this endpoint which returns a JSON file containing music data: 
https://guilhermeonrails.github.io/api-csharp-songs/songs.json

### The JSON is structured as follows:
    {
        "artist": "The Chainsmokers",
        "song": "#SELFIE - Original Mix",
        "duration_ms": 183750,
        "explicit": "False",
        "year": "2014",
        "popularity": "0",
        "danceability": "0.789",
        "energy": "0.915",
        "key": 0,
        "loudness": "-3.263",
        "mode": "1",
        "speechiness": "0.248",
        "acousticness": "0.0135",
        "instrumentalness": "8.77e-06",
        "liveness": "0.0818",
        "valence": "0.66",
        "tempo": "127.955",
        "genre": "pop, Dance/Electronic"
    },

### In this project, you will find:
- Capturing JSON responses using C#'s JsonSerializer
- Assigning responses to properties in the Music class
- Functions for ordering JSON by: Key, Artist Name, Favorite Music, and Genre of Musics

### Explain
How catch data of endpoint using C#, in this project i used LINQ to make it.
1. Declare instace of method HttpClient
   ``` using (HttpClient client = new()) ```

2. Inside this instance, I used the method GetStringAsync. This function makes a GET request to the URL and waits for the response, which is returned as a string. When using await, the response is awaited, and the execution is only completed when the function returns a result.
``` string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json"); ```   

3. Deserialize and transform the received response into a List of my Music class
``` var musics = JsonSerializer.Deserialize<List<Music>>(response)!; ```

4. Afterward, you can call any method you want
``` Example: FilterKey.FilterMusicsByKey(musics, "C#"); ```

#### The class Music
```
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

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public List<string> Keys { get; } = new List<string> { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"};

    public string KeyResult
    {
        get
        {
            return Keys[Key];
        }
    }
```
- Using JsonPropertyName to attribute data from JSON to properties inside my class.

# Important ⭐️
- This project was created to learn how to capture JSON data using C# and model data into classes.
  
