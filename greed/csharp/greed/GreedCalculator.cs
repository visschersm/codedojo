namespace greed;

public static class GreedCalculator
{
    public static int Calculate(List<int> dieList)
    {
        var result = dieList.CountBy(x => x).Sum(x =>
        {
            return x switch
            {
                { Key: 1 } => x.Value / 3 * 1000 + x.Value % 3 * 100,
                { Key: 5, Value: 3 } => 500,
                { Key: 5 } => x.Value * 50,
                { Value: 3 } => x.Key * 100,
                _ => 0,
            };
        });


        return result;
    }
}
