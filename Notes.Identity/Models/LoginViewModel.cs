using System.ComponentModel.DataAnnotations;

namespace Notes.Identity.Models;

public class LoginViewModel
{
    public string ReturnUrl { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}