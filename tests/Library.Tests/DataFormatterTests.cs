namespace Library.Tests;
using TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestFechaFormatoCorrecto()
    {
        string testDate = "12/11/1999";
        string expectedResult =  "1999-11-12";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }
    [Test]
    public void TestFechaFormatoIncorrecto()
    {
        string testDate = "12/11199";
        string expectedResult = "Error: formato incorrecto";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }
    [Test]
    public void TestFechaEnBlanco()
    {
        string testDate = "";
        string expectedResult = "Error: fecha en blanco";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }

}