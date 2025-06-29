using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazingPizza.Data;
using BlazingPizza.Model;

namespace BlazingPizza.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController(PizzaStoreContext db) : Controller
{
    private readonly PizzaStoreContext _db = db;

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}