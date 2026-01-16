# Assignment-2

**Q: What is .NET?**
> .NET is a free, open-source, cross-platform developer platform created by Microsoft. It provides a massive collection of libraries, languages, and tools that allow you to build many types of applications, including web, mobile, desktop, gaming, and IoT.

**Q:Difference between .NET Framework, .NET Core, and .NET (latest)**
>.NET Framework: The original version used strictly for building Windows applications.

>.NET Core: A complete rewrite designed to be "cloud-first" and run on any operating system.

>.NET (5 and later): Microsoft dropped the "Core" branding to signify that this is now the single, unified platform moving forward. It combines the best parts of Core and Framework.

**Q:Role of C# in the .NET ecosystem**
>While .NET is the "engine room" or the platform, C# (C-Sharp) is the primary language used to write instructions for it.It is a modern, object-oriented, and type-safe language that is the "first-class citizen" of .NET.When you write C# code, it is compiled into Intermediate Language (IL). The .NET Runtime then translates that IL into machine code that your computer's processor understands.Because of C#'s deep integration with .NET, you can use the same language to build a website (ASP.NET), a mobile app (MAUI), or a high-end game(Unity).


# Assignment-5

**Q:Why Nullable Types?**
> In early C#, Value Types like int, double, bool were required to have a value. An integer could be 0, but it could never be "missing." This created problems in two main scenarios:

Databases: Most databases allow columns to be NULL. If a database had an optional "Age" column, C# had no way to represent that "nothing" state without using a "magic number" (like -1), which often led to bugs.

UI/Forms: When a user leaves a numeric field blank in a web form, the data is neither 0 nor 1; it is simply absent.

Nullable types (T?) were introduced to allow these value types to represent a null state safely, bridging the gap between database logic and application code.


# Assignment-7
**Q:Keyword Comparison: const vs. readonly**

Below is a detailed comparison of the `const` and `readonly` keywords in C#. This table highlights the fundamental differences in how they handle memory, initialization, and execution.

| Feature | `const` | `readonly` |
| :--- | :--- | :--- |
| **Initialization** | Must be initialized **at the time of declaration**. | Can be initialized at **declaration** OR inside a **constructor**. |
| **Binding Time** | **Compile-time** constant. The value is "baked" into the assembly at compile time. | **Run-time** constant. The value is evaluated only when the object is instantiated. |
| **Runtime Behavior** | Values are static and cannot be changed. Attempting to change them causes a **Compiler Error**. | Values are fixed once the constructor finishes. Attempting to change them elsewhere causes a **Compiler Error**. |
| **Scope/Access** | Behavior is implicitly `static`. You access it via `ClassName.VariableName`. | Can be `static` or instance-based. Usually accessed via `instanceName.VariableName`. |
| **Allowed Types** | Only primitive types (int, double, etc.), enums, or strings. | Can be used with any type, including complex objects and classes. |
| **Use Cases** | Mathematical constants (e.g., `PI`), version numbers, or fixed physics values. | Configuration settings, API keys, or IDs generated when a program starts. |

---







