using Homework_3;

public class GenderValidator
{
    public static bool TryParseGender(string input, out Gender gender)
    {
        input = input.Trim().ToLower();
        if (int.TryParse(input, out int intValue))
        {
            if (Enum.IsDefined(typeof(Gender), intValue))
            {
                gender = (Gender)intValue;
                return true;
            }
        }
        switch (input)
        {
            case "male":
                gender = Gender.Male;
                return true;
            case "female":
                gender = Gender.Female;
                return true;
            case "unknown":
                gender = Gender.Unknown;
                return true;
        }
        gender = Gender.Unknown;
        return false;
    }
}