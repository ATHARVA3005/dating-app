using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    public required string UserName  {get; set;}

    [Required]
    public required string Password {get; set;}
}
