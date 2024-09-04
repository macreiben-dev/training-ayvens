using NFluent;

namespace FooBarQixFactory;

public class UnitTest1
{
    private const string Buzz = "Buzz";
    private const string Fizz = "Fizz";

    /**
    Iteration 1

    Write a fizzBuzzIter1 method that take an integer as an input and return:

    If the input is divisible by 3, return Fizz
    If the input is divisible by 5, return Buzz
    If the input is divisible by 3 and 5, return FizzBuzz
    Else return the input

     */

    [Fact]
    public void Should_return_buzz_when_5()
    {
        // ARRANGE
        var input = 5;
        
        // ACT
        string actual = FizzBuzzComputation.Compute(input);
        
        // ASSERT
        Check.That(actual).IsEqualTo(Buzz);
    }

    [Fact]
    public void Should_return_fizz_when_3()
    {
        // ARRANGE
        var input = 3;
        
        // ACT
        string actual = FizzBuzzComputation.Compute(input);
        
        // ASSERT
        Check.That(actual).IsEqualTo(Fizz);
    }

}

public class FizzBuzzComputation
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";

    public static string Compute(int i)
    {
        if (i == 3)
        {
            return Fizz;
        }
        return Buzz;
    }
}