namespace STUDY.UnitTestingDemo.UnitTests;

public class ValidatorHelperTests
{
    private static readonly object[] IsValidIntegerCases =
    {
        new TestCaseData("123",      true,  123),
        new TestCaseData("123 ",     true,  123),
        new TestCaseData(" 123",     true,  123),
        new TestCaseData(" 123 ",    true,  123),
        new TestCaseData("0",        true,  0),
        new TestCaseData("-50",      true,  -50),
        new TestCaseData(" -50 ",    true,  -50),

        new TestCaseData("",         false, 0),
        new TestCaseData(" ",        false, 0),
        new TestCaseData("   ",      false, 0),
        new TestCaseData("\t",       false, 0),
        new TestCaseData("\n",       false, 0),

        new TestCaseData(null,       false, 0),

        new TestCaseData("abc",      false, 0),
        new TestCaseData("one",      false, 0),
        new TestCaseData("minus five", false, 0),

        new TestCaseData("123abc",   false, 0),
        new TestCaseData("abc123",   false, 0),
        new TestCaseData("12 3",     false, 0),
        new TestCaseData("1 2 3",    false, 0),

        new TestCaseData("!",        false, 0),
        new TestCaseData("#$%",      false, 0),
        new TestCaseData("12!",      false, 0),
        new TestCaseData("--1",      false, 0),
        new TestCaseData("++1",      false, 0),
        new TestCaseData("+-1",      false, 0),
        new TestCaseData("-",        false, 0),
        new TestCaseData("+",        false, 0),

        new TestCaseData("12.3",     false, 0),
        new TestCaseData("-12.3",    false, 0),
        new TestCaseData("1,234.00", false, 0),
        new TestCaseData("1.0e3",    false, 0),
        new TestCaseData("1e3",      false, 0),

        new TestCaseData("1,234",       false, 0),
        new TestCaseData("0x10",        false, 0),
        new TestCaseData("0b1010",      false, 0),

        new TestCaseData("2147483648",  false, 0),
        new TestCaseData("-2147483649", false, 0),
    };
    private ValidationService _validationService;

    [SetUp] 
    public void Setup()
    {
        _validationService = new ValidationService(false);
    }

    [TestCaseSource(nameof(IsValidIntegerCases))]
    public void CorrectInput_ReturnsTrue_AndResultingIntegerIsCorrect(
        string input,
        bool expectedResult,
        int expectedValidatedValue)
    {
        var isValidInteger = _validationService.IsValidInteger(input, out int validInteger);

        Assert.That(isValidInteger, Is.EqualTo(expectedResult));
        Assert.That(validInteger, Is.EqualTo(expectedValidatedValue));
    }
}
