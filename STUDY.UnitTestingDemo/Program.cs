using STUDY.UnitTestingDemo;

int validatedInput;
bool isInputValid;

do
{
    Console.Write("Please enter a valid integer: ");
    var input = Console.ReadLine();

    isInputValid = ValidatorHelper.IsValidInteger(input, out validatedInput);

    if (!isInputValid)
    {
        Console.WriteLine("Invalid input. Please try again.");
    }
} while (!isInputValid);
