using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public List<USers> users;
        public UserController() {
             users = new List<USers> { new USers { Name="adith",Email="adithcom"},
                new USers{Name="Anandhu",Email="Anandhu.com"},
                new USers{Name="Nandhu",Email="Nandhu.com"} };
        }
        [HttpGet]
        [Logging]
        public IActionResult GetAll()
        {
            return Ok(users);
        }
    }
    public class USers
    {
        public string Name { get; set; }
        public string Email { get; set; }
        
       
            
    }  
}
