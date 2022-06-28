# Common language Infrastructure
List changes size automattically

-   This is a set of specification initially developed by Microsoft for .NET compliant landugages to subscribe to. And this is what allows many different .NET compliant languages to work with each other


# Common Type System
- A type specification that all .NET compliant/CLI languages must impement
- Int32 is Common Type Systems's name for 32 bit integer
- int is C#'s name for 32 bit integer. Inte32 and int is the samething
- Int64 in CTS == long
- Int16 == short

- Int32.Parse() =int.Parse()


# Common Language Runtime
- Is a runtime for all CLI languages, it translates the Intermediary Languages to Native Code on execution using Just-In-Time compiler. It also provides servces such as automatic memory management(garbage collection), exception handling, type safety

# Unit Testing in C#

## Why Wreite Tests?
So far we've been manually testing our code, as in after we write some code, we run our code to make sure the behavior of the program matches our expected behavior. If it doesn't, then there is a bug. If there is a bug, we "debug" by tracking down which part of the program is not functioning as intended. Once we narrow down the problem and fix it, we run the program again, and make sure the fix we deployed actually fixed the problem/bug
This has served us well, and you can get pretty far in this manual testing.

But what if, there is a whole team working on a piece of software, or what if, you're building a big application with many moving parts, or you plan on supporting that application for years to come?

As we write more functionality and add new features to our program, we have to make sure that not only the new feature we are adding works, but also, ALL of the pre-existing features Still work. This si okay to manually confirm when the program is small, but as the program graws, doing this manually becomes inefficient super quickly.

## Automated Tests
Instead of manually testing every single piece of code for its intended behavior, we write instruction for the testing frameworks to execute to make sure the code functions as its supposed to.

## Different Types of Testing
- Unit Testing: testing the smallest subsection of code you can separate it out
- Integration Testing
- End to End Testing

## Unit Testing
Is a type of testing that is focused on testing a _small, isolated_ piece of code.
Unit testing works on the premise of if all individual, small parts work, collection of them should also work.

## cUnit
Is the testing framework for C#. 

## NuGet Package Manager
This is where you go and find all the tools, libraries, and frameworks available in .NET Platform. Support for NuGet is integrated in .NET SDK. In order to use it, you go `dotnet add package package-name` inside your project folder. Go to [NuGet](https://www.nuget.org/) to browse which packages are available for use.

## How to initialize a testing project
We'll create a separate testing project where we'll put all our testing code.
We'll take advantage of one .NET SDK's templates to get us a testing project
`dotnet new xunit -n test-project-name-here`

