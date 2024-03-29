using Xunit;

public class CalculatorTests
{
    [Fact]
    public void TestAddition()
    {
        // given ._.
        Calculator calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 7;

        // when
        int result = calc.Add(a, b);
    

        // then
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestSubstraction()
    {
        // given ._.
        Calculator calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 3;

        // when
        int result = calc.Subtract(a, b);
    

        // then
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestDivison()
    {
        // given
        Calculator calc = new Calculator();
        int a = 10;
        int b = 2;
        double expectedResult = 5.0;
        // when
        double result = calc.Divide(a, b);
        // then
        Assert.Equal(expectedResult, result);
    }

        [Fact]
    public void TestMultiplication()
    {
        // given
        Calculator calc = new Calculator();
        int a = 5;
        int b = 2;
        double expectedResult = 10;
        // when
        double result = calc.Multiply(a, b);
        // then
        Assert.Equal(expectedResult, result);
    }
}