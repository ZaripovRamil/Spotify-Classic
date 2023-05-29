using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Subscription : Entity
{
    public decimal Price { get; set; }
}