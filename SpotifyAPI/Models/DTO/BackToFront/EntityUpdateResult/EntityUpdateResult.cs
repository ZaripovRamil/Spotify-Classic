namespace Models.DTO.BackToFront.EntityUpdateResult;

public abstract class EntityUpdateResult
{
    public bool IsSuccessful { get; set; }
    public string ResultMessage { get; set; } = default!;
}