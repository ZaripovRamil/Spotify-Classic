namespace Models.DTO.BackToFront.EntityCreationResult;

public abstract class EntityCreationResult
{
    public bool IsSuccessful { get; set; }
    public string ResultMessage { get; set; } = default!;
}