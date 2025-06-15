// Extension methods
string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur libero felis. Sed aliquam gravida massa, ac ultricies magna aliquet ac. In hac habitasse platea dictumst. Sed varius lectus dui, eu volutpat metus placerat mattis.";
Console.WriteLine(str.CountWords());
Console.WriteLine(str.CountSpaces());
Console.WriteLine("125".ToInt() + 54);
//Console.WriteLine(ReturnCountWords(str));

int ReturnCountWords(string word)
{
    var words = word.Split();
    return words.Length;
}


static class StringExtensions
{
    public static int CountWords(this string word)
    {
        if (string.IsNullOrEmpty(word)) return 0;
        return word.Split().Length;
    }
    public static int CountSpaces(this string word)
    {
        if (string.IsNullOrEmpty(word)) return 0;
        return word.Count(s=> s == ' ');
    }

    public static int ToInt(this string str)
    {
        return int.Parse(str);
    }
}
