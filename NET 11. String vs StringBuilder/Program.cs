using System.Text;
// string vs StringBuilder


//string word = "Salam";
//for (int i = 0; i < 100; i++)
//{
//    word += 'a';
//}
//Console.WriteLine(word);

//StringBuilder stringBuilder = new("Salam");
//Console.WriteLine(stringBuilder.Capacity);
//Console.WriteLine(stringBuilder.Length);
//Console.WriteLine();
//for (int i = 0; i < 100; i++)
//{
//    stringBuilder.Append('a');
//    Console.WriteLine(stringBuilder.Capacity);
//}
//Console.WriteLine(stringBuilder);
//var word2 = stringBuilder.ToString();
//Console.WriteLine(word2);


StringBuilder numbers = new();
int count = default;

for (int i = 0; i < 10000; i++)
{
    numbers.Append($"{i} ");
    if(count != numbers.Capacity) Console.WriteLine(numbers.Capacity);
    count = numbers.Capacity;
}
//Console.WriteLine(numbers);
