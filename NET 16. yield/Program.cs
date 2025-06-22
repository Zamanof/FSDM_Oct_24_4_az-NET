// yield return, yield break

//var numbers = GetResults();
//numbers.MoveNext();
//Console.WriteLine(numbers.Current);
//numbers.MoveNext();
//Console.WriteLine(numbers.Current);
//numbers.MoveNext();
//Console.WriteLine(numbers.Current);
//numbers.MoveNext();
//Console.WriteLine(numbers.Current);
//numbers.MoveNext();
//Console.WriteLine(numbers.Current);
//numbers.MoveNext();
//Console.WriteLine(numbers.Current);

//while (numbers.MoveNext())
//{
//    Console.WriteLine(numbers.Current);
//}


//var results = GetValues();

//foreach (var item in results)
//{
//    Console.WriteLine(item);
//}


string str = "Elektrikleshdirebildikleimizdensinizmi";

foreach (var i in MyRange(5, str.Length, 3))
{
    Console.Write($"{str[i]} ");
}

IEnumerator<string> GetResults()
{
    yield return "One";
    yield return "Two";
    yield return "Three";
    yield return "Four";
    yield return "Five";
    yield return "Six";
}

IEnumerable<string> GetValues()
{
    List<string> strings = ["AB", "BC", "CD", "DF", "FG", "GH"];
    for (int i = 0; i < strings.Count; i++)
    {
        yield return strings[i].ToLower();
    }
}
/*
 range(5) - 0, 1, 2, 3, 4
 range(2, 5) - 2, 3, 4
 range(1, 5, 2) - 1, 3
 
 */
IEnumerable<int> MyRange(int start, int? end = null, int steps=1)
{
    if (start > end && steps > 0) yield break;
    if(end is null)
    {
        end = start;
        start = 0;
    }

    for (int i = start; i < end; i += steps)
    {
        yield return i;
    }
}
