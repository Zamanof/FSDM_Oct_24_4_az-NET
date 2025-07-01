// Strategy

// Dependency Inversion Principle


#region Serialize example

//WorkToFile workToFile = new WorkToFile(new JsonSerialization());
//workToFile.Serialize();
//workToFile.Deserialize();
//workToFile.SetSerializer(new XMLSerialization());
//workToFile.Serialize();
//workToFile.Deserialize();
//workToFile.SetSerializer(new NiluferStyleSerialization());
//workToFile.Serialize();
//workToFile.Deserialize();

//interface ISerialize
//{
//    void Serialize();
//    void Deserialize();
//}
//class JsonSerialization: ISerialize
//{
//    public void Serialize() => Console.WriteLine("JSON Serialize");
//    public void Deserialize() => Console.WriteLine("JSON Deserialize");
//}
//class XMLSerialization: ISerialize
//{
//    public void Serialize() => Console.WriteLine("XML Serialize");
//    public void Deserialize() => Console.WriteLine("XML Deserialize");
//}

//class NiluferStyleSerialization : ISerialize
//{
//    public void Deserialize()
//    {
//        Console.WriteLine("Nilufer style supper optimized serialize");
//    }

//    public void Serialize()
//    {
//        Console.WriteLine("Nilufer style supper optimized deserialize");
//    }
//}
//class WorkToFile
//{
//    private ISerialize _serialization{get; set;}

//    public WorkToFile(ISerialize serialization)
//    {
//        _serialization = serialization;
//    }

//    public void SetSerializer(ISerialize serializer)=> _serialization = serializer; 
//    public void Serialize() => _serialization.Serialize();
//    public void Deserialize() => _serialization.Deserialize();


//}
#endregion

#region SortingExample
//List<int> ints = [34, -7, 89, 35, 13, -200, 45, 12];
////ints.Sort();
////ints.ForEach(i => Console.Write($"{i} "));
////Console.WriteLine();

//Sorting<int> sorting = new(new DefaultSorting());
//var lst = sorting.Sort(ints);
//lst.ForEach(i => Console.Write($"{i} "));

//interface ISorting<T>
//{
//    List<T> Sort(List<T> collection);
//}

//class BubbleSort : ISorting<int>
//{
//    public List<int> Sort(List<int> collection)
//    {
//        var n = collection.Count;
//        for (int i = 0; i < n - 1; i++)
//            for (int j = 0; j < n - i - 1; j++)
//                if (collection[j] > collection[j + 1])
//                {
//                    var tempVar = collection[j];
//                    collection[j] = collection[j + 1];
//                    collection[j + 1] = tempVar;
//                }
//        return collection;
//    }
//}


//class SelectionSorting : ISorting<int>
//{
//    public List<int> Sort(List<int> collection)
//    {
//        var arrayLength = collection.Count;
//        for (int i = 0; i < arrayLength - 1; i++)
//        {
//            var smallestVal = i;
//            for (int j = i + 1; j < arrayLength; j++)
//            {
//                if (collection[j] < collection[smallestVal])
//                {
//                    smallestVal = j;
//                }
//            }
//            var tempVar = collection[smallestVal];
//            collection[smallestVal] = collection[i];
//            collection[i] = tempVar;
//        }
//        return collection;
//    }
//}

//class DefaultSorting : ISorting<int>
//{
//    public List<int> Sort(List<int> collection)
//    {
//        var lst = collection;
//        collection.Sort();
//        return collection;
//    }
//}
//class Sorting<T>
//{
//    private ISorting<T> _sorting;

//    public Sorting(ISorting<T> sorting)
//    {
//        _sorting = sorting;
//    }
//    public List<T> Sort(List<T> collection) => _sorting.Sort(collection);
//}
#endregion
