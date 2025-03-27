using Microsoft.AspNetCore.Mvc;
using PizzaPlace.Shared;

namespace PizzaPlace.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PizzasController : ControllerBase
{
    //private readonly static List<Pizza> _pizzas = new()
    //{
    //    new Pizza(1, "Pepperoni", 8.99m, Spiciness.Spicy),
    //    new Pizza(2, "Margarita", 7.99m, Spiciness.None),
    //    new Pizza(3, "Diabolo", 9.99m, Spiciness.Hot)
    //};

    private readonly PizzaPlaceDbContext _dbContext;

    public PizzasController(PizzaPlaceDbContext dbContext) => _dbContext = dbContext;

    [HttpGet("/pizzas")]
    public IQueryable<Pizza> GetPizzas() => _dbContext.Pizzas;

    [HttpPost("/pizzas")]
    public IActionResult InsertPizza([FromBody] Pizza pizza)
    {
        _dbContext.Pizzas.Add(pizza);
        _dbContext.SaveChanges();
        return Created($"pizzas/{pizza.Id}", pizza);
    }
}
