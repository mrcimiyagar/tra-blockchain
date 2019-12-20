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
        private readonly DatabaseContext _context;
        private readonly ILogger<UserController> _logger;

        UserController(DatabaseContext context, ILogger<UserController> logger)
        {
            _context = context;
            _logger = logger;
        }
        // GET: /HelloWorld/
       

        // the reason we use async method is to avoid blocking the main thread request. pass the request to a different thread an await 
        //response from the database
        
       [HttpGet("userlist")]
        public async Task<ActionResult<IEnumerable<User>>> UsersList()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }
        
        [HttpGet("userinfo/{id}")]
        public async Task<ActionResult<User>> UserInfo(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return Ok(user);
        }
 
        // 
        // GET: /HelloWorld/Welcome/ 
 

    }
}