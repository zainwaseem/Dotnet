using Microsoft.AspNetCore.Mvc;
using MyApi.Models;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Zaid" },
            new User { Id = 2, Name = "Umair" }
        };

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return Ok(users);
        }

        [HttpPost]
        public ActionResult<User> AddUser(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
            return Ok(user);
        }
    }
}
