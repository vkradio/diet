namespace VkRadio.Diet.Model.Entities;

public class Food
{
    public Guid Id { get; set; }

    public string Name { get; set; } = default!;

    public decimal Protein { get; set; }

    public decimal Fat { get; set; }

    public decimal Carbohydrate { get; set; }

    public int Calories { get; set; }

    /// <summary>
    ///  Standard portion, grams
    /// </summary>
    public int? Portion { get; set; }

    public string? PortionDescription { get; set; }

    /// <summary>
    ///  To hide rare foods from clattering the dictionary list, assign higher number here
    /// </summary>
    public int DictionaryQueue { get; set; }
}
