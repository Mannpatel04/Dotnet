# Assignment-2 Operations-Theory

**Explain:
           Difference between == and Equals()
           Short-circuit behavior in logical operators**
>(==)Operator: The '==' operator is used to compare the values of two operands to determine if they are equal. For value types, it compares the actual values, while for reference types, it checks if both references point to the same object in memory unless the operator is overloaded.

>(Equals())Method: The 'Equals()' method is a member of the Object class and can be overridden in derived classes to provide custom equality logic. By default, it behaves similarly to '==' for reference types (checking reference equality) but can be customized to compare the contents of objects.

>2)  

>For an && statement to be true, both sides must be true.
 If the first side is False, the computer doesn't even look at the second side.
 Why?->Because no matter what the second side is, the whole result is already guaranteed to be False.

> For an || statement to be true, only one side needs to be true.
 If the first side is True, the computer skips the second side.
 Why?->Because the requirement for "True" has already been met.
