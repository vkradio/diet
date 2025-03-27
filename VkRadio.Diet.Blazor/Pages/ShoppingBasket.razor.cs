using Microsoft.AspNetCore.Components;
using PizzaPlace.Shared;

namespace PizzaPlace.Client.Pages;

public partial class ShoppingBasket
{
    private IEnumerable<(Pizza pizza, int pos)> _pizzas = default!;

    private decimal _totalPrice { get; set; }

    protected override void OnParametersSet()
    {
        _pizzas = Orders
            .Select((id, pos) => (pizza: GetPizzaFromId(id), pos));

        _totalPrice = _pizzas
            .Select(x => x.pizza.Price)
            .Sum();
    }

    [Parameter]
    public IEnumerable<int> Orders { get; set; } = default!;

    [Parameter]
    public EventCallback<int> Selected { get; set; }

    [Parameter]
    public Func<int, Pizza> GetPizzaFromId { get; set; } = default!;
}
