using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Person.Data;
using Person.Models;

namespace Person.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public UserController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _appDbContext.Users.Add(user);
            await _appDbContext.SaveChangesAsync();

            return Ok("Usuário criado");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _appDbContext.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetOnlyUser(int id)
        {
            var user = await _appDbContext.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound("Usuário não encontrado");
            }

            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User newUser)
        {
            var oldUser = await _appDbContext.Users.FindAsync(id);

            if (oldUser == null)
            {
                return NotFound("Usuário não encontrado");
            }

            _appDbContext.Entry(oldUser).CurrentValues.SetValues(newUser);
            await _appDbContext.SaveChangesAsync();
            return StatusCode(201, oldUser);
        }

        [HttpDelete("{id}")]        
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _appDbContext.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound("Usuário não encontrado");
            }

            _appDbContext.Users.Remove(user);
            await _appDbContext.SaveChangesAsync();

            return Ok("Usuário deletado");
        }
    }
}