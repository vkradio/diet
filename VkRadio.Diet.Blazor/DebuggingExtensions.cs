using System.Text.Json;

namespace PizzaPlace.Client;

public static class DebuggingExtensions
{
    private static JsonSerializerOptions _options = new JsonSerializerOptions { WriteIndented = true };

    public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, _options);
}
