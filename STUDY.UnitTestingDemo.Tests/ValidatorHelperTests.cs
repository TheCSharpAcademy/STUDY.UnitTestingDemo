namespace STUDY.UnitTestingDemo.Tests;

public class ValidatorHelperTests
{
    [Test]
    public void CorrectInput_ReturnsTrue()
    {
        var isValidInteger = ValidatorHelper.IsValidInteger("50", out int validInteger);

        Assert.That(isValidInteger, Is.True);
        Assert.That(validInteger, Is.EqualTo(50));
    }

    [Test]
    public void CorrectNegativeInput_ReturnsTrue()
    {
        var isValidInteger = ValidatorHelper.IsValidInteger("-50", out int validInteger);

        Assert.That(isValidInteger, Is.True);
        Assert.That(validInteger, Is.EqualTo(-50));
    }
}
