namespace STUDY.UnitTestingDemo;

public class ValidatorService(bool areNegativeNumbersAllowed = true)
{
    public bool IsValidInteger(string input, out int result)
    {
        return int.TryParse(input, out result) 
            &&  (areNegativeNumbersAllowed || result >= 0);
    }
}
