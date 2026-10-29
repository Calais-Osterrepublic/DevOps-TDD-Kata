using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests;

/// <summary>
/// FizzBuzz TDD Kata — Week 8
///
/// Rules:
/// 1. Write a failing test FIRST. Run it. Confirm it fails.
/// 2. Write the minimum code to make it pass. Run all tests.
/// 3. Refactor if needed. Run all tests again.
/// 4. Repeat for the next iteration.
///
/// Do NOT write FizzBuzzCalculator code until you have a failing test.
/// </summary>
[TestClass]
public class FizzBuzzTests
{
    // Write your tests below — one iteration at a time.
    // Iteration 1: test that Calculate(1) returns "1"
    [TestMethod]
    public void FizzBuzz_CalculateOneReturnsOne() 
    {
        // Arrange
        FizzBuzzCalculator calculator = new FizzBuzzCalculator();

        // Act
        var result = calculator.Calculate(1);

        // Assert
        Assert.AreEqual("1", result);
    }
    // Iteration 2: test that Calculate(3) returns "Fizz"
    [TestMethod]
    public void FizzBuzz_CalculateThreeReturnsFizz()
    {
        // Arrange
        FizzBuzzCalculator calculator = new FizzBuzzCalculator();

        // Act
        var result = calculator.Calculate(3);

        // Assert
        Assert.AreEqual("Fizz", result);

    }
    // Iteration 3: test that Calculate(5) returns "Buzz"
    [TestMethod]
    public void FizzBuzz_CalculateFiveReturnsBuzz()
    {
        // Arrange
        FizzBuzzCalculator calculator = new FizzBuzzCalculator();

        // Act
        var result = calculator.Calculate(5);

        // Assert
        Assert.AreEqual("Buzz", result);

    }
    // Iteration 4: test that Calculate(15) returns "FizzBuzz"
    [TestMethod]
    public void FizzBuzz_CalculateFifteenReturnsFizzBuzz() 
    {
		// Arrange
		FizzBuzzCalculator calculator = new FizzBuzzCalculator();

		// Act
		var result = calculator.Calculate(15);

		// Assert
		Assert.AreEqual("FizzBuzz", result);
	}

    // Iteration 5: pick at least one edge case and test it
    // Selected: test that Calculate(0) returns "0"
    [TestMethod]
    public void FizzBuzz_CalculateZeroReturnsZero() 
    {
		// Arrange
		FizzBuzzCalculator calculator = new FizzBuzzCalculator();

		// Act
		var result = calculator.Calculate(0);

		// Assert
		Assert.AreEqual("0", result);
	}
}
