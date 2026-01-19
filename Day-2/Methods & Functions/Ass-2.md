# Assignment - Methods & Functions Theory

**Explain:
      Parameter passing mechanisms
      Difference between returning values and void**

>There are three primary parameter passing mechanisms in C#:
 >1. Pass by Value: This is the default mechanism. When a parameter is passed by value, a copy of the actual parameter's value is made and passed to the method. Changes made to the parameter inside the method do not affect the original variable outside the method.
  2. Pass by Reference (using ref keyword): When a parameter is passed by reference, a reference (or pointer) to the actual parameter is passed to the method. This means that any changes made to the parameter inside the method will directly affect the original variable outside the method.
  3. Output Parameters (using out keyword): Similar to pass by reference, but specifically used for parameters that are intended to be initialized within the method. The called method must assign a value to the out parameter before the method returns. This is useful when a method needs to return multiple values.
  
 >Difference between returning values and void:
  >Returning Values: When a method is defined to return a specific type (e.g., int, string, custom object), it must include a return statement that provides a value of that type. The caller of the method can then use this returned value for further processing.
  >Void: A method defined with a void return type does not return any value. It is typically used for methods that perform actions or operations without needing to provide any data back to the caller. In this case, the method simply executes its code and then exits without returning anything.
