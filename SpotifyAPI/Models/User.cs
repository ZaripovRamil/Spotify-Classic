using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Models;

[PrimaryKey("Id")]

public class User:IdentityUser//TODO:return author as inheritor with Albums property
{
    public List<Track> History { get; set; }
    public string Name { get; set; }
    public Role Role{ get; set; }
    public User()
    {
    }
}