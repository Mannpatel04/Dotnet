# Assignment 2 –  Lambda Expression 

**Benefits of lambda expressions**
>Lambda expressions  provide a concise, readable, and flexible way to write inline anonymous functions.

>**Concise and Readable Code**:-Lambdas significantly reduce the boilerplate code.making the code cleaner and easier to read, especially in methods with a top-to-bottom flow

>**Enhanced LINQ Integration**:-They are fundamental to LINQ, simplifying data manipulation operations such as filtering, sorting, and projection on collections like List<T> or data from various sources.

>**Support for Functional Programming**:-Lambdas facilitate functional programming techniques, allowing developers to treat functions as first-class citizens, enabling higher-order functions and function composition.

>**Improved Developer Efficiency**:-y allowing inline function definitions, lambdas help avoid the need to create separate classes or methods for simple tasks, which can speed up the development process. 


**Lambda vs traditional methods**
>the primary difference between lambda expressions and traditional methods lies in their syntax, context, and the functionality they offer, such as type inference and the creation of expression trees.

>Lambdas provide a concise, inline way to define anonymous functions, ideal for short, one-time use, while traditional methods are suited for reusable, complex logic.

>| Feature              | Lambda Expressions                                   | Traditional Methods                                     |
| -------------------- | ---------------------------------------------------- | ------------------------------------------------------- |
| **Naming**           | Anonymous= it has no names                                  | Explicitly named                                        |
| **Syntax**           | Concise, uses `=>` operator                          | Formal method signature (return type, name, parameters) |
| **Usage**            | Ideal for short, inline, one-time use (LINQ, events) | Ideal for complex, reusable logic                       |
| **Type Handling**    | Types often inferred by the compiler                 | Types must be explicitly declared                       |
| **Expression Trees** | Can be converted to expression trees                 | Cannot be converted to expression trees                 |
| **`yield return`**   | Not allowed                                        |  Allowed (can be iterators)                            |
| **Recursion**        | Possible but requires workarounds                    | Naturally supported                                     |
| **Debugging**        | Harder to debug and modify                           | Easier to debug and maintain                            |

