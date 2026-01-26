# Async vs Multithreading in C#

>In C#, performance and responsiveness can be improved using **asynchronous programming** or **multithreading**.  
Although both help applications run better, they are **not the same** and are used for **different types of problems**.

## What is Multithreading?

>Multithreading means running **multiple threads at the same time**.  
Each thread can execute code independently and can use the CPU in parallel.

### Key Characteristics
- Uses multiple threads
- Threads can run simultaneously
- Best for **CPU-bound tasks**

### Example
```
Thread t1 = new Thread(DoWork1);
Thread t2 = new Thread(DoWork2);

t1.Start();
t2.Start();
```
### common use cases
>In heavily coalculations and image simulations, Games development, Real-time data processing like image and video rendering.



## What is Async / Await?

>Async programming allows a program to wait for an operation without blocking the thread.
It is mainly designed for **I/O-bound operations**.

### Key Characteristics
-Uses Task, async, and await
-Does not block threads
-Improves responsiveness
-More scalable

### Example
```
await Task.Delay(2000);
```
### common use cases
>In web applications for database calls, File I/O operations, Network requests like calling APIs.

### core differences
>**multithreding**:-Doing multiple tasks at the same time.

>**async/await**:-Waiting for a task to complete without blocking the main thread.



# Common Async Pitfalls in C#

## Introduction

Asynchronous programming using async and await makes applications more responsive and scalable.  
However, if used incorrectly, it can introduce bugs that are **hard to detect and debug**.

## 1. Forgetting to Use await

### Problem
>Calling an async method without await starts the task but does not wait for it to finish.

### Wrong Example
```csharp
FetchDataAsync();
Console.WriteLine("Completed");
```
>problem:-The "Completed" message may print before FetchDataAsync finishes, result may not be available.

### Correct Example
```
await FetchDataAsync();
```

## 2. Using async void Instead of async Task

### Problem
>Using async void hides exceptions and prevents proper error handling.

>problem:-Exceptions crash the application, and methos cannot be await.

### correct Example
```csharp
async Task SaveData() { }
```

## 3. Blocking Async Code with .Result or .Wait()

### Problem
>Blocking an async method defeats the purpose of async and may cause deadlocks.

### Wrong Example
```
var data = FetchDataAsync().Result;
```
>Problem:-it blocks the thread and Can cause deadlocks especially in UI apps.

### Correct Example
```
var data = await FetchDataAsync();
```


## 4. Using Thread.Sleep Inside Async Methods

### Problem
>Thread.Sleep blocks the thread and stops other work from happening.

### Wrong Example
```
Thread.Sleep(2000);
```

>Problem:-It blocks the thread and Reduces scalability

### Correct Example
```
await Task.Delay(2000);
```


### 5. Not Handling Exceptions in Async Methods

## Problem
>Unhandled exceptions in async methods can crash the application.

### Wrong Example
```
await FetchDataAsync();
```
>Problem:-Errors go unnoticed and Application may terminate

### Correct Example
```
try
{
    await FetchDataAsync();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
```

## 6. Fire-and-Forget Async Calls

### Problem
>Starting a task without tracking or awaiting it.

### Wrong Example
```
Task.Run(() => DoWork());
```

>Problem:-Task failures are ignored and No guarantee to the task completes

### Correct Example
```
await Task.Run(() => DoWork());
```
