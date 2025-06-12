// LINQ - Language Integrated Query
// declarative yanashmali sorqular dilir
/*
 LINQ to Object 
 LINQ to Dataset
 LINQ to SQL
 LINQ to Entities
 LINQ to XML
 PLINQ - Parallel LINQ
*/

int[] arr = [25, 36, 98, -56, -3, 36, -46, 369, 3, 0, -789];
Show(arr);
#region from, select
IEnumerable<int> query = from i in arr
						 select i;

//Show(query);

//arr[3] = 1_244_244;

//Show(query);
#endregion

#region where
//query = from number in arr
//		where number > 0 && number % 2 == 0
//		select number;
//Show(query);
#endregion

#region orderby (by default ascending), descending
//query = from i in arr
//		where i > 0
//		orderby i descending
//		select i;
//Show(query);
#endregion

#region group by
//var group = from i in arr
//			where i > 0
//			group i by i % 2; // 0 1
//foreach (var item in group)
//{
//    Console.WriteLine(item.Key);
//	foreach (var value in item)
//	{
//        Console.WriteLine($"		{value}");
//	}
//}
#endregion

#region into
//var query_into = from i in arr
//				 where i > 0
//				 group i by i % 2 into result
//				 from j in result
//				 group j by j % 10;
//foreach (var item in query_into)
//{
//    Console.WriteLine(item.Key);
//	foreach (var value in item)
//	{
//        Console.WriteLine($"	{value}");
//	}
//}
#endregion

void Show(IEnumerable<int> arr)
{
	foreach(var i in arr)
	{
		Console.Write($"{i} ");
	}
    Console.WriteLine();
}

