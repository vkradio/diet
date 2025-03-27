using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPlace.Shared;

namespace PizzaPlace.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly PizzaPlaceDbContext _dbContext;

    public OrdersController(PizzaPlaceDbContext dbContext) => _dbContext = dbContext;

    [HttpPost("/orders")]
    public IActionResult InsertOrder([FromBody] ShoppingBasket basket)
    {
        var order = new Order
        {
            Customer = basket.Customer,
            Pizzas = new List<Pizza>()
        };

        foreach (var pizzaId in basket.Orders)
        {
            var pizza = _dbContext.Pizzas.Single(x => x.Id == pizzaId);
            order.Pizzas.Add(pizza);
        }

        _dbContext.Orders.Add(order);
        _dbContext.SaveChanges();

        return Created("/orders", order.Id);
    }
}
