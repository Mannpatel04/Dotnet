# Assignment 2 –  Loops Theory

**1.Infinite loops**
>In programming, an infinite loop is a sequence of instructions that continues to execute indefinitely because the terminating condition is never met.

>Comman Ways to Create Infinite Loops:
 1. **Using a `while` loop with a condition that is always true**:
   ```C#
    while (true)
     {
	   // Code to be executed repeatedly
     }
   ```
   2. **Using a `for` loop without a proper terminating condition**:
   ```C#
    for (;;)
     {
       // Code to be executed repeatedly
     }
   ```
   3. **Modifying the loop control variable incorrectly**:
   ```C#
    int i = 0;
    while (i < 10)
     {
       // Code to be executed
       // Missing increment of i
     }
   ```
   **Breaking out of Infinite Loops**
   >To break out of an infinite loop, you can use the `break` statement, which immediately terminates the loop and transfers control to the statement following the loop.
   ```C#
    while (true)
    {
      string input = Console.ReadLine();
       if (input == "exit") 
         {
           break; // The safe exit
         }
    }
   ```
   **Common Use Cases for Infinite Loops**
   1. **Event Listening**: In applications that need to continuously listen for events (like user input or network requests), infinite loops are used to keep the program running and responsive.
  
   **Risk**: Infinite loops can lead to high CPU usage and unresponsive programs if not managed properly. Always ensure there is a clear exit strategy for the loop.



   **2.break vs continue**

   > The `break` and `continue` statements are used to control the flow of loops in programming, but they serve different purposes.
   - **`break` Statement**:
     - The `break` statement is used to exit a loop or switch statement prematurely. When encountered, it immediately terminates the loop and transfers control to the statement following the loop.
     - Example:
     ```C#
      for (int i = 0; i < 10; i++)
      {
        if (i == 5)
        {
          break; // Exit the loop when i is 5
        }
        Console.WriteLine(i);
      }
     ```
     - In this example, the loop will print numbers 0 to 4 and then exit when `i` equals 5.

     - **`continue` Statement**:
     - the continue statement is used to skip the remainder of the current iteration and jump immediately to the next one.In an infinite loop, continue is often used to filter out "noise" or invalid data without shutting down the entire process.
     ```C#
      for (int i = 0; i < 10; i++)
      {
        if (i % 2 == 0)
        {
          continue; // Skip even numbers
        }
        Console.WriteLine(i);
      }
     ```
   - 
     
    
     