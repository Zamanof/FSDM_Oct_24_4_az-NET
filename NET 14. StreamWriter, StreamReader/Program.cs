// StreamWriter, StreamReader
using System.Text;
#region writer

//string txt = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tempor tempor dui, non fringilla purus ullamcorper vel.";
//FileStream fileStream = new("myFile.txt", FileMode.Create);
//StreamWriter streamWriter = new(fileStream, Encoding.Unicode);
//foreach (var symb in txt)
//{
//    streamWriter.Write($"{symb} ");
//}
//streamWriter.Close();
//fileStream.Close();
#endregion

#region reader
//FileStream fileStream = new("myFile.txt", FileMode.Open);
//StreamReader streamReader = new(fileStream, Encoding.Unicode);
//string line = streamReader.ReadToEnd();
//Console.WriteLine(line);
//streamReader.Close();
//fileStream.Close();
#endregion

#region reader with try finally
//FileStream fileStream = null;
//StreamReader streamReader = null;
//try
//{
//    fileStream = new("myFile.txt", FileMode.Open);
//    streamReader = new(fileStream, Encoding.Unicode);
//    string line = streamReader.ReadToEnd();
//    Console.WriteLine(line);
//}
//finally
//{
//    streamReader.Close();
//    fileStream.Close();
//}
#endregion

#region reader with using

using (FileStream fileStream = new("myFile.txt", FileMode.Open))
{
    using (StreamReader streamReader = new(fileStream, Encoding.Unicode))
    {
        string line = streamReader.ReadToEnd();
        Console.WriteLine(line);
    }
}

#endregion
