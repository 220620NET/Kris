# Data Structure
Is great when you have more than 1 datum(?) to store.

All data structure mentioned below have different strengths and weaknesses, so we can use them accordignly to our benefit
## Array
Is a collection of objects that is of the same data type.
Its a fixed length - you have to declare the length at initialization.
When we run out of the space we have to create a longer array and we have to copy over.They also take up _contiguous_ memory space, so getting the value of the element at a known index (such as 5th element of an array) only takes one calculation/operation.

- Fixed Length
- everything is right next to each other

## List
- Lists are auto-resizing arrays
List addresses array's fixed length inconvenience(?) by auto resizing when it runs out of space.
Additional features List introduces on top of arrays
    - Resizing without you having to get involved
        -You don't have to declare the length of list on initialization
        - Trivia: Initial length of List is 4
    - Big O of Adding: O(1)
        - Resize due to running out of space O(n)
    - Adding to the end of the list without worrying about how full the list is.
    - Count property that will gve you the number of elements currently in the list
    - Searching
    - Removing
    - Capacity property - that gives you how big the actual backing array is
## Generic Classes
`<T>` is an indicator that the particular class is a generic class.
Generic class is a class that can work with many different type of data.
For example, we can have `List<String>` `List<int>` `List<List<List<int>>>`
Generic Classes preserve the same set of behavior for multiple data types. This is a little different from overloading. This is anouther example of polymorphism, one of the principles of OOP.

## Algorithm analysis: Time Complexity and Big O Notation
Algorithm is a finite set of instruction.
2 types of complexity: time complexity, space complexity
    -Time complexity: the amount of time an algorithm takes to complete in  # instructions/n elements. For array of N eleements, looking at each array element would take N instructions. The most common notation to describe the time complexity of an algorithm is Big O: O(). Big O notation is interested in worst case analysis. (In our nave searching of the array where we traverse the array from the front to back in search of an item, the worst case scenario was when the item was at the very end. We had to traverse all the way to the end to find the item: O(n)-linear)
    - Space complexity: how much memory space does your algorithm take up when executing
Other examples of O(n) operations:
    - Traversing through an array of n elements
    - Loops (single layered)

Example of O(1) operations:
    -Accessing an element in an array with its index

O(log n)
    - Binary search
O(n^2)
    - Doubly Nested Loops
O(n^3)
    - Triple Nested Loops
O(c^n)
    - Permutation algorithms
## Dictionary
Is a collection of key value pair
`{
    "key": value,
    "key1": value,
    "key2" : value
}`
-Keys must be unique
-Values must be unique
-Lookup in dictionaries with its key is very cheap
    -this is an ideal tool if you want to find something via key
    -Example of using dictionary is on "Return the frequency of the most frequent letter in a string
        -"aaaaabbccwff"
    - Store two related data types together(such as username and password)
        -instead of string username ="pw";

## foreach loop and IEnumerable
Not all data structures are designed to access items by its index. But still there are ways to loop through those collections even when we can't access its items by index. Any classes that implements IEnumerable has ability to give you the enumerator(which basically gives you the next item in the list). We use the enumerator under the hood through foreach loop.
## Hashset
C#'s generic implementation of Set. Set is a finite collection where no two elements are duplicates. This is great when you want to ensure you're not adding any duplicates.-Removing all duplicates from an array. -Do set operations with these (Union, sSubset, isSuperset)
## Queue and Stack
Quee and Stack are related data structures
Quese: DMV or Bank queue or Bus line. First come, first served. The item that is added to the queue the first, is the first to be accessed. FIFO
Stack: LIFO
- These data structures do not support accesssing by index or searching
- Add( for stack)/Enqueue(for queue)
- Pop/Dequeue
- Peek: fr looking at what is next
- Size: How many things are in here
## LinkedList
Linked List is a type of data structure where the data is not necessarily stored next to each other but each node keeps a reference(aka the memory location) to its next neighbor(next node). When the node only keeps a reference to its previous neighbor, we call it a "doubly linked list"

## Generic vs. Non Generic Collections
In C#, we have two different namespaces for sollections: System.Collections. SystemCollections.Generic
System.Collections.Generic is where all generic collections like List<T>, HashSet<T>, Queue<T>,Stack<T> all live in.
In the case you want to store multiple data types in a collection, you can go about it in two ways.
    1. use non-generic collections: Queue, Stack, ArrayList, Hashtable, SortedList. These non-generic collections, box(aka turn everything into Object) data before storing. Which means if you want to access the data, unboxing is needed
## and More!
C# System.Collections.Generic C# System.Collections
