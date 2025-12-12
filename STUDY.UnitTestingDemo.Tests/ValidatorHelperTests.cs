namespace STUDY.UnitTestingDemo.Tests;

public class ValidatorHelperTests
{
    [TestCase("123", true, 123)]
    [TestCase("123 ", true, 123)]
    [TestCase(" 123", true, 123)]
    [TestCase(" 123 ", true, 123)]
    [TestCase("0", true, 0)]
    public void CorrectInput_ReturnsTrue_AndResultingIntegerIsCorrect(
       string input,
       bool expectedResult,
       int expectedValidatedValue)
    {
        var isValidInteger = ValidatorHelper.IsValidInteger(input, out int validInteger);

        Assert.That(isValidInteger, Is.EqualTo(expectedResult));
        Assert.That(validInteger, Is.EqualTo(expectedValidatedValue));
    }

    [Test]
    public void CorrectNegativeInput_ReturnsTrue()
    {
        var isValidInteger = ValidatorHelper.IsValidInteger("-50", out int validInteger);

        Assert.That(isValidInteger, Is.True);
        Assert.That(validInteger, Is.EqualTo(-50));
    }
}
