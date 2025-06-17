// Garbage Collector

/*
    1. Stack -> FILO
    
    2. Heap
        - Managed heap
            * Generation 0
            * Generation 1
            * Generation 2
        
        - LOH - Large Object Heap: 85000 byte-dan boyuk olan obyektler bu heap-de yaradilir
        
        - Pinned Heap - GarbageCollector terefinden obyektin yeri deyisdirile bilmir
        
        - Unmanaged Heap 
 */

//Console.WriteLine(GC.MaxGeneration);
GarbageHelper garbageHelper = new();
//garbageHelper.MakeGarbage();
//Console.WriteLine($"Generation - {GC.GetGeneration(garbageHelper)}");
//GC.Collect();
//Console.WriteLine($"Generation - {GC.GetGeneration(garbageHelper)}");
//GC.Collect();
//Console.WriteLine($"Generation - {GC.GetGeneration(garbageHelper)}");
//GC.Collect();
//Console.WriteLine($"Generation - {GC.GetGeneration(garbageHelper)}");

//var genNumber = 0;

//for (int i = 1; i < 1_000_000; i++)
//{
//    garbageHelper.MakeGarbage();
//    if (genNumber != GC.GetGeneration(garbageHelper))
//    {
//        Console.WriteLine($"{i * 1000} Generation - {GC.GetGeneration(garbageHelper)}");
//        genNumber++;
//    }
//}
//Console.WriteLine(GC.CollectionCount(0));
//Console.WriteLine(GC.CollectionCount(1));
