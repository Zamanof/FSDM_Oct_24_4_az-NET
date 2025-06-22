using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

using var client = new WebClient();

var content = client.DownloadString("https://jsonplaceholder.typicode.com/posts");

//Console.WriteLine(content);

var posts = JsonSerializer.Deserialize<List<Post>>(content);

posts.ForEach(Console.WriteLine);


class Post
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Bashliq { get; set; }

    [JsonPropertyName("body")]
    public string Texy { get; set; }

    public override string ToString()
    {
        return $"""
            {UserId} - {Id}

            {Bashliq}
            {Texy}

            """;
    }
}

// primary constructor
// yield

//UML, S.O.L.I.D., design patterns(https://refactoring.guru/design-patterns)