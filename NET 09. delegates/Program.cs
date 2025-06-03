using System.Numerics;

// delegates
// public delegate return_datatype delegate_name([parameter list])


#region Delegate
//Pred predicate = null;
//List<int> ints = [25, 9, 2, -1, 336, 78, 77];
////predicate = isEven;
////Console.WriteLine(predicate(3));
//var even = Filter(ints, isEven);
//even.ForEach(Console.WriteLine);
//List<int> Filter(List<int> lst, Pred predicate)
//{
//    List<int> tmp = new();
//    for (int i = 0; i < lst.Count; i++)
//    {
//        //if (predicate(lst[i])) tmp.Add(lst[i]);
//        if (predicate.Invoke(lst[i])) tmp.Add(lst[i]);
//    }
//    return tmp;
//}


#endregion

#region Multicast delegates
//Pred pred = isOdd;
//pred += isEven;
//pred += isNegative;
////Console.WriteLine(pred(-5));

////foreach (Pred item in pred.GetInvocationList())
////{
////    //Console.WriteLine(item(5));
////    Console.WriteLine(item.Invoke(5));
////}

//var delegateList = pred.GetInvocationList();
//Console.WriteLine(delegateList[0].Method);
//Console.WriteLine(delegateList[1].Method);
//Console.WriteLine(delegateList[2].Method);
//Console.WriteLine(delegateList[2].DynamicInvoke(-9));

#endregion


#region Generic delegates
//GenericPred<double> genericPred = isDoubleNegative;

//Console.WriteLine(genericPred(32.4));
#endregion

#region Standard delegates Action<T>, Func<T>, Predicate<T>, Comparison<T>
#region Action<T>
// Action<T> - 16-ya qeder parameter qebul ede bilen
// ve void qaytaran methodlar uchun nezerde tutulmush generic delegatedir
// Action<int> <=> delegate void someDelegate(int x);

//List<int> ints = [25, 9, 2, -1, 336, 78, 77];
////ShowFilters(ints, ShowNegativeValues);
//ShowFilters(ints, ShowPositiveValues);
#endregion

#region Func<T>
// Func<T> - 16-ya qeder parameter qebul ede bilen
// ve return type-i olan methodlar uchun nezerde tutulmush generic delegatedir
// Func<int, bool> <=> delegate bool someDelegate(int x);
// Func<int, double, string, int> <=> delegate int someDelegate(int x, double y, string z);
//Func<int, bool> func = isOdd;
//Console.WriteLine(func(52)); 
#endregion

#region Predicate<T>
// Predicate<T> - 1 parameter qebul ede bilen
// ve bool qaytaran methodlar uchun nezerde tutulmush generic delegatedir
// Predicate<T> <=> delegate bool someDelegate(T x)
//Predicate<int> predicate = isOdd;
//Predicate<double> predicateDouble = isDoubleNegative;
#endregion

#region Comparison<T>
// Comparison<T> - 2 parameter qebul ede bilen
// ve int qaytaran methodlar uchun nezerde tutulmush generic delegatedir
// Comparison<T> <=> delegate int someDelegate(T x, T y)
int[] ints = [25, 9, 2, -1, 336, 78, 77];
Array.Sort(ints, Descending);
foreach (var item in ints)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

int Descending(int left, int right)
{
    if (left == right) return 0;
    else if (left > right) return -1;
    else return 1;
}

#endregion


#endregion

bool isOdd(int value)
{
    return value % 2 != 0;
}
bool isEven(int value)
{
    return value % 2 == 0;
}

bool isNegative(int value)
{
    return value < 0;
}

bool isDoubleNegative(double value)
{
    return value < 0;
}

void ShowNegativeValues(int x)
{
    if (x < 0) Console.WriteLine(x);
}

void ShowPositiveValues(int x)
{
    if (x > 0) Console.WriteLine(x);
}

void ShowFilters(List<int> lst, Action<int> func)
{
    foreach (var item in lst)
    {
        func(item);
    }
}

delegate bool Pred(int x);

delegate void someDelegate(int x);

// generic delegates
delegate bool GenericPred<T>(T x);