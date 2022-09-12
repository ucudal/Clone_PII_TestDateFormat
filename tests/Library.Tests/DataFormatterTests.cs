namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestFechaFormatoIncorrecto()
    {
        var testDate = "11/456/43";
        var expectedResult =  "error data format incorrect";
        var result = DateFormatter.ChangeFormat(testDate) == expectedResult;
        
        Assert.isFalse(result);
    }
}