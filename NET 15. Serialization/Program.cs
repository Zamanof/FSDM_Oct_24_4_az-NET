// Serialization

using System.Text.Json;
using System.Xml.Serialization;

Book book = new()
{
    Author = new Author("Nicholas", "Sparks"),
    Title = "The Notebook",
    Description = "he Notebook is the debut novel by American novelist Nicholas Sparks. Released in 1996, the romance novel was later adapted into a popular 2004 film of the same name.",
    Price = 12.67
};
List<Book> books = [
    book,
    new Book{
        Author = new Author("Antoine", "Saint-Exupery"),
        Title = "Le Petit Prince",
        Description = "Mohteshem",
        Price = 12569.25
    },
    new Book{
        Author = new Author("Joseph", "Albahari"),
        Title = "C# 13 in a Nutshell",
        Description = "Full guide for C# Language",
        Price = 0.25
    },
    new Book{
        Author = new Author("Sharl", "Pero"),
        Title = "Qirmizipapaq",
        Description = "Triller",
        Price = 1000.0
    },
    new Book{
        Author = new Author("Nigel", "Kavtern"),
        Title = "Tiranlar",
        Description = "Dunyani zebt etmek isteyen diktatorlar",
        Price = 0.25
    }];


#region XML Serialization
#region single object serialization
// single object serialization
//XmlSerializer serializer = new XmlSerializer(typeof(Book));
//using var file = new FileStream("book.xml", FileMode.OpenOrCreate);
////serializer.Serialize(file, book);

//var result = serializer.Deserialize(file) as Book;
//Console.WriteLine(result);
//Console.WriteLine(result.Description);
#endregion

#region list of objects
//XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
//using var file = new FileStream("books.xml", FileMode.OpenOrCreate);
////serializer.Serialize(file, books);

//var results = serializer.Deserialize(file) as List<Book>;
//results.ForEach(Console.WriteLine);
#endregion
#endregion

#region JSON Serializtion
#region single object
//using var file = new FileStream("book.json", FileMode.OpenOrCreate);
//JsonSerializerOptions options = new();
//options.WriteIndented = true;
//var json = JsonSerializer.Serialize(book, options);
//Console.WriteLine(json);

//JsonSerializer.Serialize(file, book, options);

//Console.WriteLine(JsonSerializer.Deserialize<Book>(file));
#endregion

#region list of objects
using var file = new FileStream("books.json", FileMode.OpenOrCreate);
JsonSerializerOptions options = new();
options.WriteIndented = true;
JsonSerializer.Serialize(file, books, options);
//var results = JsonSerializer.Deserialize<List<Book>>(file);
//results.ForEach(Console.WriteLine);

#endregion


#endregion