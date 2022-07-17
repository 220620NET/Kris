# Asynchronous Programming

Asynchronous programming is a way to execute code without pausing programs to wait for all its inner processes to be complete

When we call async functions/methods they at first return `Task<T>`. This s a way for the progam to say "Irecieved your request, I'm working on it right now, please check back later" Ex. `Task<PokeTrainer>`
We get notified when the operation has been completed, when we use the `await` keyword
Any method that uses async has to also be async.

- async
- await
