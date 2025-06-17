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


class GarbageHelper
{
    public void MakeGarbage()
    {
        for (int i = 0; i < 1000; i++)
        {
            Person person = new();
        }
    }
}