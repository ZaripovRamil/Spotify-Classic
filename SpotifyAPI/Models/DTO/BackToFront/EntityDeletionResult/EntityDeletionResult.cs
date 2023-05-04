namespace Models.DTO.BackToFront.EntityDeletionResult;

public abstract class EntityDeletionResult
{
    public bool IsSuccessful { get; set; }
    public string ResultMessage { get; set; }
}