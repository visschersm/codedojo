namespace greed.tests;

using FluentAssertions;

public class UnitTest1
{
    [Theory]
    [InlineData(100, new int[] { 1 })]
    [InlineData(200, new int[] { 1, 1 })]
    [InlineData(1000, new int[] { 1, 1, 1 })]
    [InlineData(200, new int[] { 2, 2, 2 })]
    [InlineData(300, new int[] { 3, 3, 3 })]
    [InlineData(400, new int[] { 4, 4, 4 })]
    [InlineData(500, new int[] { 5, 5, 5 })]
    [InlineData(600, new int[] { 6, 6, 6 })]
    [InlineData(50, new int[] { 5 })]
    [InlineData(100, new int[] { 5, 5 })]
    [InlineData(1150, new int[] { 1, 1, 1, 5, 1 })]
    [InlineData(0, new int[] { 2, 3, 4, 6, 2 })]
    [InlineData(350, new int[] { 3, 4, 5, 3, 3 })]
    public void One_ShouldReturn(int expectedResult, int[] dieList)
    {
        var result = GreedCalculator.Calculate(dieList.ToList());
        result.Should().Be(expectedResult);
    }
}
