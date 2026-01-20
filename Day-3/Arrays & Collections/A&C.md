# Assignment 2 – Arrays & Collections Theory

**Arrays & List**

**1.Arrays:**

> An array is a data structure that can hold a fixed number of values of a single type, while collections are more flexible data structures that can hold varying numbers of elements and can often store different types of data.
- **Arrays**:
  - Fixed Size: Once an array is created, its size cannot be changed.
  - Homogeneous: All elements in an array must be of the same type.
  - Indexed: Elements are accessed using their index positions.
  - Example:
	```C#
	int[] numbers = new int[5]; // An array of 5 integers
	numbers[0] = 10;
	numbers[1] = 20;
	```

**2.List:**

> A List in C# is a dynamic array that can grow and shrink in size as needed. It is part of the System.Collections.Generic namespace and provides various methods for manipulating the collection of items.
	- Whereas arrays have a fixed size, lists can grow and shrink dynamically as elements are added or removed.
	- It has a namespace called System.Collections.Generic.
	- It is slightly Slower than arrays because of its dynamic nature.
	- It is method rich but uses more memory.
	- Example:
	  ```C#
      List<string> colors = new List<string>();
      colors.Add("Red");
      colors.Add("Blue"); // Automatically resizes for you
      colors.Remove("Red");
	  ```

**How Dictionary works internally:** 

>In C#, a Dictionary<TKey, TValue> is implemented as a Hash Table with a collision resolution strategy called Chaining. It is optimized for $O(1)$ (constant time) lookups, meaning that finding an item takes the same amount of time regardless of how many millions of items are in the dictionary.
    - **Hashing**: When you add a key-value pair to the dictionary, the key is passed through a hash function that computes an integer hash code. This hash code is then used to determine the index in an internal array where the value will be stored.
	- **Buckets and Chaining**: The internal array is divided into "buckets." Each bucket can hold multiple entries in case of hash collisions (when two keys produce the same hash code). In such cases, the dictionary uses a linked list or another data structure to store multiple entries in the same bucket.
	- **Resizing**: When the number of entries exceeds a certain threshold (load factor), the dictionary automatically resizes its internal array to maintain efficient performance. This involves creating a new, larger array and rehashing all existing entries to their new positions.
	- **Lookup**: To retrieve a value, the dictionary computes the hash code of the key, finds the appropriate bucket, and then searches through the entries in that bucket to find the matching key. If found, it returns the associated value.
	- **Performance**: The average time complexity for lookups, insertions, and deletions in a dictionary is $O(1)$, but in the worst case (e.g., many collisions), it can degrade to $O(n)$.
	- **Example**:
	  ```C#
	  Dictionary<int, string> studentNames = new Dictionary<int, string>();
	  studentNames.Add(1, "Alice");
	  studentNames.Add(2, "Bob");
	  string name = studentNames[1]; // Retrieves "Alice"
	  ```



 
	
	
