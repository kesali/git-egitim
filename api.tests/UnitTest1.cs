using Api.Services;

namespace api.tests;

public class UnitTest1
{
    private readonly WeatherService _sut = new();

    [Fact]
    public void Test1()
    {
        Assert.Equal("Istanbul 22°", _sut.GetCurrentWeather());
    }
}