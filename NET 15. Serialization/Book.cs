// Serialization

public class Book
{
    public Guid Id;

    public Book()
    {
        Id = Guid.NewGuid();
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public Author Author { get; set; }

    public override string ToString()
    {
        return $"""
                    Id:{Id}
            
            Title:  {Title}
            Price:  {Price}
            Author: {Author}

            """;
    }

}

