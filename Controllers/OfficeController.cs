using Microsoft.AspNetCore.Mvc;
using Person.Data;
using Person.Models;

namespace Person.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfficeController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public OfficeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] Office office)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _appDbContext.Offices.Add(office);
            await _appDbContext.SaveChangesAsync();

            return Ok("Escritório criado");
        }
    }
}