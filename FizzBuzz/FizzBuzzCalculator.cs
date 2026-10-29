namespace FizzBuzz;

// Do not write anything here until a failing test requires it.
// Start in FizzBuzz.Tests/FizzBuzzTests.cs — write a test first,
// watch it fail, then come back here.
public class FizzBuzzCalculator
{
    // Your implementation goes here — driven by failing tests.
    
    // Resolving Test Iteration 1: couldn't even run, and hence couldn't fail
    // Successful code: Established FizzBuzz constructor and Calculate function that could return "1" if inputted 1.
    public FizzBuzzCalculator(){}
    public string Calculate(int input)
	{
		// Resolving Test Iteration 5: Test 1 through 3 passed, Test 5 failed, as Calculate didn't return expected "0" when input = 0
		// Successful code: Establishing additional if logic to return "0" if the input is "indivisible"
        if (input == 0) 
        {
            return "0";
        }
		if (input % 3 == 0 && input % 5 == 0)
		{
			return "FizzBuzz";
		}
		// Resolving Test Iteration 4: Test 1 through 3 passed, Test 4 failed, as Calculate didn't return expected "FizzBuzz" when input = 15
		// Successful code: Establishing additional if logic to return "FizzBuzz" if the input is divisible by five AND three
		if (input % 3 == 0 && input % 5 == 0) 
        {
            return "FizzBuzz";
        }
        // Resolving Test Iteration 2: Test 1 passed, Test 2 failed, as Calculate didn't return expected "Fizz" when input = 3
        // Successful code: Establishing if logic, allowing a function with the input divisible by three to return "Fizz"
        if (input % 3 == 0)
        {
            return "Fizz";
        }
        // Resolving Test Iteration 3: Test 1 & 2 passed, Test 3 failed, as Calculate didn't return expected "Buzz" when input = 5
        // Successful code: Establishing additional if logic to return "Buzz" if the input is divisible by five
        if (input % 5 == 0)
        {
            return "Buzz";
        }
        return input.ToString(); 
       
    }
}
