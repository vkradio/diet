namespace PizzaPlace.Shared;

public class Menu
{
    public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

    public void Add(Pizza pizza) => Pizzas.Add(pizza);

    public Pizza? GetPizza(int id) => Pizzas.FirstOrDefault(x => x.Id == id);
}
