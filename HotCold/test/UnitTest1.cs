using Xunit;

public class PrimeService()
{
    public bool IsPrime(int candidate)
    {
        if (candidate < 2)
        {
            return false;
        }
        if (candidate == 2)
        {
            return true;
        }
        throw new NotImplementedException("Not fully implemented.");
    }
}

[Theory]
[InlineData(-1)]
[InlineData(0)]
[InlineData(1)]
[InlineData(2)]
public void IsPrime_ReturnFalse(int value)
{
    var _primeService = new PrimeService();
    bool result = _primeService.IsPrime(value);

    Assert.False(result);
}