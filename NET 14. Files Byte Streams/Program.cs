// FileStream, MemoryStream, BufferedStream -> Stream

/*
 Absolute path:
    - C:\Users\zamanov\source\repos\FSDM_Oct_24_4_az NET\NET 14. Files Byte Streams\bin\Debug\net8.0\text.txt
    - C:\Users\zamanov\source\repos\FSDM_Oct_24_4_az NET\NET 14. Files Byte Streams\bin\Debug\net8.0\Files\text.txt
    - C:\Users\zamanov\source\repos\FSDM_Oct_24_4_az NET\NET 14. Files Byte Streams\bin\Debug\text.txt
    - C:\Users\zamanov\source\repos\FSDM_Oct_24_4_az NET\NET 14. Files Byte Streams\bin\Debug\Files\text.txt

 Relative path:
    - text.txt
    - Files\text.txt
    - ..\text.txt
    - ..\Files\text.txt 
*/

using System.Text;

string filePath = "file.txt";
//Console.WriteLine("Metn daxil edin");
//string txt = Console.ReadLine();

//SaveToFile(filePath, txt);

Console.WriteLine(LoadFromFile(filePath));

void SaveToFile(string path, string text)
{
    FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None);
    byte[] bytes = Encoding.Default.GetBytes(text);
    fileStream.Write(bytes, 0, bytes.Length);
    fileStream.Close();
}

string LoadFromFile(string path)
{
    FileStream fileStream = new(path, FileMode.Open, FileAccess.Read, FileShare.Read);
    byte[] bytes = new byte[(int)fileStream.Length];
    fileStream.Read(bytes, 0, bytes.Length);
    fileStream.Close();
    return Encoding.Default.GetString(bytes);
}


