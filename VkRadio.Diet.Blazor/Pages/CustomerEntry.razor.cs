using Microsoft.AspNetCore.Components;
using PizzaPlace.Shared;

namespace PizzaPlace.Client.Pages;

public partial class CustomerEntry
{
    private bool _isInvalid = true;
    private InputWatcher _inputWatcher = default!;

    private void FieldChanged(string fieldName)
    {
        CustomerChanged.InvokeAsync(Customer);
        _isInvalid = !_inputWatcher.Validate();
    }

    [Parameter]
    public string Title { get; set; } = default!;

    [Parameter]
    public string ButtonTitle { get; set; } = default!;

    [Parameter]
    public string ButtonClass { get; set; } = default!;

    [Parameter]
    public Customer Customer { get; set; } = default!;

    [Parameter]
    public EventCallback ValidSubmit { get; set; }

    [Parameter]
    public EventCallback<Customer> CustomerChanged { get; set; }
}
