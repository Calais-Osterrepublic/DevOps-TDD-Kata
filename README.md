# FizzBuzz TDD Kata — C#

This is a standalone practice app for the Week 8 TDD kata. It is **not** part of LibraryApp.

## Setup

Open `FizzBuzz.sln` in Visual Studio 2026.

## Running tests

Test menu → Test Explorer → Run All.
You should see 0 tests collected initially — that's correct.
As you add tests, they will appear here.

## The kata

See `FizzBuzz.Tests/FizzBuzzTests.cs` for instructions. Work through five iterations:

1. `Calculate(1)` returns `"1"`
2. `Calculate(3)` returns `"Fizz"`
3. `Calculate(5)` returns `"Buzz"`
4. `Calculate(15)` returns `"FizzBuzz"`
5. At least one edge case of your choice

**Rules:** Write a failing test first. Watch it fail. Write minimum code to pass. Refactor. Repeat.

## File structure

```
FizzBuzz.sln
FizzBuzz/
  FizzBuzzCalculator.cs   ← your implementation (starts empty)
  Program.cs              ← optional console runner
FizzBuzz.Tests/
  FizzBuzzTests.cs        ← your tests (write these first)
```
