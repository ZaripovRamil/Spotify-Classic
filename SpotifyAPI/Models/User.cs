namespace Models;

public class User
{
    public string Id = Guid.NewGuid().ToString();
    public List<Track> History { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Role Role{ get; set; }
    public string Salt { get; set; }
    public string Password { get; set; }
}