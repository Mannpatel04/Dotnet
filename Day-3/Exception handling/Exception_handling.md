# Assignment 2 –  Exception Handling Theory

**1. Exception Handling:**
> Exception handling is a programming construct that allows developers to manage and respond to runtime errors in a controlled manner, ensuring that the program can continue to operate or fail gracefully without crashing unexpectedly.
- **Try Block**: The code that may potentially throw an exception is placed inside a `try` block. If an exception occurs, the control is transferred to the corresponding `catch` block.
- **Catch Block**: The `catch` block is used to handle the exception. It can specify the type of exception it can handle, allowing for specific error handling.
- **Finally Block**: The `finally` block is optional and is used to execute code that must run regardless of whether an exception occurred or not, such as releasing resources.
- **Example**:
```C#
try
{
	int[] numbers = { 1, 2, 3 };
	Console.WriteLine(numbers[5]); 
}
catch (IndexOutOfRangeException ex)
{
	Console.WriteLine("An error occurred: " + ex.Message);
}
finally
{
	Console.WriteLine("Execution completed.");
}
```

**2. Exception suppression:**
> Exception Suppression means catching an exception but doing nothing with it, effectively ignoring or hiding the error.
- **Goal**:
  - There is no valid goal in most cases.
  - Makes debugging difficult.
-**Example**: 
```C#
try
{
    int result = 10 / 0;
}
catch (Exception)
{
    // Exception suppressed
}
```


**Risks of empty catch blocks**:
>When the catch block is empty, it is the Exeption Suppression like we discuss above.
- **Debugging Difficulty**: Suppressing exceptions makes it challenging to identify and fix issues in the code since errors are silently ignored.
- **Hidden Bugs**: Important bugs may go unnoticed, leading to unexpected behavior later in the program's execution.
- **Resource Leaks**: If exceptions related to resource management (like file handling or database connections) are suppressed, it can lead to resource leaks and other unintended consequences.
- **Poor User Experience**: Users may experience failures or unexpected behavior without any indication of what went wrong, leading to frustration.

- **Best Practices**:
  - Always log exceptions, even if you choose not to rethrow them.
  - Provide meaningful error messages or take corrective actions when handling exceptions.
  	- Avoid using empty catch blocks unless absolutely necessary and justified.d,m  43


