namespace STUDY.UnitTestingDemo.Tests;

public class ValidatorHelperTests
{
    private static readonly object[] IsValidIntegerCases =
    {
        new TestCaseData("123",true,123),
        new TestCaseData("123 ",true,123),
        new TestCaseData(" 123",true,123),
        new TestCaseData(" 123 ",true,123),
        new TestCaseData("0",true,0)
    };

    [TestCaseSource(nameof(IsValidIntegerCases))]
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
