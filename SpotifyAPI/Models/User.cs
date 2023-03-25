using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Models;

[PrimaryKey("Id")]

public class User:IdentityUser
{
    public List<Track> History { get; set; }
    public string Name { get; set; }
    public Role Role{ get; set; }
    public User()
    {
    }
}