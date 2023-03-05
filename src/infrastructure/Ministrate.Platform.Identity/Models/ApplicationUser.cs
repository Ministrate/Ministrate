using Microsoft.AspNetCore.Identity;

namespace Ministrate.Platform.Identity.Models;

public class ApplicationUser : IdentityUser<int>
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}