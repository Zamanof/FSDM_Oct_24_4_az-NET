// Non generic collections

using System.Collections;

Random random = new();

#region ArrayList
ArrayList numbers = new ArrayList();
//Console.WriteLine(numbers.Capacity); 
//Console.WriteLine(numbers.Count);
numbers.Add(random.Next(10, 99));
numbers.Add(random.NextDouble());
numbers.Add("Hi");

//Console.WriteLine(numbers.Capacity);
//Console.WriteLine(numbers.Count);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

#endregion

#region Stack
//Stack stack = new();
//stack.Push(98);
//stack.Push(79);
//stack.Push(123);
//stack.Push(44.6);
//stack.Push("Salam");
//Console.WriteLine(stack.Count);
//Console.WriteLine(stack.Pop());
//Console.WriteLine(stack.Count);
#endregion

#region Queue
//Queue queue = new();
//queue.Enqueue(129.36);
//queue.Enqueue("Hello");
//queue.Enqueue(23);

//Console.WriteLine(queue.Count);
//Console.WriteLine(queue.Dequeue());
//Console.WriteLine(queue.Count);
#endregion

#region Hashtable
//double w1 = 36984.69;
//double w2 = 36984.69;

//Console.WriteLine(w1.GetHashCode());
//Console.WriteLine(w2.GetHashCode());

//Hashtable hashtable = new();
//hashtable.Add("hi", "659");
//hashtable.Add(69, "Salam");
//hashtable.Add(9.3, true);
//Console.WriteLine(hashtable[1]); 
//Console.WriteLine(hashtable[9.3]);

#endregion