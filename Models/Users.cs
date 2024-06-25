using Microsoft.AspNetCore.Identity;

namespace login_feature2.Models;

public class Users : IdentityUser
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Address { get; set; }
}
