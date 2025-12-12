namespace STUDY.UnitTestingDemo;

public class ValidatorHelper()
{
    public static bool IsValidInteger(string input, out int result)
    {
        return int.TryParse(input, out result);
    }
}
