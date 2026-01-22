## Assignment- 2: Day-5 theory

**Performance impact of boxing**
>Boxing and unboxing has a significate performance impact primararly due to heaqp memory allocation and increase in garbage collection.this process converts fast access value type from object type on the slower access managed heap.

>**Memory Allocation**:-Each time when value is boxed the CLR  allocate new object instance on heap and copies values into it.this process is slow.

>**Garbage Collection Pressure**:-When object is created then after evantually the it deallocated by Garbage collector. it increase thew frequency of the GC Cycles and consume CPU  leading to performance degradation.

>**Speed Overhead**:-It show that boxing operations can be significantly slower than working with value types directly.

>**CPU Cache Inefficiency**:-Value types stored on the stack are often efficiently managed in the CPU's fast cache memory.oxed values, moved to the heap, require access to slower main memory and bypass these caching optimizations, further impacting performance. 


**Delegates vs interfaces**
>Both *Delegates* and *Interfaces* are used to achieve abstraction and flexibility in C#, but they are used in very different scenarios.

**Delegates**
>A *delegate* is a type-safe reference to a method.  
It allows methods to be passed as parameters and called dynamically at runtime.

- Refers to **methods**
- Supports **single or multiple methods** (multicast)
- Used in **events, callbacks, LINQ**
- Lightweight and concise

**Interfaces**
>An **interface** defines a contract that a class must implement.  
It represents **what a class can do**, not how it does it.

- Defines **method signatures**
- Implemented by **classes or structs**
- Used to achieve **multiple inheritance**
- Better for **large, structured designs**