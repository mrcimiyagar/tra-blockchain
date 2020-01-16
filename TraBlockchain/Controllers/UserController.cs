using System.Collections.Generic;
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
            using (var dbContext = new DatabaseContext()) 
            {
                var users = await dbContext.Users.ToListAsync();
                return Ok(users);
            }
        }
        
        [HttpGet("~/api/user/{id}")]
        public async Task<ActionResult<User>> FindUserById(int id)
        {
            using (var dbContext = new DatabaseContext()) 
            {
                var user = await dbContext.Users.FindAsync(id);
                return Ok(user);
            }
        }
    }
}