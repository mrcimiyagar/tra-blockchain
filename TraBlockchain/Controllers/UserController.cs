using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using TraBlockchain.Entities;

namespace TraBlockchain.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
       [HttpGet("~/api/user")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsersList()
        {
            await using (var dbContext = new DatabaseContext()) 
            {
                var users = await dbContext.Users.ToListAsync();
                return Ok(users);
            }
        }
        
        [HttpPost("~/api/loginuser")]
        public async Task<ActionResult<User>> FindUser(User user)
        {
            Console.WriteLine("uUSSAAS" + user.Name);
            await using (var dbContext = new DatabaseContext()) 
            {
                var query = await dbContext.Users
                    .Where(u => u.Name == user.Name)
                    .FirstOrDefaultAsync();
                
                if ( query != null && query.Password.Equals(user.Password))
                {
                   
                    return Ok(user);
                }
                else
                {
                    Console.WriteLine("name of user is" + user.Name);
                    return Ok(user.Name);
                }
            }
        }
    }
}