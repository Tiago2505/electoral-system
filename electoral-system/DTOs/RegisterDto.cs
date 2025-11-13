using System.ComponentModel.DataAnnotations;

namespace electoral_system.DTOs;

public class RegisterDto
{
    [Required(ErrorMessage = "El email es requerido")]
    [EmailAddress(ErrorMessage = "El  email es invalido")]
    public string Email { get; set; } = string.Empty;
    [Required(ErrorMessage = "El password es requerido")]
    [MinLength(6, ErrorMessage = "El password debe tener 6 caracteres")]
    public string Password { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "El username es requerido")]
    public string FullName { get; set; } = string.Empty;
    
}