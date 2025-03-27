namespace VkRadio.Diet.Model.Entities;

public class Meal
{
    public int Id { get; set; }

    public DateTime DateTime { get; set; }

    public Guid FoodId { get; set; }

    public Food Food { get; set; } = default!;

    public int Portion { get; set; }

    public decimal Protein { get; set; }

    public decimal Fat { get; set; }

    public decimal Carbohydrate { get; set; }

    public int Calories { get; set; }
}
