namespace OrderFoodSample
{

    //Product
    public class Meal
    {
        public string? MainCourse { get; set; }
        public string? Drink { get; set; }
        public string? Desert { get; set; }

        public void ShowMeal()
        {
            Console.WriteLine("Meal includes:");
            if (!string.IsNullOrWhiteSpace(MainCourse)) Console.WriteLine($"Main Course: {MainCourse}");
            if (!string.IsNullOrWhiteSpace(Drink)) Console.WriteLine($"Drink : {Drink}");
            if (!string.IsNullOrWhiteSpace(Desert)) Console.WriteLine($"Desert : {Desert}");
        }
    }

}
