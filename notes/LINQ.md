# LINQ
- Language-Integrated Query
    - is a uniform query syntax in C# and VB.NET to retrieve data from different sources and formats
## LINQ Queries
    - Expressions that retrieve data from source
        - Data Source
        - Query
        - Execution
## LING - Query Expression Basics
    - A query expression must begin with a from clause and must end witha  select or group clause. Getween the first from clause and the last select or group, it can contaion one or more: where, order by.
    - The application always sees the source data as IEnumerable<T> or IQueriable<T>
 ```csharp
int[] scores={90,71,82,93,75,82};
IEnumerable<int> highScoresQuery =
    from score in scores
    where score >80
    orderby score descending
    select score;
foreach(int scores in highScoresQuery){
    Console.WriteLine(scores);
}
 ```

# Extension Methods
This is a way to "inject" additional functionallity of an existing class without creating a new classes/types
LINQ provides all its functionality via extension methods
In order to access the functionality of extension methods, all you have to do is include the namespace that hte extension methods live in via using directive(i.e: using System.Linq;)

# Lambda Expression
Is a way to create anonymous function. The left hand side before the arrow is your method parameters, right hand side is your method body/return statement. Used extensively in LINQ method syntax. If you want to create multi line lambda expression or do operations before you return, you have to surround your right hand side with {}. Then you have to be explicit about what you want to return.
```csharp
x=> x*2
```
or
```csharp
x=>{
    int y = x+x;
    return y;
    };
```
is equivalent to
```csharp
int DoubleTis(int x){
    return x*2;
}
```