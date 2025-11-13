using System.ComponentModel.DataAnnotations;

namespace electoral_system.DTOs;

public class LoginDto
{
    [Required(ErrorMessage = "El campo Email es obligatorio")]
    [EmailAddress(ErrorMessage = "El email es invalido")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "El password es requerido")]
    public string Password { get; set; } = string.Empty;
}