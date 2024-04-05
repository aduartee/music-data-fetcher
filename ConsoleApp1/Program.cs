using (HttpClient client = new())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(response);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}