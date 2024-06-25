using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using login_feature2.Models;
using Microsoft.AspNetCore.Identity;

namespace login_feature2.Data;

public class ApplicationDbContext : IdentityDbContext<Users>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    public override DbSet<Users> Users { get; set; }

}
