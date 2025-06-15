// Anonymous methods

List<int> list = new List<int>();
FillList(list);

ShowList(list);

#region method and delegates
//MyPredicate myPredicate = IsEven;
//Func<int, bool> func = IsEven;
//var evens = list.Where(func).ToList();
//var evens = list.Where(IsEven).ToList();
//ShowList(evens);

#endregion

#region Anonymous methods
// anonim method-lar
// delegate(parameters_list){some_code_block; return value;}
/*
 delegate (int x) { return x % 2 != 0; }
			equal
bool IsEven(int number)
{ 
	return number % 2 != 0;
}
*/

//var evenNumbers = list.Where(delegate (int x) { return x % 2 != 0; }).ToList();
//ShowList(evenNumbers);

#endregion

#region Lambda expressions
// (parameters_list) => {some_code_block; return value;}
// (parameters_list) => value;

/*
 
 x=>x%2!=0;

			equal

 delegate (int x) { return x % 2 != 0; }

			equal

bool IsEven(int number)
{ 
	return number % 2 != 0;
}
*/

//var evenInts = list.Where(x => x % 2 != 0).ToList();
//var negativeInts = list.Where(x => x < 0).ToList();
//var primeNumbers = list.Where(x =>
//{
//	if (x == 1 || x <= 0) return false;
//    for (int i = 2; i <= x/2; i++)
//	{
//		if (x % i == 0) return false;
//	} 
//	return true;
//}).ToList();

//ShowList(evenInts);
//ShowList(negativeInts);
//ShowList(primeNumbers);

// lambda => anonim metod => delegate 

//var func = (int x) => x % 2 != 0;
//var func2 = delegate (int x) { return x % 2 != 0; };

//Console.WriteLine(func(21));
//Console.WriteLine(func2(2));

#endregion


// Lambda ifadeleri bu shekilde istifade etmek meslehet deyil
// Lambda ifadeler maksimum "pure method" olmalidir
// https://dev.to/kjdowns/what-s-a-pure-function-205e
var fill = (List<int> lst) =>
{
	Random random = new Random();
	for (int i = 0; i < 10; i++)
	{
		lst.Add(random.Next(-99, 99));
	}
};
//fill(list);
//ShowList(list);


/*
 Lambda expressions:

C++:					[](int x){return x%2 != 0;}   -> functor, pointer to functions
Python:					lambda x: x%2 != 0
C#:						x => x%2 != 0     -> anonim metodlar -> delegate
 
*/

bool IsEven(int number) 
	=> number % 2 != 0;
void FillList(List<int> lst)
{
    Random random = new Random();
	for (int i = 0; i < 10; i++)
	{
		lst.Add(random.Next(-99, 99));
	}
}

void ShowList(List<int> lst)
{
	foreach (int i in lst)
	{
		Console.Write($"{i} ");
	}
    Console.WriteLine();
}

delegate bool MyPredicate(int x);