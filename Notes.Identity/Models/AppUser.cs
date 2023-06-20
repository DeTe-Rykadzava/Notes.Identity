using Microsoft.AspNetCore.Identity;

namespace Notes.Identity.Models;

public class AppUser : IdentityUser
{
    public string Username { get; set; } = "user";
    public string Lastname { get; set; } = "user";
}