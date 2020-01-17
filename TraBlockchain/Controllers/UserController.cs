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
        public async Task<ActionResult<User>> LoginUser(LoginModel model)
        {
          
            await using (var dbContext = new DatabaseContext()) 
            {
                var query = await dbContext.Users
                    .Where(u => u.Name == model.Name)
                    .FirstOrDefaultAsync();
                
                if ( query != null && query.Password.Equals(model.Password))
                {
                   
                    return Ok(query);
                }
                else
                {
                    return BadRequest(new { message = "Username or password is incorrect" });
                }
            }
        }


        [HttpPost("~/api/registeruser")]
        public async Task<ActionResult<User>> RegisterUser(RegisterModel model)
        {
            await using (var DbContext = new DatabaseContext())
            {
                
            }
        }
    }
}