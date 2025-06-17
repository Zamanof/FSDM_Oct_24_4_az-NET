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


class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
}
