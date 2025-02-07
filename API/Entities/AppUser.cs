using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class AppUser
{
    public int Id { get; set; } = 0;

    public required string UserName { get; set; }
}
