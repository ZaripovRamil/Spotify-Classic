namespace Utils.CQRS;

public class Result
{
    public bool IsSuccessful { get; private set; }
    public IReadOnlyList<string> Errors => _errors.AsReadOnly();
    
    private readonly List<string> _errors = new();

    public Result()
    {
        IsSuccessful = true;
    }

    public Result(params string[] errors)
    {
        IsSuccessful = false;
        AddErrors(errors);
    }

    public void Fail() => IsSuccessful = false;

    public void AddErrors(params string[] errors)
    {
        IsSuccessful = false;
        foreach (var error in errors)
            _errors.Add(error);
    }

    public string JoinErrors(char separator = '\n') => string.Join(separator, Errors);
}

public class Result<TValue> : Result
{
    public Result(TValue value)
    {
        Value = value;
    }

    public Result(params string[] errors) : base(errors)
    {
    }
    
    public TValue? Value { get; }
    
    public static implicit operator Result<TValue>(TValue value) => new(value);
}