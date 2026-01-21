# Assignment 2 –  Generics

**Type safety in generics**
>ensures that a generic type only holds objects of the specified type, which is enforced at compile time.This prevents runtime type errors and the need for costly runtime type checks or casting

>For example, a List<int> can only store integers, and the compiler will flag an error if an attempt is made to add a string.

>**Elimination of Casting**:-Before generics, developers often used non-generic collections like ArrayList, which stored items as the object type. Retrieving items required a manual cast back to their original type.

>Generics eliminate this need, as the compiler already knows the type, allowing direct access to methods and properties.

**Performance benifits in Generics**
>**Avoids Boxing and Unboxing**:-Generics improve performance by reducing the need for boxing and unboxing operations, which are necessary when using non-generic collections with value types.

>Boxing is the process of converting a value type to an object type, which incurs a performance cost. Unboxing is the reverse process. Generics allow value types to be stored directly without boxing, leading to better performance.

>**Efficient Memory Usage**:-By avoiding the creation of temporary objects on the heap for boxing, generics reduce pressure on the garbage collector. This leads to fewer and quicker garbage collection cycles, improving application responsiveness and throughout.     