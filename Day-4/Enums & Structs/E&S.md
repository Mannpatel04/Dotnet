# Assignment: Enums & Structs

**1.Advantages of Enums**
>An enum is a user-defined data type that represents a fixed set of named constants or states. 

>**Improved Readability and Maintainability**:-Enums allows you to replace string with meanningful names, making code more understable and self documenting.

>**Type Safety**:-It ensures that it takes value from predefined sets. it is the strongly typed and preventing accidental assignment of invalid data.

>**Compile-Time Validation**:-compiler can take issue duting compilation. it catches bugs early such as forgetting a switch statement.

>**Centralized Definitions**:-by defining related constants in one place, it takes easier to update and manage them.

>**Better Debugging**:- Debuggers can display the symbolic name of the enum value rather than integer.



**2. Limitations of structs**
>A struct is a user-defined data type that groups related variables together. but it has specific limitations, especially when compared to Enums or Classes.

>**Pattern Matching**:-unlike enums, it doesn't guarantee that all possible scenarios of struct are handled with switch statements.

>**Performance Overhead with Large Data**:-Structs are typically value types,meaning they are copied when passed around. Passing large structs can reduce performance.

>**Lack of Inheritance**:-it doesn't support inheritance, limiting code reuse and extensibility.

>**Lack of Inheritance**:-because it is value type, it cannot have a default constructor or destructor.