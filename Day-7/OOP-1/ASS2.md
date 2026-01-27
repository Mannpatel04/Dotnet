# Assignment: Theory 

## Validation of constructors

### Constructor Validation:
In order to guarantee that an object is always generated in a **valid state**, constructor validation entails **checking data at the moment of object creation**. If invalid data is given, the object should **not be constructed**.

### The Significance of Constructor Validation

Prevents objects from being invalid
Early enforcement of company regulations
Enhances security and dependability
Later in the software, there are less bugs.



## Modifiers of Access

>Access modifiers help accomplish encapsulation and security by limiting access to a class or its members.

The Modifier | Accessibility |
| -------------------- | ------------------------------------------------ |
| `public` | Reachable from any location |
|`private` | Accessible only within the same class
|`protected` | Accessible inside the same class and descendant classes
| `internal` | Accessible within the same assembly
| `protected internal` | Derived classes OR the same assembly
| `private protected` | Derived classes AND the same assembly