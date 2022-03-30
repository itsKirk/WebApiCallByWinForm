using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Filters;
using Shared.Models;

namespace Server.Controllers
{
  [Route("[controller]")]
  [ApiController]
  //[ApiKeyAuth]
  public class PeopleController : ControllerBase
  {
    private readonly ApplicationDbContext _db;

    public PeopleController(ApplicationDbContext db)
    {
      _db = db;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      try
      {
        return Ok(await _db.People.ToListAsync());
      }
      catch (Exception ex)
      {
        return StatusCode(500,
            ex.Message);
      }
    }
    [HttpPost]
    public async Task<ActionResult> Post(Person person)
    {
      try
      {
        _db.People.Add(person);
        await _db.SaveChangesAsync();
        return StatusCode(201);
      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
      }
    }
  }
}
