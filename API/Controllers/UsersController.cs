using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] //api/Users
public class UsersController(DataContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await context.Users.ToListAsync();

        return Ok(users);
    }

    [HttpGet("{id:int}")] //api/users
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var users = await context.Users.FindAsync(id);

        if(users == null) return NotFound();

        return users;
    }
}
