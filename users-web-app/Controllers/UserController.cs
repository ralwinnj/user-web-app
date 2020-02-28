using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using users_web_app.Models;
using users_web_app.Services;

namespace users_web_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ILogger _logger;
        private IUserService _service;

        public UserController(ILogger<UserController> logger, IUserService service)
        {
            _logger = logger;
            _service = service;
        }

        // GET: api/User
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
             return _service.GetUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<User> GetUsers(int id)
        {
             return _service.GetUsers(id);
        }

        // POST: api/User
        [HttpPost]
        public ActionResult<User> AddUser([FromBody] User user)
        {
            return _service.AddUser(user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public ActionResult<User> UpdateUser(int id, [FromBody] User user)
        {
            return _service.UpdateUser(id, user);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<String> DeleteUser(int id)
        {
            var res = _service.DeleteUser(id);
            //_logger.LogInformation("Users", user);
            return res;
        }
    }
}
