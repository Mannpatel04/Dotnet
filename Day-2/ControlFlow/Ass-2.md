# Assignment - Controlflow Theory

**Explain-
           1)When switch is preferable
           2)Research and briefly explain modern switch enhancements**

>1)

>A switch is generally preferred over if-else in the following scenarios.Because Switch case has cleaner Syntax than ifelse statements.
 ->And  usually large number of cases, Compiler optimize the switch to jump directlyinto a hash list.
 ->Readability is High.

>2)
 
>In modern C# (8.0+), a switch can now return a value directly, turning it into an expression rather than just a statement.
 Old way: Assign a variable inside each case and remember to break.
 New way: Use the "arrow" syntax (=> or ->) to map a value directly.
 For ex:-
 ```
 string colorName = code switch {
    1 => "Red",
    2 => "Blue",
    _ => "Unknown" // The discard (_) is the default
  };
  ```
 >Pattern Matching is the biggest upgrade. You are no longer limited to checking just integers or strings. You can check:

    Types: Execute code if an object is a String, a different block if it's an Integer.

    Properties: Execute code if User.Age > 18.

    Tuples: Check multiple variables at once (e.g., switch (x, y)).

 >You can now add extra conditions to a case using the when keyword (C#).
 
 >No more Mandatory break
  Modern "arrow" syntax (-> or =>) removes the "fall-through" behavior by default. You no longer need to write break; at the end of every line, which eliminates one of the most common bugs in programming history.















