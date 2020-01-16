using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using TraBlockchain.Entities;
using System.IO;

namespace TraBlockchain.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        [HttpGet("/")]
        public ActionResult Get()
        {
            return base.Content(System.IO.File.ReadAllText("ClientApp/build/index.html"), "text/html");
        }
    }
}