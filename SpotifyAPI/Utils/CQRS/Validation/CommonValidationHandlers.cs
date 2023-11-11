namespace Utils.CQRS.Validation;

public static class CommonValidationHandlers
{
    public static bool ContainOnlyAllowedCharacters(string s) => s.All(c =>
        char.IsDigit(c) || char.IsLetter(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c));

    public static bool BeNotNullNotEmpty(string s) => !string.IsNullOrEmpty(s);
}