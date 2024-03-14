using Crud_Unit_Test.Models;
using Crud_Unit_Test.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Unit_Test.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _UserService;

        public UserController(IUserService UserService)
            => _UserService = UserService;

        [HttpPost]
        public async Task<ActionResult<User>> PostAsync(User User)
            => await _UserService.AddAsync(User);

        [HttpGet]
        public async Task<ActionResult<User>> GetAsync(int id)
            => await _UserService.GetAsync(id);

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllAsync()
            => await _UserService.GetAllAsync();

        [HttpPut]
        public async Task<ActionResult<User>> PutAsync(int id, User User)
            => await _UserService.UpdateAsync(User, id);

        [HttpDelete]
        public async Task<ActionResult<User>> DeleteAsync(int id)
            => await _UserService.DeleteAsync(id);
    }
}
