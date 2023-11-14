namespace Models.ValidationErrors;

public static class EntityErrors
{
    public static string FieldEmpty(string field) => $"{field} should be not empty";
    public static string FieldInvalid(string field) => $"{field} is invalid";
    public static string FieldContainsUnacceptableCharacters(string field) =>
        $"{field} should contain only latin characters, digits or punctuation markers";
    public const string UnknownError = "Unknown error";
    public const string NameTaken = "An item with this name already exists";
}